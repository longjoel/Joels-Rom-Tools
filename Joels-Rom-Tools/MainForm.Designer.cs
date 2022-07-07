namespace Joels_Rom_Tools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.WorkflowsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.WorkflowProgress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LogTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkflowsContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WorkflowProgress, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1433, 898);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 581);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(1427, 294);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // WorkflowsContainer
            // 
            this.WorkflowsContainer.AutoScroll = true;
            this.WorkflowsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkflowsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.WorkflowsContainer.Location = new System.Drawing.Point(3, 3);
            this.WorkflowsContainer.Name = "WorkflowsContainer";
            this.WorkflowsContainer.Size = new System.Drawing.Size(1427, 572);
            this.WorkflowsContainer.TabIndex = 1;
            // 
            // WorkflowProgress
            // 
            this.WorkflowProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkflowProgress.Location = new System.Drawing.Point(3, 881);
            this.WorkflowProgress.Name = "WorkflowProgress";
            this.WorkflowProgress.Size = new System.Drawing.Size(1427, 14);
            this.WorkflowProgress.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 898);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Joel\'s Rom Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox LogTextBox;
        private FlowLayoutPanel WorkflowsContainer;
        private ProgressBar WorkflowProgress;
    }
}