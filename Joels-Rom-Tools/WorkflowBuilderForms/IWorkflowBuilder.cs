using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.WorkflowBuilderForms
{
    internal interface IWorkflowBuilder<T> where T : Workflows.IWorkflow
    {
        public T? Result { get; }
    }
}
