namespace UnitecHospital
{
    partial class GraphicTreatView
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
            this.components = new System.ComponentModel.Container();
            this.pbxDoctor = new System.Windows.Forms.PictureBox();
            this.cmsDoctor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.diagnoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxNurse = new System.Windows.Forms.PictureBox();
            this.cmsNurse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.careToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTreatmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxPatient = new System.Windows.Forms.PictureBox();
            this.cmsPatient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTreatmentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoctor)).BeginInit();
            this.cmsDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNurse)).BeginInit();
            this.cmsNurse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatient)).BeginInit();
            this.cmsPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxDoctor
            // 
            this.pbxDoctor.ContextMenuStrip = this.cmsDoctor;
            this.pbxDoctor.Location = new System.Drawing.Point(38, 21);
            this.pbxDoctor.Name = "pbxDoctor";
            this.pbxDoctor.Size = new System.Drawing.Size(48, 48);
            this.pbxDoctor.TabIndex = 0;
            this.pbxDoctor.TabStop = false;
            // 
            // cmsDoctor
            // 
            this.cmsDoctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnoseToolStripMenuItem,
            this.exitTreatmentToolStripMenuItem});
            this.cmsDoctor.Name = "cmsDoctor";
            this.cmsDoctor.Size = new System.Drawing.Size(150, 48);
            // 
            // diagnoseToolStripMenuItem
            // 
            this.diagnoseToolStripMenuItem.Name = "diagnoseToolStripMenuItem";
            this.diagnoseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.diagnoseToolStripMenuItem.Text = "Diagnose";
            this.diagnoseToolStripMenuItem.Click += new System.EventHandler(this.diagnoseToolStripMenuItem_Click);
            // 
            // exitTreatmentToolStripMenuItem
            // 
            this.exitTreatmentToolStripMenuItem.Name = "exitTreatmentToolStripMenuItem";
            this.exitTreatmentToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitTreatmentToolStripMenuItem.Text = "Exit Treatment";
            this.exitTreatmentToolStripMenuItem.Click += new System.EventHandler(this.exitTreatmentToolStripMenuItem_Click);
            // 
            // pbxNurse
            // 
            this.pbxNurse.ContextMenuStrip = this.cmsNurse;
            this.pbxNurse.Location = new System.Drawing.Point(131, 21);
            this.pbxNurse.Name = "pbxNurse";
            this.pbxNurse.Size = new System.Drawing.Size(48, 48);
            this.pbxNurse.TabIndex = 1;
            this.pbxNurse.TabStop = false;
            // 
            // cmsNurse
            // 
            this.cmsNurse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.careToolStripMenuItem,
            this.exitTreatmentToolStripMenuItem1});
            this.cmsNurse.Name = "cmsNurse";
            this.cmsNurse.Size = new System.Drawing.Size(150, 48);
            // 
            // careToolStripMenuItem
            // 
            this.careToolStripMenuItem.Name = "careToolStripMenuItem";
            this.careToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.careToolStripMenuItem.Text = "Care";
            this.careToolStripMenuItem.Click += new System.EventHandler(this.careToolStripMenuItem_Click);
            // 
            // exitTreatmentToolStripMenuItem1
            // 
            this.exitTreatmentToolStripMenuItem1.Name = "exitTreatmentToolStripMenuItem1";
            this.exitTreatmentToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.exitTreatmentToolStripMenuItem1.Text = "Exit Treatment";
            this.exitTreatmentToolStripMenuItem1.Click += new System.EventHandler(this.exitTreatmentToolStripMenuItem_Click);
            // 
            // pbxPatient
            // 
            this.pbxPatient.ContextMenuStrip = this.cmsPatient;
            this.pbxPatient.Location = new System.Drawing.Point(222, 21);
            this.pbxPatient.Name = "pbxPatient";
            this.pbxPatient.Size = new System.Drawing.Size(48, 48);
            this.pbxPatient.TabIndex = 2;
            this.pbxPatient.TabStop = false;
            // 
            // cmsPatient
            // 
            this.cmsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recoverToolStripMenuItem,
            this.exitTreatmentToolStripMenuItem2});
            this.cmsPatient.Name = "cmsPatient";
            this.cmsPatient.Size = new System.Drawing.Size(150, 48);
            // 
            // recoverToolStripMenuItem
            // 
            this.recoverToolStripMenuItem.Name = "recoverToolStripMenuItem";
            this.recoverToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.recoverToolStripMenuItem.Text = "Recover";
            this.recoverToolStripMenuItem.Click += new System.EventHandler(this.recoverToolStripMenuItem_Click);
            // 
            // exitTreatmentToolStripMenuItem2
            // 
            this.exitTreatmentToolStripMenuItem2.Name = "exitTreatmentToolStripMenuItem2";
            this.exitTreatmentToolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.exitTreatmentToolStripMenuItem2.Text = "Exit Treatment";
            this.exitTreatmentToolStripMenuItem2.Click += new System.EventHandler(this.exitTreatmentToolStripMenuItem_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(26, 83);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 3;
            this.lblDoctor.Text = "Doctor";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNurse
            // 
            this.lblNurse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(118, 83);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(35, 13);
            this.lblNurse.TabIndex = 4;
            this.lblNurse.Text = "Nurse";
            this.lblNurse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(209, 83);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "Patient";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GraphicTreatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 118);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.pbxPatient);
            this.Controls.Add(this.pbxNurse);
            this.Controls.Add(this.pbxDoctor);
            this.Name = "GraphicTreatView";
            this.Text = "GraphicTreatView";
            this.Load += new System.EventHandler(this.GraphicTreatView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoctor)).EndInit();
            this.cmsDoctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNurse)).EndInit();
            this.cmsNurse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatient)).EndInit();
            this.cmsPatient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDoctor;
        private System.Windows.Forms.PictureBox pbxNurse;
        private System.Windows.Forms.PictureBox pbxPatient;
        private System.Windows.Forms.ContextMenuStrip cmsDoctor;
        private System.Windows.Forms.ToolStripMenuItem diagnoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTreatmentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsNurse;
        private System.Windows.Forms.ToolStripMenuItem careToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTreatmentToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsPatient;
        private System.Windows.Forms.ToolStripMenuItem recoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTreatmentToolStripMenuItem2;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblPatient;
    }
}