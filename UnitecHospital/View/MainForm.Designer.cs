namespace UnitecHospital
{
    partial class MainForm
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
            this.btnTextView = new System.Windows.Forms.Button();
            this.btnGraphicView = new System.Windows.Forms.Button();
            this.btnReadonlyView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblUnitec = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTextView
            // 
            this.btnTextView.Location = new System.Drawing.Point(12, 155);
            this.btnTextView.Name = "btnTextView";
            this.btnTextView.Size = new System.Drawing.Size(100, 30);
            this.btnTextView.TabIndex = 1;
            this.btnTextView.Text = "Text View";
            this.btnTextView.UseVisualStyleBackColor = true;
            this.btnTextView.Click += new System.EventHandler(this.btnTextView_Click);
            // 
            // btnGraphicView
            // 
            this.btnGraphicView.Location = new System.Drawing.Point(118, 155);
            this.btnGraphicView.Name = "btnGraphicView";
            this.btnGraphicView.Size = new System.Drawing.Size(100, 30);
            this.btnGraphicView.TabIndex = 2;
            this.btnGraphicView.Text = "Graphic View";
            this.btnGraphicView.UseVisualStyleBackColor = true;
            this.btnGraphicView.Click += new System.EventHandler(this.btnGraphicView_Click);
            // 
            // btnReadonlyView
            // 
            this.btnReadonlyView.Location = new System.Drawing.Point(224, 155);
            this.btnReadonlyView.Name = "btnReadonlyView";
            this.btnReadonlyView.Size = new System.Drawing.Size(100, 30);
            this.btnReadonlyView.TabIndex = 3;
            this.btnReadonlyView.Text = "Readonly View";
            this.btnReadonlyView.UseVisualStyleBackColor = true;
            this.btnReadonlyView.Click += new System.EventHandler(this.btnReadonlyView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(224, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 191);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(100, 30);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblUnitec
            // 
            this.lblUnitec.AutoSize = true;
            this.lblUnitec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitec.Location = new System.Drawing.Point(64, 26);
            this.lblUnitec.Name = "lblUnitec";
            this.lblUnitec.Size = new System.Drawing.Size(209, 55);
            this.lblUnitec.TabIndex = 5;
            this.lblUnitec.Text = "UNITEC";
            this.lblUnitec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospital.Location = new System.Drawing.Point(34, 81);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(269, 55);
            this.lblHospital.TabIndex = 6;
            this.lblHospital.Text = "HOSPITAL";
            this.lblHospital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 233);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblUnitec);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadonlyView);
            this.Controls.Add(this.btnGraphicView);
            this.Controls.Add(this.btnTextView);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTextView;
        private System.Windows.Forms.Button btnGraphicView;
        private System.Windows.Forms.Button btnReadonlyView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblUnitec;
        private System.Windows.Forms.Label lblHospital;
    }
}

