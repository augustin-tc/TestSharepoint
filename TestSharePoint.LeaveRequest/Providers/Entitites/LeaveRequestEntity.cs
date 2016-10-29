using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace TestSharePoint.LeaveRequest.Providers.Entitites
{
   public  class LeaveRequestEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public String Comment { get; set; }
        public string Status { get; set; }
        
        public LeaveRequestEntity()
        {

        }

        public LeaveRequestEntity Load(int id)
        {
            SPList list = GetList();

            SPListItem item = list.Items.GetItemById(id);

            return new LeaveRequestEntity()
            {
                StartDate = DateTime.Parse(item["StartDate"].ToString()),
                EndDate = DateTime.Parse(item["EndDate"].ToString()),
                Comment = item["Comment"].ToString(),
                Status = item["Status"].ToString()
            };

        }

        public void SaveItem(int id = 0)
        {
            SPList list = GetList();
            SPListItem item;
            if (id > 0)
                item = list.Items.GetItemById(id);
            else
                item = list.Items.Add();

            item["StartDate"] = StartDate;
            item["EndDate"] = EndDate;
            item["Comment"] = Comment;
            item["Status"] = Status;

            item.Update();

        }

      
        SPList GetList()
        {
            SPWeb web = SPContext.Current.Web;
            SPList list = web.Lists["LeaveRequests"];
            return list;
        }

        
    }
}
