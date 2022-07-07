using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.WorkflowBuilderForms.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class WorkflowBuilderInfoAttribute : System.Attribute
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public WorkflowBuilderInfoAttribute(string name, string description) {
            Name = name;
            Description = description;
        }
    }
}
