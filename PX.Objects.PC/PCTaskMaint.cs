using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    public class PCTaskMaint : PXGraph<PCTaskMaint, PCTask>
    {
        public PXSelect<PCTask, 
                Where<PCTask.taskType, 
                    Equal<Current<PCTask.taskType>>>> Document;

        public PXSelect<PCTask,
                    Where<PCTask.taskType,
                        Equal<Current<PCTask.taskType>>,
                    And<PCTask.taskNbr,
                        Equal<Current<PCTask.taskNbr>>>>> CurrentDocument;
    }
}
