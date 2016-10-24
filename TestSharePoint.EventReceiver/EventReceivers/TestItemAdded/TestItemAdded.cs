using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using TestSharePoint.EventReceiver.Utilities;

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
            Logger.Log("item added and modified : " + properties.ListItemId);
            base.ItemAdded(properties);
        }


    }
}