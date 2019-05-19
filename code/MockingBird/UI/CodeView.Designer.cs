namespace MockingBird.UI
{
    partial class CodeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeView));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.tblCodeMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarCode = new System.Windows.Forms.ToolStrip();
            this.btnCopyCode = new System.Windows.Forms.ToolStripButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tabCodeTemplate = new System.Windows.Forms.TabPage();
            this.tblTemplateMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarTemplate = new System.Windows.Forms.ToolStrip();
            this.cmbTpl = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveTpl = new System.Windows.Forms.ToolStripButton();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.btnSaveAsFile = new System.Windows.Forms.ToolStripButton();
            this.tabMain.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tblCodeMain.SuspendLayout();
            this.toolbarCode.SuspendLayout();
            this.tabCodeTemplate.SuspendLayout();
            this.tblTemplateMain.SuspendLayout();
            this.toolbarTemplate.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabOutput);
            this.tabMain.Controls.Add(this.tabCodeTemplate);
            this.tabMain.Controls.Add(this.tabAbout);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(662, 332);
            this.tabMain.TabIndex = 3;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.tblCodeMain);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutput.Size = new System.Drawing.Size(654, 306);
            this.tabOutput.TabIndex = 1;
            this.tabOutput.Text = "Generate Code";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // tblCodeMain
            // 
            this.tblCodeMain.ColumnCount = 1;
            this.tblCodeMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeMain.Controls.Add(this.toolbarCode, 0, 0);
            this.tblCodeMain.Controls.Add(this.txtOutput, 0, 1);
            this.tblCodeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCodeMain.Location = new System.Drawing.Point(3, 3);
            this.tblCodeMain.Name = "tblCodeMain";
            this.tblCodeMain.RowCount = 2;
            this.tblCodeMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCodeMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeMain.Size = new System.Drawing.Size(648, 300);
            this.tblCodeMain.TabIndex = 3;
            // 
            // toolbarCode
            // 
            this.toolbarCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolbarCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopyCode,
            this.btnSaveAsFile});
            this.toolbarCode.Location = new System.Drawing.Point(0, 0);
            this.toolbarCode.Name = "toolbarCode";
            this.toolbarCode.Size = new System.Drawing.Size(648, 25);
            this.toolbarCode.TabIndex = 1;
            this.toolbarCode.Text = "toolbarCode";
            // 
            // btnCopyCode
            // 
            this.btnCopyCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopyCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopyCode.Image = global::MockingBird.Properties.Resources.MockingBirdIcon;
            this.btnCopyCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyCode.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnCopyCode.Name = "btnCopyCode";
            this.btnCopyCode.Size = new System.Drawing.Size(68, 22);
            this.btnCopyCode.Text = "Copy code";
            this.btnCopyCode.Click += new System.EventHandler(this.btnCopyCode_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 33);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(642, 264);
            this.txtOutput.TabIndex = 1;
            // 
            // tabCodeTemplate
            // 
            this.tabCodeTemplate.Controls.Add(this.tblTemplateMain);
            this.tabCodeTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabCodeTemplate.Name = "tabCodeTemplate";
            this.tabCodeTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCodeTemplate.Size = new System.Drawing.Size(654, 306);
            this.tabCodeTemplate.TabIndex = 0;
            this.tabCodeTemplate.Text = "Template";
            this.tabCodeTemplate.UseVisualStyleBackColor = true;
            // 
            // tblTemplateMain
            // 
            this.tblTemplateMain.ColumnCount = 1;
            this.tblTemplateMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTemplateMain.Controls.Add(this.toolbarTemplate, 0, 0);
            this.tblTemplateMain.Controls.Add(this.txtTemplate, 0, 1);
            this.tblTemplateMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTemplateMain.Location = new System.Drawing.Point(3, 3);
            this.tblTemplateMain.Name = "tblTemplateMain";
            this.tblTemplateMain.RowCount = 2;
            this.tblTemplateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblTemplateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTemplateMain.Size = new System.Drawing.Size(648, 300);
            this.tblTemplateMain.TabIndex = 2;
            // 
            // toolbarTemplate
            // 
            this.toolbarTemplate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbTpl,
            this.btnSaveTpl});
            this.toolbarTemplate.Location = new System.Drawing.Point(0, 0);
            this.toolbarTemplate.Name = "toolbarTemplate";
            this.toolbarTemplate.Size = new System.Drawing.Size(648, 25);
            this.toolbarTemplate.TabIndex = 1;
            this.toolbarTemplate.Text = "toolbarTemplate";
            // 
            // cmbTpl
            // 
            this.cmbTpl.Name = "cmbTpl";
            this.cmbTpl.Size = new System.Drawing.Size(250, 25);
            // 
            // btnSaveTpl
            // 
            this.btnSaveTpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveTpl.Image = global::MockingBird.Properties.Resources.MockingBirdIcon;
            this.btnSaveTpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveTpl.Name = "btnSaveTpl";
            this.btnSaveTpl.Size = new System.Drawing.Size(35, 22);
            this.btnSaveTpl.Text = "Save";
            this.btnSaveTpl.Click += new System.EventHandler(this.btnSaveTpl_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Location = new System.Drawing.Point(3, 33);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(642, 264);
            this.txtTemplate.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Controls.Add(this.logoPicture);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(654, 306);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "MockingBird 1.0.0\r\n\r\nCreated By: Hemant Sharma";
            // 
            // logoPicture
            // 
            this.logoPicture.BackgroundImage = global::MockingBird.Properties.Resources.MockingBird;
            this.logoPicture.Image = global::MockingBird.Properties.Resources.MockingBird;
            this.logoPicture.InitialImage = global::MockingBird.Properties.Resources.MockingBird;
            this.logoPicture.Location = new System.Drawing.Point(6, 6);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(140, 109);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // btnSaveAsFile
            // 
            this.btnSaveAsFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveAsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveAsFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsFile.Image")));
            this.btnSaveAsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsFile.Name = "btnSaveAsFile";
            this.btnSaveAsFile.Size = new System.Drawing.Size(68, 22);
            this.btnSaveAsFile.Text = "Save as file";
            this.btnSaveAsFile.Click += new System.EventHandler(this.btnSaveAsFile_Click);
            // 
            // CodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "CodeView";
            this.Size = new System.Drawing.Size(662, 332);
            this.tabMain.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tblCodeMain.ResumeLayout(false);
            this.tblCodeMain.PerformLayout();
            this.toolbarCode.ResumeLayout(false);
            this.toolbarCode.PerformLayout();
            this.tabCodeTemplate.ResumeLayout(false);
            this.tblTemplateMain.ResumeLayout(false);
            this.tblTemplateMain.PerformLayout();
            this.toolbarTemplate.ResumeLayout(false);
            this.toolbarTemplate.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCodeTemplate;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.ToolStrip toolbarTemplate;
        private System.Windows.Forms.ToolStripComboBox cmbTpl;
        private System.Windows.Forms.ToolStripButton btnSaveTpl;
        private System.Windows.Forms.TableLayoutPanel tblTemplateMain;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TableLayoutPanel tblCodeMain;
        private System.Windows.Forms.ToolStrip toolbarCode;
        private System.Windows.Forms.ToolStripButton btnCopyCode;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnSaveAsFile;
    }
}
