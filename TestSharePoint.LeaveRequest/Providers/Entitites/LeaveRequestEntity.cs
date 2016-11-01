using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using TestSharePoint.LeaveRequest.Providers.Helpers;

namespace TestSharePoint.LeaveRequest.Providers.Entitites
{
   public  class LeaveRequestEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public string Comment { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
        public byte[] FileBytes { get; set; }
        
        public LeaveRequestEntity(SPListItem item =null)
        {
            if (item != null)
            {
                StartDate = DateTime.Parse(item["StartDate"].ToString());
                EndDate = DateTime.Parse(item["EndDate"].ToString());
                if (item["Comment"] != null)
                    Comment = item["Comment"].ToString();
                Status = item["Status"].ToString();
            }
        }

        public void Load(int id)
        {
            SPHelper spHelper = new SPHelper();
            SPList list = spHelper.GetList();

            SPListItem item = list.Items.GetItemById(id);
            
            StartDate = DateTime.Parse(item["StartDate"].ToString());
            EndDate = DateTime.Parse(item["EndDate"].ToString());
            if (item["Comment"] != null)
                Comment = item["Comment"].ToString();
            Status = item["Status"].ToString();

        }

        public void SaveItem(int id = 0)
        {
            SPHelper spHelper = new SPHelper();
            SPList list = spHelper.GetList();
            SPFile fItem = null;
            SPListItem lItem = null;
            if (id > 0)
            {
                lItem = list.GetItemById(id);
            }
            else
            {
                fItem = list.RootFolder.Files.Add(list.RootFolder.Url + "/" + FileName, FileBytes);
                fItem.Update();
                lItem = list.GetItemByUniqueId(fItem.UniqueId);
            }


            lItem["StartDate"] = StartDate;
            lItem["EndDate"] = EndDate;
            lItem["Comment"] = Comment;
            lItem["Status"] = Status;

            lItem.Update();

        }

      
      

        
    }
}
