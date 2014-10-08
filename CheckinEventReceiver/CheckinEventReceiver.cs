using Microsoft.SharePoint;
using PonyCheckinEventReceiver.Communication;

namespace PonyCheckinEventReceiver.CheckinEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class CheckinEventReceiver : SPItemEventReceiver
    {
       /// <summary>
       /// An item is being checked in.
       /// </summary>
       public override void ItemCheckingIn(SPItemEventProperties properties)
       {
           base.ItemCheckingIn(properties);
           ItemSynchronization.SendData(properties.AfterUrl);
       }
    }
}
