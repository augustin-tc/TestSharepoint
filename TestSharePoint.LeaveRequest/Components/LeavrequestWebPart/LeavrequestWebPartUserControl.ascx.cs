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
            if (!string.IsNullOrEmpty(Request.QueryString["State"]))
            {
                if (Request.QueryString["State"] == "Validation")
                {
                    btAccept.Visible = true;
                    btReject.Visible = true;

                    int id = int.Parse(Request.QueryString["ItemId"]);

                    LeaveRequestEntity leaveRequest = new LeaveRequestEntity();
                    leaveRequest.Load(id);

                    tbStartDate.Value = leaveRequest.StartDate.ToString();
                    tbEndDate.Value = leaveRequest.EndDate.ToString();
                    TbComment.Value = leaveRequest.Comment;
                }
            }
            else
            {
                btSubmit.Visible = true;
                btSubmit.ServerClick += BtSubmit_ServerClick;
            }
        }

        private void BtSubmit_ServerClick(object sender, EventArgs e)
        {
            LeaveRequestEntity leaveRequest = new LeaveRequestEntity();
            leaveRequest.StartDate = DateTime.Parse(tbStartDate.Value);
            leaveRequest.EndDate = DateTime.Parse(tbEndDate.Value);
            leaveRequest.Comment = TbComment.Value;
            leaveRequest.Status = "Submitted";

            //lea
        }
    }
}
