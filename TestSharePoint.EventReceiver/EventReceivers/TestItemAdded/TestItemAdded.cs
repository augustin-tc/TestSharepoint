using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using TestSharePoint.EventReceiver.Utilities;
using Microsoft.SharePoint.Administration;

namespace TestSharePoint.EventReceiver.EventReceivers.TestItemAdded
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class TestItemAdded : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {

            properties.ListItem["Eventreceivercoment"] = "Event receiver trigerred at " + DateTime.Now.ToString("dd MM yyyy hh:mm:ss");
            properties.ListItem.Update();

           //new SPDiagnosticsCategory("SharePointAMS.Commerce", TraceSeverity.High, EventSeverity.Error) creation of a custom uls

            SPDiagnosticsService diagSvc = SPDiagnosticsService.Local;
            diagSvc.WriteTrace(0, // custom trace id

                 new SPDiagnosticsCategory("TestSharePoint", TraceSeverity.High, EventSeverity.Information), // create a category
                                TraceSeverity.High, // set the logging level of this record
                                "Item created = " + properties.ListItemId, // custom message
                                "" // parameters to message
                                );

            base.ItemAdded(properties);
        }


    }
}