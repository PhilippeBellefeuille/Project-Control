using PX.Data;
using PX.Data.EP;
using PX.Objects.EP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    [Serializable]
    [PXTable(typeof(CR.BAccount.bAccountID))]
    public class PCResource : EPEmployee
    {
        #region BAccountID
        public new class bAccountID : IBqlField { }
        #endregion

        #region AcctCD
        public abstract new class acctCD : IBqlField { }

        [PXSelector(typeof(PCResourceR.acctCD), ValidateValue = true)]
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Resource ID", Visibility = PXUIVisibility.SelectorVisible)]
        [PXFieldDescription]
        public override String AcctCD { get; set; }
        #endregion


        #region ExpertiseLevel
        public class expertiseLevel : IBqlField { }

        [PXDBInt()]
        [PXDefault(3)]
        [PXIntList("1;Beginner,2;Ramping-up,3;Fluent,4;Advanced,5;Expert")]
        [PXUIField(DisplayName = "Expertise Level")]
        public int? ExpertiseLevel { get; set; }

        #endregion

        #region Assignment Calendar

        #region SunAssignableDay
        public abstract class sunAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(false)]
        [PXUIField(DisplayName = "Sunday")]
        public virtual Boolean? SunAssignableDay { get; set; }
        #endregion

        #region SunAssignableTime
        public abstract class sunAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(sunAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? SunAssignableTime { get; set; }
        #endregion

        #region MonAssignableDay
        public abstract class monAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Monday")]
        public virtual Boolean? MonAssignableDay { get; set; }
        #endregion

        #region MonAssignableTime
        public abstract class monAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(monAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? MonAssignableTime { get; set; }
        #endregion

        #region TueAssignableDay
        public abstract class tueAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Tuesday")]
        public virtual Boolean? TueAssignableDay { get; set; }
        #endregion

        #region TueAssignableTime
        public abstract class tueAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(tueAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? TueAssignableTime { get; set; }
        #endregion

        #region WedAssignableDay
        public abstract class wedAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Wednesday")]
        public virtual Boolean? WedAssignableDay { get; set; }
        #endregion

        #region WedAssignableTime
        public abstract class wedAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(wedAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? WedAssignableTime { get; set; }
        #endregion

        #region ThuAssignableDay
        public abstract class thuAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Thursday")]
        public virtual Boolean? ThuAssignableDay { get; set; }
        #endregion

        #region ThuAssignableTime
        public abstract class thuAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(thuAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? ThuAssignableTime { get; set; }
        #endregion

        #region FriAssignableDay
        public abstract class friAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Friday")]
        public virtual Boolean? FriAssignableDay { get; set; }
        #endregion

        #region FriAssignableTime
        public abstract class friAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(friAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? FriAssignableTime { get; set; }
        #endregion

        #region SatAssignableDay
        public abstract class satAssignableDay : PX.Data.IBqlField { }

        [PXDBBool()]
        [PXDefault(false)]
        [PXUIField(DisplayName = "Saturday")]
        public virtual Boolean? SatAssignableDay { get; set; }
        #endregion

        #region SatAssignableTime
        public abstract class satAssignableTime : PX.Data.IBqlField { }

        [PXDBInt]
        [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PCAssignableTime(typeof(satAssignableDay))]
        [PXUIField(DisplayName = "Assignable Time")]
        public virtual int? SatAssignableTime { get; set; }
        #endregion

        #endregion
    }

    public class PCResourceR : PCResource
    {
        public abstract new class acctCD : IBqlField { }
    }
}
