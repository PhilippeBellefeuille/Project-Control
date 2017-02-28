using PX.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    [PXLocalizable(Messages.Prefix)]
    public static class Messages
    {
        #region Validation and Processing Messages
        public const string Prefix = "PC Error";
        #endregion

        #region Task Status
        public const string PendingAssignation = "Pending Assignation";
        public const string Hold = "Hold";
        public const string Open = "Open";
        public const string InProgress = "In Progress";
        public const string Completed = "Completed";
        #endregion
    }
}
