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
   
    [Attributes.WorkflowBuilderInfo("Combine Bins", "Combine multiple binaries into a single bin with multi-trac cue file.")]
    public partial class CombineBinsWorkflowBuilderForm : Form, IWorkflowBuilder<Workflows.CombineBinsWorkflow>
    {
        public CombineBinsWorkflowBuilderForm()
        {
            InitializeComponent();
        }

        public CombineBinsWorkflow? Result { get; set; } = null;


        private void SelectBinsButton_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".bin",
                Multiselect = true,
                Filter = "Binary Files (*.bin)|*.bin",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            var result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {

                if (fd.FileNames.Length > 0)
                {
                    var folderName = Path.GetDirectoryName(fd.FileNames.First());
                    if (folderName != null && folderName.Length > 0)
                    {
                        SelectedBinsListBox.Items.Clear();
                        foreach (var f in fd.FileNames)
                        {
                            SelectedBinsListBox.Items.Add(new { Text = Path.GetFileName(f), Value = f });
                        }


                        var last = folderName.Split(Path.DirectorySeparatorChar).Last();

                        CueLocationTxt.Text = Path.Join(folderName, last + ".cue");
                        BinLocationTxt.Text = Path.Join(folderName, last + ".bin");
                    }

                }
            }
        }


        private void MoveSelectedUpButton_Click(object sender, EventArgs e)
        {
            SelectedBinsListBox.MoveSelectedItemUp();
        }

        private void MoveSelectedDownButton_Click(object sender, EventArgs e)
        {
            SelectedBinsListBox.MoveSelectedItemDown();
        }

        private void CancelTaskButton_Click(object sender, EventArgs e)
        {
            Result = null;
            Close();
        }

        private void RunTaskButton_Click(object sender, EventArgs e)
        {
            var bins = new List<string>();
            foreach (var item in SelectedBinsListBox.Items) {
                bins.Add(((dynamic)item).Value);
            }
            Result = new CombineBinsWorkflow(bins, CueLocationTxt.Text, BinLocationTxt.Text, RemoveOriginalBinsCheckbox.Checked);
            Close();
        }

        private void PickCueFileButton_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".cue",
                Multiselect = true,
                Filter = "Cue File (*.cue)|*.cue",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            var result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {

                if (fd.FileName != null && fd.FileName.Length > 0)
                {
                    var folderName = Path.GetDirectoryName(fd.FileNames.First());
                    if (folderName != null && folderName.Length > 0)
                    {
                        SelectedBinsListBox.Items.Clear();

                      

                        var cueFile = new FileFormats.CueFile(File.ReadAllText(fd.FileName));

                        foreach (var f in cueFile.Fields)
                        {
                            SelectedBinsListBox.Items.Add(new { Text = f.FileName, 
                                Value = Path.Join(folderName,f.FileName) });
                        }


                        var last = folderName.Split(Path.DirectorySeparatorChar).Last();

                        CueLocationTxt.Text = Path.Join(folderName, last + ".cue");
                        BinLocationTxt.Text = Path.Join(folderName, last + ".bin");
                    }

                }
            }
        }

        private void SelectedBinsListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e != null && e.Data != null)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);


                if (files.Length > 0)
                {
                    var folderName = Path.GetDirectoryName(files.First());
                    if (folderName != null && folderName.Length > 0)
                    {
                        SelectedBinsListBox.Items.Clear();
                        foreach (var f in files)
                        {
                            SelectedBinsListBox.Items.Add(new { Text = Path.GetFileName(f), Value = f });
                        }


                        var last = folderName.Split(Path.DirectorySeparatorChar).Last();

                        CueLocationTxt.Text = Path.Join(folderName, last + ".cue");
                        BinLocationTxt.Text = Path.Join(folderName, last + ".bin");
                    }

                }
            }
        }

        private void SelectedBinsListBox_DragOver(object sender, DragEventArgs e)
        {
            if (e?.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                if (e != null) { e.Effect = DragDropEffects.None; }
            }
        }
    }
}
