using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    public class PCTaskTypeResource : IBqlTable
    {
        #region TaskType
        public class taskType : IBqlField { }

        [PXDBString(2, IsKey = true, IsFixed = true, InputMask = ">aa")]
        [PXUIField(DisplayName = "Task Type", Visibility = PXUIVisibility.SelectorVisible)]
        [PXDBDefault(typeof(PCTaskType.taskType))]
        [PXParent(typeof(Select<PCTaskType, 
                            Where<PCTaskType.taskType, 
                                Equal<PCTaskTypeResource.taskType>>>))]
        public string TaskType { get; set; }
        #endregion

        #region BAccountID
        public class bAccountID : IBqlField { }

        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Resource ID")]
        [PXSelector(typeof(PCResource.bAccountID), SubstituteKey = typeof(PCResource.acctCD), DescriptionField = typeof(PCResource.acctName))]
        public int? BAccountID { get; set; }
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
