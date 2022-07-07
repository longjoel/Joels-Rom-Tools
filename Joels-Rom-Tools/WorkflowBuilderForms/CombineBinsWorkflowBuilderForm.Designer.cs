namespace Joels_Rom_Tools.WorkflowBuilderForms
{
    partial class CombineBinsWorkflowBuilderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectBinsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PickCueFileButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedBinsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveSelectedUpButton = new System.Windows.Forms.Button();
            this.MoveSelectedDownButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BinLocationTxt = new System.Windows.Forms.TextBox();
            this.CueLocationTxt = new System.Windows.Forms.TextBox();
            this.RemoveOriginalBinsCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RunTaskButton = new System.Windows.Forms.Button();
            this.CancelTaskButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 852);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select source.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SelectedBinsListBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1093, 460);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SelectBinsButton);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.PickCueFileButton);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1087, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SelectBinsButton
            // 
            this.SelectBinsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectBinsButton.Location = new System.Drawing.Point(3, 3);
            this.SelectBinsButton.Name = "SelectBinsButton";
            this.SelectBinsButton.Size = new System.Drawing.Size(162, 34);
            this.SelectBinsButton.TabIndex = 0;
            this.SelectBinsButton.Text = "Pick bin files";
            this.SelectBinsButton.UseVisualStyleBackColor = true;
            this.SelectBinsButton.Click += new System.EventHandler(this.SelectBinsButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select one or more bin files to combine.";
            // 
            // PickCueFileButton
            // 
            this.PickCueFileButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PickCueFileButton.Location = new System.Drawing.Point(505, 3);
            this.PickCueFileButton.Name = "PickCueFileButton";
            this.PickCueFileButton.Size = new System.Drawing.Size(112, 34);
            this.PickCueFileButton.TabIndex = 2;
            this.PickCueFileButton.Text = "Pick cue file";
            this.PickCueFileButton.UseVisualStyleBackColor = true;
            this.PickCueFileButton.Click += new System.EventHandler(this.PickCueFileButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Load the bins from a cue file.";
            // 
            // SelectedBinsListBox
            // 
            this.SelectedBinsListBox.AllowDrop = true;
            this.SelectedBinsListBox.DisplayMember = "Text";
            this.SelectedBinsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedBinsListBox.FormattingEnabled = true;
            this.SelectedBinsListBox.ItemHeight = 25;
            this.SelectedBinsListBox.Location = new System.Drawing.Point(3, 53);
            this.SelectedBinsListBox.Name = "SelectedBinsListBox";
            this.SelectedBinsListBox.Size = new System.Drawing.Size(1087, 404);
            this.SelectedBinsListBox.TabIndex = 1;
            this.SelectedBinsListBox.ValueMember = "Text";
            this.SelectedBinsListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SelectedBinsListBox_DragDrop);
            this.SelectedBinsListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.SelectedBinsListBox_DragOver);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.MoveSelectedUpButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MoveSelectedDownButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 519);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1093, 40);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // MoveSelectedUpButton
            // 
            this.MoveSelectedUpButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MoveSelectedUpButton.Location = new System.Drawing.Point(3, 3);
            this.MoveSelectedUpButton.Name = "MoveSelectedUpButton";
            this.MoveSelectedUpButton.Size = new System.Drawing.Size(94, 34);
            this.MoveSelectedUpButton.TabIndex = 0;
            this.MoveSelectedUpButton.Text = "▲";
            this.MoveSelectedUpButton.UseVisualStyleBackColor = true;
            this.MoveSelectedUpButton.Click += new System.EventHandler(this.MoveSelectedUpButton_Click);
            // 
            // MoveSelectedDownButton
            // 
            this.MoveSelectedDownButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MoveSelectedDownButton.Location = new System.Drawing.Point(996, 3);
            this.MoveSelectedDownButton.Name = "MoveSelectedDownButton";
            this.MoveSelectedDownButton.Size = new System.Drawing.Size(94, 34);
            this.MoveSelectedDownButton.TabIndex = 1;
            this.MoveSelectedDownButton.Text = "▼";
            this.MoveSelectedDownButton.UseVisualStyleBackColor = true;
            this.MoveSelectedDownButton.Click += new System.EventHandler(this.MoveSelectedDownButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Use these buttons to reorder the loaded bin files.";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.15371F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.8463F));
            this.tableLayoutPanel4.Controls.Add(this.BinLocationTxt, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.CueLocationTxt, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.RemoveOriginalBinsCheckbox, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 615);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1093, 184);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // BinLocationTxt
            // 
            this.BinLocationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BinLocationTxt.Location = new System.Drawing.Point(267, 82);
            this.BinLocationTxt.Name = "BinLocationTxt";
            this.BinLocationTxt.Size = new System.Drawing.Size(823, 31);
            this.BinLocationTxt.TabIndex = 3;
            // 
            // CueLocationTxt
            // 
            this.CueLocationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CueLocationTxt.Location = new System.Drawing.Point(267, 17);
            this.CueLocationTxt.Name = "CueLocationTxt";
            this.CueLocationTxt.Size = new System.Drawing.Size(823, 31);
            this.CueLocationTxt.TabIndex = 1;
            // 
            // RemoveOriginalBinsCheckbox
            // 
            this.RemoveOriginalBinsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveOriginalBinsCheckbox.AutoSize = true;
            this.RemoveOriginalBinsCheckbox.Location = new System.Drawing.Point(267, 133);
            this.RemoveOriginalBinsCheckbox.Name = "RemoveOriginalBinsCheckbox";
            this.RemoveOriginalBinsCheckbox.Size = new System.Drawing.Size(212, 48);
            this.RemoveOriginalBinsCheckbox.TabIndex = 4;
            this.RemoveOriginalBinsCheckbox.Text = "Remove original bins?";
            this.RemoveOriginalBinsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cue file location";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bin file location";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.RunTaskButton);
            this.flowLayoutPanel2.Controls.Add(this.CancelTaskButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(860, 809);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(236, 40);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // RunTaskButton
            // 
            this.RunTaskButton.Location = new System.Drawing.Point(121, 3);
            this.RunTaskButton.Name = "RunTaskButton";
            this.RunTaskButton.Size = new System.Drawing.Size(112, 34);
            this.RunTaskButton.TabIndex = 0;
            this.RunTaskButton.Text = "Run ✔";
            this.RunTaskButton.UseVisualStyleBackColor = true;
            this.RunTaskButton.Click += new System.EventHandler(this.RunTaskButton_Click);
            // 
            // CancelTaskButton
            // 
            this.CancelTaskButton.Location = new System.Drawing.Point(3, 3);
            this.CancelTaskButton.Name = "CancelTaskButton";
            this.CancelTaskButton.Size = new System.Drawing.Size(112, 34);
            this.CancelTaskButton.TabIndex = 1;
            this.CancelTaskButton.Text = "Cancel ❌";
            this.CancelTaskButton.UseVisualStyleBackColor = true;
            this.CancelTaskButton.Click += new System.EventHandler(this.CancelTaskButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output options.";
            // 
            // CombineBinsWorkflowBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 852);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CombineBinsWorkflowBuilderForm";
            this.Text = "Combine Bins";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SelectBinsButton;
        private Label label3;
        private ListBox SelectedBinsListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button MoveSelectedUpButton;
        private Button MoveSelectedDownButton;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox BinLocationTxt;
        private TextBox CueLocationTxt;
        private CheckBox RemoveOriginalBinsCheckbox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button RunTaskButton;
        private Button CancelTaskButton;
        private Button PickCueFileButton;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}