namespace GitUI.CommandsDialogs.BrowseDialog.DashboardControl
{
    partial class FormDashboardCustomizeRepoName
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
            System.Windows.Forms.FlowLayoutPanel flpnlControls;
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRepoName = new System.Windows.Forms.TextBox();
            this.lblRepoName = new System.Windows.Forms.Label();
            flpnlControls = new System.Windows.Forms.FlowLayoutPanel();
            flpnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnlControls
            // 
            flpnlControls.Controls.Add(this.btnOk);
            flpnlControls.Controls.Add(this.btnCancel);
            flpnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            flpnlControls.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpnlControls.Location = new System.Drawing.Point(0, 36);
            flpnlControls.Margin = new System.Windows.Forms.Padding(4);
            flpnlControls.Name = "flpnlControls";
            flpnlControls.Size = new System.Drawing.Size(512, 42);
            flpnlControls.TabIndex = 5;
            flpnlControls.WrapContents = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.AutoSize = true;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(353, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(155, 35);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseCompatibleTextRendering = true;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(251, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRepoName
            // 
            this.txtRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepoName.Location = new System.Drawing.Point(153, 5);
            this.txtRepoName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepoName.Name = "txtRepoName";
            this.txtRepoName.Size = new System.Drawing.Size(355, 27);
            this.txtRepoName.TabIndex = 6;
            // 
            // lblRepoName
            // 
            this.lblRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepoName.AutoSize = true;
            this.lblRepoName.Location = new System.Drawing.Point(13, 5);
            this.lblRepoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepoName.Name = "lblRepoName";
            this.lblRepoName.Size = new System.Drawing.Size(109, 25);
            this.lblRepoName.TabIndex = 7;
            this.lblRepoName.Text = "Repository name";
            this.lblRepoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRepoName.UseCompatibleTextRendering = true;
            // 
            // FormDashboardCustomizeRepoName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 78);
            this.Controls.Add(this.lblRepoName);
            this.Controls.Add(this.txtRepoName);
            this.Controls.Add(flpnlControls);
            this.Name = "FormDashboardCustomizeRepoName";
            // this.Load += new System.EventHandler(this.FormDashboardCustomizeRepoName_Load);
            flpnlControls.ResumeLayout(false);
            flpnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private TextBox txtRepoName;
        private Label lblRepoName;
    }
}
