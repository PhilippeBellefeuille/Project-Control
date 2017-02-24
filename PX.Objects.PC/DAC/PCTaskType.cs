using PX.Data;
using PX.Objects.CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    [Serializable]
    public class PCTaskType : IBqlTable
    {
        #region TaskType
        public class taskType : IBqlField { }

        [PXDBString(2, IsKey = true, IsFixed = true, InputMask = ">aa")]
        [PXUIField(DisplayName = "Task Type", Visibility = PXUIVisibility.SelectorVisible)]
        [PXDefault]
        [PXSelector(typeof(PCTaskType.taskType))]
        public string TaskType { get; set; }
        #endregion

        #region Active
        public class active : IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Active")]
        public bool? Active { get; set; }
        #endregion

        #region Description
        public class description : IBqlField { }

        [PXDBLocalizableString(60, IsUnicode = true)]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public string Description { get; set; }
        #endregion

        #region NumberingID
        public class numberingID : IBqlField { }

        [PXDBString(10, IsUnicode = true)]
        [PXDefault()]
        [PXSelector(typeof(Search<Numbering.numberingID>))]
        [PXUIField(DisplayName = "Numbering Sequence")]
        public string NumberingID { get; set; }
        #endregion

        #region IsBillable
        public class isBillable : IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Is Billable")]
        public bool? IsBillable { get; set; }
        #endregion

        #region RequiresEstimate
        public class requiresEstimate : IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Requires Estimate")]
        public bool? RequiresEstimate { get; set; }
        #endregion

        #region System Fields

        #region Tstamp
        public class tstamp : IBqlField { }

        [PXDBTimestamp]
        public byte[] Tstamp { get; set; }
        #endregion

        #region CreatedByID
        public class createdByID : IBqlField { }

        [PXDBCreatedByID]
        public Guid? CreatedByID { get; set; }
        #endregion

        #region CreatedByScreenID
        public class createdByScreenID : IBqlField { }

        [PXDBCreatedByScreenID]
        public string CreatedByScreenID { get; set; }
        #endregion

        #region CreatedDateTime
        public class createdDateTime : IBqlField { }

        [PXDBCreatedDateTime]
        public DateTime? CreatedDateTime { get; set; }
        #endregion

        #region LastModifiedByID
        public class lastModifiedByID : IBqlField { }

        [PXDBLastModifiedByID]
        public Guid? LastModifiedByID { get; set; }
        #endregion

        #region LastModifiedByScreenID
        public class lastModifiedByScreenID : IBqlField { }

        [PXDBLastModifiedByScreenID]
        public string LastModifiedByScreenID { get; set; }
        #endregion

        #region LastModifiedDateTime
        public class lastModifiedDateTime : IBqlField { }

        [PXDBLastModifiedDateTime]
        public DateTime? LastModifiedDateTime { get; set; }
        #endregion

        #endregion
    }
}
