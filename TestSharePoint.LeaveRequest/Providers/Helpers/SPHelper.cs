using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSharePoint.LeaveRequest.Providers.Helpers
{
    public class SPHelper
    {
        public SPList GetList()
        {
            SPWeb web = SPContext.Current.Web;
            SPList list = web.Lists["LeaveRequests"];
            return list;
        }
    }
}
