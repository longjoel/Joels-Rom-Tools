using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.Workflows
{
    public class WorkflowProgressUpdate { 
        public string Message { get; set; }
        public int Progress { get; set; }

        public WorkflowProgressUpdate(string message, int progress)
        {
            Message = message;
            Progress = progress;
        }   
    }
    public interface IWorkflow
    {
        Task StartAsync(
            Action<WorkflowProgressUpdate> onProgressUpdate,
            Action onWorkflowComplete,
            Action<string, Exception> onWorkflowFailed);


        
    }
}
