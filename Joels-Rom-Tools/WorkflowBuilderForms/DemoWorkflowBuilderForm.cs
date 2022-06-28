using Joels_Rom_Tools.Workflows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joels_Rom_Tools.WorkflowBuilderForms
{
    public partial class DemoWorkflowBuilderForm : Form, IWorkflowBuilder<Workflows.DemoWorkflow>
    {
        public DemoWorkflowBuilderForm()
        {
            InitializeComponent();
        }

        public DemoWorkflow? Result => new DemoWorkflow(this.txtExample1.Text);
    }
}
