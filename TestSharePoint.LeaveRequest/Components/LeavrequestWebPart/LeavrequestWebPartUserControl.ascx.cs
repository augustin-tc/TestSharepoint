using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using TestSharePoint.LeaveRequest.Providers.Entitites;

namespace TestSharePoint.LeaveRequest.Components.LeavrequestWebPart
{
    public partial class LeavrequestWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.Page.Form.Enctype = "multipart/form-data";

            if (!string.IsNullOrEmpty(Request.QueryString["State"]))
            {
                if (Request.QueryString["State"] == "Validation")
                {
                    btAccept.Visible = true;
                    btReject.Visible = true;
                    btAccept.ServerClick += BtAccept_ServerClick;
                    btReject.ServerClick += BtAccept_ServerClick;

                    int id = int.Parse(Request.QueryString["ItemId"]);

                    LeaveRequestEntity leaveRequest = new LeaveRequestEntity();
                    leaveRequest.Load(id);

                    tbStartDate.SelectedDate = leaveRequest.StartDate;
                    tbEndDate.SelectedDate = leaveRequest.EndDate;
                    TbComment.Value = leaveRequest.Comment;
                }
            }
            else
            {
                btSubmit.Visible = true;
                btSubmit.ServerClick += BtSubmit_ServerClick;

            }
            //LoadFileUpload();


        }

        private void BtAccept_ServerClick(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlInputButton buttonClicked =
                (System.Web.UI.HtmlControls.HtmlInputButton)sender;

            string response = "";
            if (buttonClicked.Value == "Accept")
            {
                response = "Validated";
            }
            else if (buttonClicked.Value == "Reject")
            {
                response = "Rejected";
            }
            LeaveRequestEntity leaveRequest = new LeaveRequestEntity();
            int id = int.Parse(Request.QueryString["ItemId"]);
            leaveRequest.Load(id);

            leaveRequest.Status = response;

            leaveRequest.SaveItem(id);

            divResult.InnerText = "Your response has been submitted";
        }

        private void LoadFileUpload()
        {
            if (Session["FileUpload"] == null && FileUpload.HasFile)
            {
                Session["FileUpload"] = FileUpload;
                //Label1.Text = FileUpload1.FileName;
            }
            // Next time submit and Session has values but FileUpload is Blank
            // Return the values from session to FileUpload
            else if (Session["FileUpload1"] != null && (!FileUpload.HasFile))
            {
                FileUpload = (FileUpload)Session["FileUpload1"];
                //Label1.Text = FileUpload1.FileName;
            }
            // Now there could be another sictution when Session has File but user want to change the file
            // In this case we have to change the file in session object
            else if (FileUpload.HasFile)
            {
                Session["FileUpload1"] = FileUpload;
                //Label1.Text = FileUpload1.FileName;
            }
        }

        private void BtSubmit_ServerClick(object sender, EventArgs e)
        {
            if (!FileUpload.HasFile)
            {
                divResult.InnerText = "No file uploaded";
                return;
            }
            LeaveRequestEntity leaveRequest = new LeaveRequestEntity();
            leaveRequest.StartDate = tbStartDate.SelectedDate;
            leaveRequest.EndDate = tbEndDate.SelectedDate;
            leaveRequest.Comment = TbComment.Value;
            leaveRequest.Status = "Submitted";
            
            leaveRequest.FileName = FileUpload.FileName;
            leaveRequest.FileBytes = FileUpload.FileBytes;
            leaveRequest.SaveItem();

            divResult.InnerText = "Your request has been submitted";
            
        }
    }
}
