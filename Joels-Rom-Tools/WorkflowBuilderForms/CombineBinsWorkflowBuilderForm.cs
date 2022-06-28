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
    public partial class CombineBinsWorkflowBuilderForm : Form, IWorkflowBuilder<Workflows.CombineBinsWorkflow>
    {
        public CombineBinsWorkflowBuilderForm()
        {
            InitializeComponent();
        }

        public CombineBinsWorkflow? Result => new CombineBinsWorkflow("","","");
    }
}
