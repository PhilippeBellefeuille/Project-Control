using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;

namespace PX.Objects.PC
{
    public class PCAssignableTimeAttribute : PXEventSubscriberAttribute, IPXRowSelectedSubscriber
    {
        public Type DayAssignableType;

        public PCAssignableTimeAttribute(Type dayAssignableType)
        {
            DayAssignableType = dayAssignableType;
        }

        public override void CacheAttached(PXCache sender)
        {
            base.CacheAttached(sender);

            sender.Graph.FieldUpdated.AddHandler(sender.GetItemType(), DayAssignableType.Name, DayAssignableFieldUpdated);
        }
        public void RowSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            if (e.Row == null)
                return;

            var isAssignableDay = (bool?)sender.GetValue(e.Row, DayAssignableType.Name) == true;
            PXUIFieldAttribute.SetEnabled(sender, e.Row, this.FieldName, isAssignableDay);
            PXDefaultAttribute.SetPersistingCheck(sender, this.FieldName, e.Row, isAssignableDay 
                                                                                    ? PXPersistingCheck.NullOrBlank 
                                                                                    : PXPersistingCheck.Nothing);
        }

        public void DayAssignableFieldUpdated(PXCache sender, PXFieldUpdatedEventArgs e)
        {
            if((bool?)sender.GetValue(e.Row, DayAssignableType.Name) != true)
            {
                sender.SetValue(e.Row, this.FieldOrdinal, null);
            }
        }
    }
}
