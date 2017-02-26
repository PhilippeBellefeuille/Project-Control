using PX.Data;
using PX.Objects.EP;
using System.Collections;

namespace PX.Objects.PC
{
    public class EmployeeExtendFilter : IBqlTable
    {
        #region BAccountID
        public class bAccountID : IBqlField { }

        [PXInt]
        [PXUIField(DisplayName = "Employee ID")]
        [PXDimensionSelector("EMPLOYEE",
                typeof(Search2<CR.Standalone.EPEmployee.bAccountID, 
                            LeftJoin<PCResource, On<CR.Standalone.EPEmployee.bAccountID, 
                                Equal<PCResource.bAccountID>>>, 
                            Where<PCResource.bAccountID, IsNull>>), 
                typeof(CR.Standalone.EPEmployee.acctCD),
                typeof(CR.Standalone.EPEmployee.bAccountID),
                typeof(CR.Standalone.EPEmployee.acctCD),
                typeof(CR.Standalone.EPEmployee.acctName),
                typeof(CR.Standalone.EPEmployee.departmentID))]
        public virtual int? BAccountID { get; set; }
        #endregion
    }

    public class PCEmployeeResourceExtender : PXGraph<PCEmployeeResourceExtender>
    {
        public PXSelect<EPEmployee,
                    Where<EPEmployee.bAccountID,
                        Equal<Required<EPEmployee.bAccountID>>>> Employee;
    }

    public class PCResourceMaint : PXGraph<PCResourceMaint, PCResource>
    {
        public PXSelect<PCResource> Document;

        public PXSelect<PCResource,
                    Where<PCResource.bAccountID,
                        Equal<Current<PCResource.bAccountID>>>> CurrentDocument;

        public PXFilter<EmployeeExtendFilter> EmployeeExtend;
        
        [PXUIField(DisplayName = ActionsMessages.Insert, MapEnableRights = PXCacheRights.Insert, MapViewRights = PXCacheRights.Insert)]
        [PXInsertButton]
        protected virtual IEnumerable insert(PXAdapter adapter)
        {
            if (EmployeeExtend.View.Answer == WebDialogResult.None)
            {
                EmployeeExtend.Cache.Clear();
            }
            if (EmployeeExtend.AskExt() == WebDialogResult.OK)
            {
                var employeeResourceGraph = PXGraph.CreateInstance<PCEmployeeResourceExtender>();
                var employee = (EPEmployee)employeeResourceGraph.Employee.Select(EmployeeExtend.Current.BAccountID);
                if (employee != null)
                {
                    var returnGraph = PXGraph.CreateInstance<PCResourceMaint>();
                    var resource = returnGraph.Document.Extend(employee);
                    returnGraph.Document.Current = resource;

                    throw new PXRedirectRequiredException(returnGraph, string.Empty);
                }
            }
            return adapter.Get();
        }

        public virtual void PCResource_RowSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            var row = (PCResource)e.Row;
            if (row == null)
                return;

            this.Document.AllowUpdate =
            this.CurrentDocument.AllowUpdate = sender.GetStatus(row) != PXEntryStatus.Inserted;
        }
    }
}