namespace Joels_Rom_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var formBuilder = new WorkflowBuilderForms.CombineBinsWorkflowBuilderForm();
            formBuilder.ShowDialog();
            var workFlow = formBuilder.Result;

            if (workFlow != null) {
                Task.Factory.StartNew(async () => {
                    await workFlow.StartAsync((x) => {
                        Invoke(() => { LogTextBox.Text += $"{x.Progress} || {x.Message} {Environment.NewLine}"; });
                    }, () => {
                        MessageBox.Show("Done!");
                    });
                });
            }
        }
    }
}