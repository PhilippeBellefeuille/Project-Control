using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.Common;

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

    public class PCTaskStatus : ILabelProvider
    {
        private static readonly IEnumerable<ValueLabelPair> _valueLabelPairs = new ValueLabelList
        {
            { Hold, Messages.Hold },
            { Open, Messages.Open },
            { PendingAssignation, Messages.PendingAssignation },
            { InProgress, Messages.InProgress },
            { Completed, Messages.Completed },
        };

        public static readonly string[] Values =
        {
            Hold,
            Open,
            PendingAssignation,
            InProgress,
            Completed
        };

        public static readonly string[] Labels =
        {

            Messages.Hold,
            Messages.Open,
            Messages.PendingAssignation,
            Messages.InProgress,
            Messages.Completed
        };

        public IEnumerable<ValueLabelPair> ValueLabelPairs => _valueLabelPairs;

        public class ListAttribute : LabelListAttribute
        {
            public ListAttribute() : base(_valueLabelPairs)
            { }
        }

        public const string Hold = "H";
        public const string Open = "N";
        public const string PendingAssignation = "A";
        public const string InProgress = "P";
        public const string Completed = "C";

        public class hold : Constant<string>
        {
            public hold() : base(Hold) {; }
        }
        public class open : Constant<string>
        {
            public open() : base(Open) {; }
        }

        public class pendingAssignation : Constant<string>
        {
            public pendingAssignation() : base(PendingAssignation) {; }
        }

        public class inProgress : Constant<string>
        {
            public inProgress() : base(InProgress) {; }
        }

        public class completed : Constant<string>
        {
            public completed() : base(Completed) {; }
        }


    }
}
