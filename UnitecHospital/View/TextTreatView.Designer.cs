namespace UnitecHospital
{
    partial class TextTreatView
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btnDiagnose = new System.Windows.Forms.Button();
            this.btnCare = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(12, 13);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(42, 13);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(12, 65);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(38, 13);
            this.lblNurse.TabIndex = 1;
            this.lblNurse.Text = "Nurse:";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(12, 117);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(43, 13);
            this.lblPatient.TabIndex = 2;
            this.lblPatient.Text = "Patient:";
            // 
            // btnDiagnose
            // 
            this.btnDiagnose.Location = new System.Drawing.Point(172, 7);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(100, 25);
            this.btnDiagnose.TabIndex = 3;
            this.btnDiagnose.Text = "Diagnose";
            this.btnDiagnose.UseVisualStyleBackColor = true;
            this.btnDiagnose.Click += new System.EventHandler(this.btnDiagnose_Click);
            // 
            // btnCare
            // 
            this.btnCare.Location = new System.Drawing.Point(172, 59);
            this.btnCare.Name = "btnCare";
            this.btnCare.Size = new System.Drawing.Size(100, 25);
            this.btnCare.TabIndex = 4;
            this.btnCare.Text = "Care";
            this.btnCare.UseVisualStyleBackColor = true;
            this.btnCare.Click += new System.EventHandler(this.btnCare_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(172, 111);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(100, 25);
            this.btnRecover.TabIndex = 5;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // TextTreatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnCare);
            this.Controls.Add(this.btnDiagnose);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.lblDoctor);
            this.Name = "TextTreatView";
            this.Text = "TextTreatView";
            this.Load += new System.EventHandler(this.TreatView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button btnDiagnose;
        private System.Windows.Forms.Button btnCare;
        private System.Windows.Forms.Button btnRecover;
    }
}