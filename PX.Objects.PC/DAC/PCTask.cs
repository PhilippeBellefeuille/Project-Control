using PX.Data;
using PX.Objects.CS;
using PX.Objects.EP;
using System;

namespace PX.Objects.PC
{
    public class PCTask : IBqlTable
    {
        #region TaskType
        public abstract class taskType : PX.Data.IBqlField { }

        [PXDBString(2, IsKey = true, IsFixed = true, InputMask = ">aa")]
        [PXDefault]
        [PXSelector(typeof(PCTaskType.taskType))]
        [PXRestrictor(typeof(Where<PCTaskType.active, Equal<True>>), null)]
        [PXUIField(DisplayName = "Task Type", Visibility = PXUIVisibility.SelectorVisible)]
        [PX.Data.EP.PXFieldDescription]
        public virtual String TaskType { get; set; }
        #endregion

        #region TaskNbr
        public abstract class taskNbr : PX.Data.IBqlField { }

        [PXDBString(15, IsKey = true, IsUnicode = true, InputMask = ">CCCCCCCCCCCCCCC")]
        [PXDefault()]
        [PXUIField(DisplayName = "Task Nbr.", Visibility = PXUIVisibility.SelectorVisible)]
        [AutoNumber(typeof(Search<PCTaskType.numberingID,
                            Where<PCTaskType.taskType,
                                Equal<Current<PCTask.taskType>>,
                            And<PCTaskType.active, Equal<True>>>>),
                    typeof(AccessInfo.businessDate))]
        [PXSelector(typeof(Search<PCTask.taskNbr,
                            Where<PCTask.taskType,
                                Equal<Optional<PCTask.taskType>>>>))]
        [PX.Data.EP.PXFieldDescription]
        public virtual String TaskNbr { get; set; }
        #endregion

        #region Status
        public abstract class status : IBqlField { }

        [PXDBString(1, IsFixed = true)]
        [PXDefault(PCTaskStatus.Hold)]
        [PXUIField(DisplayName = "Status", Visibility = PXUIVisibility.SelectorVisible, Enabled = false)]
        [PCTaskStatus.List]
        public virtual string Status { get; set; }
        #endregion

        #region DocDesc
        public abstract class description : IBqlField { }

        [PXDBString(60, IsUnicode = true)]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual String Description { get; set; }
        #endregion

        #region StartDate
        public abstract class startDate : IBqlField { }

        [PXDBDate]
        [PXUIField(DisplayName = "Start Date")]
        public virtual DateTime? StartDate { get; set; }
        #endregion

        #region EndDate
        public abstract class endDate : IBqlField { }

        [PXDBDate]
        [PXUIField(DisplayName = "End Date")]
        public virtual DateTime? EndDate { get; set; }
        #endregion

        #region Duration
        public abstract class duration : PX.Data.IBqlField { }

        [PXDBInt]
        [PXUIField(DisplayName = "Duration")]
        public virtual int? Duration { get; set; }
        #endregion

        #region Estimate
        public abstract class estimate : PX.Data.IBqlField { }

        [PXDBInt]
        [PXUIField(DisplayName = "Estimate")]
        public virtual int? Estimate { get; set; }
        #endregion
        
        #region EstimatorID
        public abstract class estimatorID : PX.Data.IBqlField { }

        [PXDBInt]
        [PXUIField(DisplayName = "Estimator")]
        [PXEPEmployeeSelector]
        public virtual int? EstimatorID { get; set; }
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
