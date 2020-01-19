namespace UnitecHospital
{
    partial class GraphicView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicView));
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.btnTreat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbNurse = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstGraphicView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.ttpCreate = new System.Windows.Forms.ToolTip(this.components);
            this.ttpUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.ttpSave = new System.Windows.Forms.ToolTip(this.components);
            this.ttpTreat = new System.Windows.Forms.ToolTip(this.components);
            this.ttpDelete = new System.Windows.Forms.ToolTip(this.components);
            this.ttpReturn = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(487, 126);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(100, 21);
            this.cmbStaffType.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(547, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Location = new System.Drawing.Point(487, 47);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(100, 21);
            this.cmbPersonType.TabIndex = 15;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.cmbPersonType_SelectedIndexChanged);
            // 
            // btnTreat
            // 
            this.btnTreat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTreat.BackgroundImage")));
            this.btnTreat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTreat.Location = new System.Drawing.Point(425, 281);
            this.btnTreat.Name = "btnTreat";
            this.btnTreat.Size = new System.Drawing.Size(40, 40);
            this.btnTreat.TabIndex = 14;
            this.btnTreat.UseVisualStyleBackColor = true;
            this.btnTreat.Click += new System.EventHandler(this.btnTreat_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Location = new System.Drawing.Point(547, 281);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(487, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Location = new System.Drawing.Point(487, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreate.Location = new System.Drawing.Point(425, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(40, 40);
            this.btnCreate.TabIndex = 10;
            this.ttpCreate.SetToolTip(this.btnCreate, "Add a new person");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbNurse
            // 
            this.cmbNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNurse.FormattingEnabled = true;
            this.cmbNurse.Location = new System.Drawing.Point(487, 180);
            this.cmbNurse.Name = "cmbNurse";
            this.cmbNurse.Size = new System.Drawing.Size(100, 21);
            this.cmbNurse.TabIndex = 7;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(487, 153);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(100, 21);
            this.cmbDoctor.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(487, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(487, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lstGraphicView
            // 
            this.lstGraphicView.Location = new System.Drawing.Point(12, 12);
            this.lstGraphicView.MultiSelect = false;
            this.lstGraphicView.Name = "lstGraphicView";
            this.lstGraphicView.Size = new System.Drawing.Size(380, 350);
            this.lstGraphicView.TabIndex = 16;
            this.lstGraphicView.UseCompatibleStateImageBehavior = false;
            this.lstGraphicView.SelectedIndexChanged += new System.EventHandler(this.lstGraphicView_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(443, 183);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(38, 13);
            this.lblNurse.TabIndex = 29;
            this.lblNurse.Text = "Nurse:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(439, 156);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(42, 13);
            this.lblDoctor.TabIndex = 28;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(422, 129);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(59, 13);
            this.lblStaffType.TabIndex = 27;
            this.lblStaffType.Text = "Staff Type:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(420, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(421, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.Location = new System.Drawing.Point(411, 50);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(70, 13);
            this.lblPersonType.TabIndex = 24;
            this.lblPersonType.Text = "Person Type:";
            // 
            // GraphicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 374);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbStaffType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTreat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbNurse);
            this.Controls.Add(this.lblStaffType);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbPersonType);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPersonType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lstGraphicView);
            this.Controls.Add(this.txtFirstName);
            this.Name = "GraphicView";
            this.Text = "Graphic View";
            this.Activated += new System.EventHandler(this.GraphicView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphicView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.Button btnTreat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbNurse;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListView lstGraphicView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.ToolTip ttpCreate;
        private System.Windows.Forms.ToolTip ttpUpdate;
        private System.Windows.Forms.ToolTip ttpSave;
        private System.Windows.Forms.ToolTip ttpTreat;
        private System.Windows.Forms.ToolTip ttpDelete;
        private System.Windows.Forms.ToolTip ttpReturn;
    }
}