using Microsoft.SharePoint;
using System;
using System.ComponentModel;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using TestSharePoint.LeaveRequest.Providers.Helpers;
using TestSharePoint.LeaveRequest.Providers.Entitites;

namespace TestSharePoint.LeaveRequest.Components.LeaveRequestTaskList
{
    [ToolboxItemAttribute(false)]
    public partial class LeaveRequestTaskList : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public LeaveRequestTaskList()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Page.Request.QueryString["test"]))
            {
                divTest.Visible = true;
            }
            
            gvtasks.DataSource = ListTasks();
            gvtasks.DataBind();
        }

        DataTable ListTasks()
        {
            DataTable dtTasks = new DataTable();
            DataColumn colUser = new DataColumn("CreatedBy");
            DataColumn colstartDate = new DataColumn("StartDate");
            DataColumn colendDate = new DataColumn("EndDate");
            DataColumn colComment = new DataColumn("Comment");
            DataColumn colLink = new DataColumn("Link");

            dtTasks.Columns.Add(colUser);
            dtTasks.Columns.Add(colstartDate);
            dtTasks.Columns.Add(colendDate);
            dtTasks.Columns.Add(colComment);
            dtTasks.Columns.Add(colLink);           

            SPHelper spHelper = new SPHelper();

            SPList list = spHelper.GetList();
            SPQuery query = new SPQuery();
            query.Query = @"<Where><Eq><FieldRef Name=""Status""></FieldRef><Value Type=""Text"">Submitted</Value></Eq></Where>";

           foreach(SPListItem item in  list.GetItems(query))
            {
                LeaveRequestEntity leaveRequest = new LeaveRequestEntity(item);
                DataRow row = dtTasks.NewRow();

                row["CreatedBy"] = item.Properties["Author"];
                row["StartDate"]=leaveRequest.StartDate;            
                row["EndDate"] = leaveRequest.EndDate;
                row["Comment"] = leaveRequest.Comment;
                row["Link"] = "http://k2/sites/test/SitePages/New%20leave%20request.aspx?State=Validation&itemid=" + item.ID;

                dtTasks.Rows.Add(row);
            }
                    
            return dtTasks;
        }

        protected void BtTestQuery_Click(object sender, EventArgs e)
        {
            try {
                SPHelper spHelper = new SPHelper();

                SPList list = spHelper.GetList();
                SPQuery query = new SPQuery();
                query.Query = testAreaTest.Value;
                
                SPListItemCollection coll =  list.GetItems(query);
                divQueryResult.InnerText = coll.Count.ToString();
            }
            catch(Exception ex)
            {
                divQueryResult.InnerText = ex.Message;
            }
        }
    }
}
