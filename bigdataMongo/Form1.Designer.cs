namespace bigdataMongo
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtboxCreateSurname = new System.Windows.Forms.TextBox();
            this.txtboxCreateName = new System.Windows.Forms.TextBox();
            this.txtboxCreateId = new System.Windows.Forms.TextBox();
            this.txtboxCreateAge = new System.Windows.Forms.TextBox();
            this.txtboxCreateLocation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.txtboxGet = new System.Windows.Forms.TextBox();
            this.lblGetId = new System.Windows.Forms.Label();
            this.txtboxGetId = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxUpdateLocation = new System.Windows.Forms.TextBox();
            this.txtboxUpdateAge = new System.Windows.Forms.TextBox();
            this.txtboxUpdateId = new System.Windows.Forms.TextBox();
            this.txtboxUpdateName = new System.Windows.Forms.TextBox();
            this.txtboxUpdateSurname = new System.Windows.Forms.TextBox();
            this.lblUpdateLocation = new System.Windows.Forms.Label();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.lblUpdateSurname = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxDeleteId = new System.Windows.Forms.TextBox();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 60);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 87);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 112);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // txtboxCreateSurname
            // 
            this.txtboxCreateSurname.Location = new System.Drawing.Point(70, 57);
            this.txtboxCreateSurname.Name = "txtboxCreateSurname";
            this.txtboxCreateSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxCreateSurname.TabIndex = 3;
            // 
            // txtboxCreateName
            // 
            this.txtboxCreateName.Location = new System.Drawing.Point(70, 31);
            this.txtboxCreateName.Name = "txtboxCreateName";
            this.txtboxCreateName.Size = new System.Drawing.Size(100, 20);
            this.txtboxCreateName.TabIndex = 2;
            // 
            // txtboxCreateId
            // 
            this.txtboxCreateId.Location = new System.Drawing.Point(70, 6);
            this.txtboxCreateId.Name = "txtboxCreateId";
            this.txtboxCreateId.Size = new System.Drawing.Size(100, 20);
            this.txtboxCreateId.TabIndex = 1;
            // 
            // txtboxCreateAge
            // 
            this.txtboxCreateAge.Location = new System.Drawing.Point(70, 84);
            this.txtboxCreateAge.Name = "txtboxCreateAge";
            this.txtboxCreateAge.Size = new System.Drawing.Size(100, 20);
            this.txtboxCreateAge.TabIndex = 4;
            // 
            // txtboxCreateLocation
            // 
            this.txtboxCreateLocation.Location = new System.Drawing.Point(70, 109);
            this.txtboxCreateLocation.Name = "txtboxCreateLocation";
            this.txtboxCreateLocation.Size = new System.Drawing.Size(100, 20);
            this.txtboxCreateLocation.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(593, 157);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 15;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // txtboxGet
            // 
            this.txtboxGet.Location = new System.Drawing.Point(12, 188);
            this.txtboxGet.Multiline = true;
            this.txtboxGet.Name = "txtboxGet";
            this.txtboxGet.Size = new System.Drawing.Size(656, 237);
            this.txtboxGet.TabIndex = 16;
            // 
            // lblGetId
            // 
            this.lblGetId.AutoSize = true;
            this.lblGetId.Location = new System.Drawing.Point(12, 162);
            this.lblGetId.Name = "lblGetId";
            this.lblGetId.Size = new System.Drawing.Size(19, 13);
            this.lblGetId.TabIndex = 17;
            this.lblGetId.Text = "Id:";
            // 
            // txtboxGetId
            // 
            this.txtboxGetId.Location = new System.Drawing.Point(37, 159);
            this.txtboxGetId.Name = "txtboxGetId";
            this.txtboxGetId.Size = new System.Drawing.Size(100, 20);
            this.txtboxGetId.TabIndex = 18;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(143, 157);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(430, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxUpdateLocation
            // 
            this.txtboxUpdateLocation.Location = new System.Drawing.Point(324, 109);
            this.txtboxUpdateLocation.Name = "txtboxUpdateLocation";
            this.txtboxUpdateLocation.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpdateLocation.TabIndex = 10;
            // 
            // txtboxUpdateAge
            // 
            this.txtboxUpdateAge.Location = new System.Drawing.Point(324, 84);
            this.txtboxUpdateAge.Name = "txtboxUpdateAge";
            this.txtboxUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpdateAge.TabIndex = 9;
            // 
            // txtboxUpdateId
            // 
            this.txtboxUpdateId.Location = new System.Drawing.Point(324, 6);
            this.txtboxUpdateId.Name = "txtboxUpdateId";
            this.txtboxUpdateId.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpdateId.TabIndex = 6;
            // 
            // txtboxUpdateName
            // 
            this.txtboxUpdateName.Location = new System.Drawing.Point(324, 31);
            this.txtboxUpdateName.Name = "txtboxUpdateName";
            this.txtboxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpdateName.TabIndex = 7;
            // 
            // txtboxUpdateSurname
            // 
            this.txtboxUpdateSurname.Location = new System.Drawing.Point(324, 57);
            this.txtboxUpdateSurname.Name = "txtboxUpdateSurname";
            this.txtboxUpdateSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpdateSurname.TabIndex = 8;
            // 
            // lblUpdateLocation
            // 
            this.lblUpdateLocation.AutoSize = true;
            this.lblUpdateLocation.Location = new System.Drawing.Point(266, 112);
            this.lblUpdateLocation.Name = "lblUpdateLocation";
            this.lblUpdateLocation.Size = new System.Drawing.Size(51, 13);
            this.lblUpdateLocation.TabIndex = 24;
            this.lblUpdateLocation.Text = "Location:";
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(266, 87);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(29, 13);
            this.lblUpdateAge.TabIndex = 23;
            this.lblUpdateAge.Text = "Age:";
            // 
            // lblUpdateSurname
            // 
            this.lblUpdateSurname.AutoSize = true;
            this.lblUpdateSurname.Location = new System.Drawing.Point(266, 60);
            this.lblUpdateSurname.Name = "lblUpdateSurname";
            this.lblUpdateSurname.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateSurname.TabIndex = 22;
            this.lblUpdateSurname.Text = "Surname:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(266, 34);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(38, 13);
            this.lblUpdateName.TabIndex = 21;
            this.lblUpdateName.Text = "Name:";
            // 
            // lblUpdateId
            // 
            this.lblUpdateId.AutoSize = true;
            this.lblUpdateId.Location = new System.Drawing.Point(266, 9);
            this.lblUpdateId.Name = "lblUpdateId";
            this.lblUpdateId.Size = new System.Drawing.Size(19, 13);
            this.lblUpdateId.TabIndex = 20;
            this.lblUpdateId.Text = "Id:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtboxDeleteId
            // 
            this.txtboxDeleteId.Location = new System.Drawing.Point(292, 159);
            this.txtboxDeleteId.Name = "txtboxDeleteId";
            this.txtboxDeleteId.Size = new System.Drawing.Size(100, 20);
            this.txtboxDeleteId.TabIndex = 32;
            // 
            // lblDeleteId
            // 
            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Location = new System.Drawing.Point(267, 162);
            this.lblDeleteId.Name = "lblDeleteId";
            this.lblDeleteId.Size = new System.Drawing.Size(19, 13);
            this.lblDeleteId.TabIndex = 31;
            this.lblDeleteId.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtboxDeleteId);
            this.Controls.Add(this.lblDeleteId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxUpdateLocation);
            this.Controls.Add(this.txtboxUpdateAge);
            this.Controls.Add(this.txtboxUpdateId);
            this.Controls.Add(this.txtboxUpdateName);
            this.Controls.Add(this.txtboxUpdateSurname);
            this.Controls.Add(this.lblUpdateLocation);
            this.Controls.Add(this.lblUpdateAge);
            this.Controls.Add(this.lblUpdateSurname);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.lblUpdateId);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtboxGetId);
            this.Controls.Add(this.lblGetId);
            this.Controls.Add(this.txtboxGet);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxCreateLocation);
            this.Controls.Add(this.txtboxCreateAge);
            this.Controls.Add(this.txtboxCreateId);
            this.Controls.Add(this.txtboxCreateName);
            this.Controls.Add(this.txtboxCreateSurname);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Mongo CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtboxCreateSurname;
        private System.Windows.Forms.TextBox txtboxCreateName;
        private System.Windows.Forms.TextBox txtboxCreateId;
        private System.Windows.Forms.TextBox txtboxCreateAge;
        private System.Windows.Forms.TextBox txtboxCreateLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.TextBox txtboxGet;
        private System.Windows.Forms.Label lblGetId;
        private System.Windows.Forms.TextBox txtboxGetId;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtboxUpdateLocation;
        private System.Windows.Forms.TextBox txtboxUpdateAge;
        private System.Windows.Forms.TextBox txtboxUpdateId;
        private System.Windows.Forms.TextBox txtboxUpdateName;
        private System.Windows.Forms.TextBox txtboxUpdateSurname;
        private System.Windows.Forms.Label lblUpdateLocation;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.Label lblUpdateSurname;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxDeleteId;
        private System.Windows.Forms.Label lblDeleteId;
    }
}

