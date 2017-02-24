using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    public class PCResource : IBqlTable
    {
        #region BAccountID
        public class bAccountID : IBqlField { }

        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Resource ID")]
        [PXSelector(typeof(PCResource.bAccountID))]
        public int? BAccountID { get; set; }
        #endregion

        #region MondayTimeAvailable
        public class mondayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Monday Time Available")]
        public int? MondayTimeAvailable { get; set; }
        #endregion
        
        #region TuesdayTimeAvailable
        public class tuesdayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Tuesday Time Available")]
        public int? TuesdayTimeAvailable { get; set; }
        #endregion

        #region WednesdayTimeAvailable
        public class wednesdayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Wednesday Time Available")]
        public int? WednesdayTimeAvailable { get; set; }
        #endregion

        #region ThursdayTimeAvailable
        public class thursdayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Thursday Time Available")]
        public int? ThursdayTimeAvailable { get; set; }
        #endregion
        
        #region FridayTimeAvailable
        public class fridayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Friday Time Available")]
        public int? FridayTimeAvailable { get; set; }
        #endregion

        #region SaturdayTimeAvailable
        public class saturdayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Saturday Time Available")]
        public int? SaturdayTimeAvailable { get; set; }
        #endregion
        
        #region SundayTimeAvailable
        public class sundayTimeAvailable : IBqlField { }

        [PXDBInt()]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Sunday Time Available")]
        public int? SundayTimeAvailable { get; set; }
        #endregion
        
        #region ExpertiseLevel
        public class expertiseLevel : IBqlField { }

        [PXDBInt()]
        [PXDefault(3)]
        [PXIntList("1;Beginner,2;Ramping-up,3;Fluent,4;Advanced,5;Expert")]
        [PXUIField(DisplayName = "Expertise Level")]
        public int? ExpertiseLevel { get; set; }

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
