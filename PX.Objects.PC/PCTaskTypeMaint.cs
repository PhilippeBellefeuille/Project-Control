using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.Objects.PC
{
    public class PCTaskTypeMaint : PXGraph<PCTaskTypeMaint, PCTaskType>
    {
        public PXSelect<PCTaskType> Document;

        public PXSelect<PCTaskType,
                    Where<PCTaskType.taskType,
                        Equal<Current<PCTaskType.taskType>>>> CurrentDocument;

        public PXSelect<PCTaskTypeResource, 
                    Where<PCTaskTypeResource.taskType, 
                        Equal<Current<PCTaskType.taskType>>>> Resources;
    }
}
