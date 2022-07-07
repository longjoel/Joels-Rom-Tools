using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.Workflows
{
    /// <summary>
    /// This is a demonstration of the workflow.
    /// </summary>
    public class DemoWorkflow : IWorkflow
    {
        private string _exampleParam1;
        public DemoWorkflow(string exampleParam1) {
            _exampleParam1 = exampleParam1;
        }
        public Task StartAsync(Action<WorkflowProgressUpdate> onProgressUpdate, Action onWorkflowComplete, Action<string, Exception?> onError)
        {
            throw new NotImplementedException();
        }
    }
}
