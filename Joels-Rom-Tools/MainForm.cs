using Joels_Rom_Tools.WorkflowBuilderForms;
using Joels_Rom_Tools.WorkflowBuilderForms.Attributes;
using Joels_Rom_Tools.Workflows;
using System.Reflection;
namespace Joels_Rom_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Button MakeWorkflowButton(string name, string description, Action onClick) {
            var btn = new Button();
            btn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn.Text = $"{name}: {description}";
            btn.Click += (o,e)=>onClick();

            return btn;
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            var asm = Assembly.GetAssembly(typeof(MainForm));
            if (asm != null)
            {
                var asmTypes = asm.GetExportedTypes();
                var workflows = new List<Type> { };
                foreach (var t in asmTypes) {
                    if (t.GetInterfaces().Any(x => x.Name.StartsWith("IWorkflowBuilder"))) {
                        workflows.Add(t);
                    }
                }

                if (workflows != null)
                {
                    foreach (var w in workflows)
                    {
                        if (w != null)
                        {
                            var attr = w.GetCustomAttribute(typeof(WorkflowBuilderInfoAttribute)) as WorkflowBuilderInfoAttribute;
                            if (attr != null)
                            {
                                LogTextBox.Text += $"{attr.Name}: {attr.Description} {Environment.NewLine}";
                                WorkflowsContainer.Controls.Add(MakeWorkflowButton(attr.Name, attr.Description, () => {

                                    var instance = Activator.CreateInstance(w) as dynamic;
                                    if (instance != null) {
                                        instance.ShowDialog();
                                        var workflow = instance.Result as IWorkflow;
                                        if (workflow != null) {
                                            Task.Factory.StartNew(async () =>
                                            {

                                                await workflow.StartAsync((WorkflowProgressUpdate x) =>
                                                {
                                                    Invoke(() => { LogTextBox.Text += $"{x.Progress} || {x.Message} {Environment.NewLine}"; });
                                                }, () =>
                                                {
                                                    MessageBox.Show("Done!");
                                                },
                                                (m, ex) => {
                                                    Invoke(() => { LogTextBox.Text += $"{m} || {ex.Message} {Environment.NewLine}"; });

                                                });
                                                
                                                
                                            });
                                        }
                                    }
                                }));
                            }
                            else
                            {
                                LogTextBox.Text += $"{w.Name} {Environment.NewLine}";
                            }
                        }
                    }
                }
            }

        }
    }
}