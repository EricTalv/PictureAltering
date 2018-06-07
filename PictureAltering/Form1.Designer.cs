namespace PictureAltering
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PBX_Input = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TLS_ChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TLS_ChooseFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTriangle = new System.Windows.Forms.ToolStripButton();
            this.toolCircle = new System.Windows.Forms.ToolStripButton();
            this.toolDiamond = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PBX_Output = new System.Windows.Forms.PictureBox();
            this.Input = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSL_Size = new System.Windows.Forms.ToolStripStatusLabel();
            this.L_ModeStatus = new System.Windows.Forms.Label();
            this.LBX_Pictures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Input)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Output)).BeginInit();
            this.Input.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBX_Input
            // 
            this.PBX_Input.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBX_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Input.Location = new System.Drawing.Point(12, 25);
            this.PBX_Input.Name = "PBX_Input";
            this.PBX_Input.Size = new System.Drawing.Size(286, 254);
            this.PBX_Input.TabIndex = 9;
            this.PBX_Input.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolTriangle,
            this.toolCircle,
            this.toolDiamond});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(876, 32);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLS_ChooseFile,
            this.TLS_ChooseFolder});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 29);
            this.toolStripLabel1.Text = "File";
            // 
            // TLS_ChooseFile
            // 
            this.TLS_ChooseFile.Name = "TLS_ChooseFile";
            this.TLS_ChooseFile.Size = new System.Drawing.Size(252, 30);
            this.TLS_ChooseFile.Text = "Choose Picture";
            this.TLS_ChooseFile.Click += new System.EventHandler(this.TLS_ChooseFile_Click);
            // 
            // TLS_ChooseFolder
            // 
            this.TLS_ChooseFolder.Name = "TLS_ChooseFolder";
            this.TLS_ChooseFolder.Size = new System.Drawing.Size(252, 30);
            this.TLS_ChooseFolder.Text = "Choose Folder";
            this.TLS_ChooseFolder.Click += new System.EventHandler(this.TLS_ChooseFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolTriangle
            // 
            this.toolTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTriangle.Image = ((System.Drawing.Image)(resources.GetObject("toolTriangle.Image")));
            this.toolTriangle.ImageTransparentColor = System.Drawing.Color.White;
            this.toolTriangle.Name = "toolTriangle";
            this.toolTriangle.Size = new System.Drawing.Size(28, 29);
            this.toolTriangle.Text = "toolTriangle";
            this.toolTriangle.ToolTipText = "TRIANGLE";
            this.toolTriangle.Click += new System.EventHandler(this.toolTriangle_Click);
            // 
            // toolCircle
            // 
            this.toolCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolCircle.Image")));
            this.toolCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCircle.Name = "toolCircle";
            this.toolCircle.Size = new System.Drawing.Size(28, 29);
            this.toolCircle.Text = "toolCircle";
            this.toolCircle.ToolTipText = "CIRCLE";
            this.toolCircle.Click += new System.EventHandler(this.toolCircle_Click);
            // 
            // toolDiamond
            // 
            this.toolDiamond.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDiamond.Image = ((System.Drawing.Image)(resources.GetObject("toolDiamond.Image")));
            this.toolDiamond.ImageTransparentColor = System.Drawing.Color.White;
            this.toolDiamond.Name = "toolDiamond";
            this.toolDiamond.Size = new System.Drawing.Size(28, 29);
            this.toolDiamond.Text = "toolStripButton1";
            this.toolDiamond.Click += new System.EventHandler(this.toolDiamond_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PBX_Output);
            this.groupBox1.Location = new System.Drawing.Point(552, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 291);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // PBX_Output
            // 
            this.PBX_Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PBX_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Output.Location = new System.Drawing.Point(12, 25);
            this.PBX_Output.Name = "PBX_Output";
            this.PBX_Output.Size = new System.Drawing.Size(286, 254);
            this.PBX_Output.TabIndex = 10;
            this.PBX_Output.TabStop = false;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.PBX_Input);
            this.Input.Location = new System.Drawing.Point(235, 49);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(311, 291);
            this.Input.TabIndex = 11;
            this.Input.TabStop = false;
            this.Input.Text = "Input";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_Size});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 30);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSL_Size
            // 
            this.TSL_Size.Name = "TSL_Size";
            this.TSL_Size.Size = new System.Drawing.Size(43, 25);
            this.TSL_Size.Text = "Size";
            // 
            // L_ModeStatus
            // 
            this.L_ModeStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_ModeStatus.Location = new System.Drawing.Point(235, 349);
            this.L_ModeStatus.Name = "L_ModeStatus";
            this.L_ModeStatus.Size = new System.Drawing.Size(629, 34);
            this.L_ModeStatus.TabIndex = 14;
            this.L_ModeStatus.Text = "Mode:";
            // 
            // LBX_Pictures
            // 
            this.LBX_Pictures.FormattingEnabled = true;
            this.LBX_Pictures.ItemHeight = 22;
            this.LBX_Pictures.Location = new System.Drawing.Point(29, 49);
            this.LBX_Pictures.Name = "LBX_Pictures";
            this.LBX_Pictures.Size = new System.Drawing.Size(200, 334);
            this.LBX_Pictures.TabIndex = 13;
            this.LBX_Pictures.SelectedIndexChanged += new System.EventHandler(this.LBX_Pictures_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 428);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.L_ModeStatus);
            this.Controls.Add(this.LBX_Pictures);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Altering Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Input)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Output)).EndInit();
            this.Input.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Input;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem TLS_ChooseFile;
        private System.Windows.Forms.ToolStripMenuItem TLS_ChooseFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolTriangle;
        private System.Windows.Forms.ToolStripButton toolCircle;
        private System.Windows.Forms.ToolStripButton toolDiamond;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBX_Output;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSL_Size;
        private System.Windows.Forms.Label L_ModeStatus;
        private System.Windows.Forms.ListBox LBX_Pictures;
    }
}

