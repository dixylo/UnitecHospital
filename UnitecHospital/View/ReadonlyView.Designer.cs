namespace UnitecHospital
{
    partial class ReadonlyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadonlyView));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lstGraphicView = new System.Windows.Forms.ListView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStaffType = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ttpReturn = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Location = new System.Drawing.Point(477, 276);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(433, 214);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(38, 13);
            this.lblNurse.TabIndex = 48;
            this.lblNurse.Text = "Nurse:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(429, 187);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(42, 13);
            this.lblDoctor.TabIndex = 47;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(412, 160);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(59, 13);
            this.lblStaffType.TabIndex = 46;
            this.lblStaffType.Text = "Staff Type:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(410, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name:";
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Location = new System.Drawing.Point(477, 78);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(100, 21);
            this.cmbPersonType.TabIndex = 39;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.cmbPersonType_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(411, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 44;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.Location = new System.Drawing.Point(401, 81);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(70, 13);
            this.lblPersonType.TabIndex = 43;
            this.lblPersonType.Text = "Person Type:";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(477, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 31;
            // 
            // lstGraphicView
            // 
            this.lstGraphicView.Location = new System.Drawing.Point(12, 12);
            this.lstGraphicView.MultiSelect = false;
            this.lstGraphicView.Name = "lstGraphicView";
            this.lstGraphicView.Size = new System.Drawing.Size(380, 350);
            this.lstGraphicView.TabIndex = 41;
            this.lstGraphicView.UseCompatibleStateImageBehavior = false;
            this.lstGraphicView.SelectedIndexChanged += new System.EventHandler(this.lstGraphicView_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(477, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 30;
            // 
            // txtStaffType
            // 
            this.txtStaffType.Enabled = false;
            this.txtStaffType.Location = new System.Drawing.Point(477, 157);
            this.txtStaffType.Name = "txtStaffType";
            this.txtStaffType.Size = new System.Drawing.Size(100, 20);
            this.txtStaffType.TabIndex = 49;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Enabled = false;
            this.txtDoctor.Location = new System.Drawing.Point(477, 184);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtDoctor.TabIndex = 50;
            // 
            // txtNurse
            // 
            this.txtNurse.Enabled = false;
            this.txtNurse.Location = new System.Drawing.Point(477, 211);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(100, 20);
            this.txtNurse.TabIndex = 51;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ReadonlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 371);
            this.Controls.Add(this.txtNurse);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtStaffType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblStaffType);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cmbPersonType);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPersonType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lstGraphicView);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ReadonlyView";
            this.Text = "ReadonlyView";
            this.Activated += new System.EventHandler(this.ReadonlyView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadonlyView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ListView lstGraphicView;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStaffType;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip ttpReturn;
    }
}