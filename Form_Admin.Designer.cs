namespace OrderingSystem
{
    partial class Form_Admin
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
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTRegister = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.DataGridView_Admin = new System.Windows.Forms.DataGridView();
            this.ErrorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRole)).BeginInit();
            this.SuspendLayout();
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(352, 146);
            this.LNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(123, 31);
            this.LNameLabel.TabIndex = 26;
            this.LNameLabel.Text = "Last Name";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(352, 41);
            this.FNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(127, 31);
            this.FNameLabel.TabIndex = 25;
            this.FNameLabel.Text = "First Name";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(680, 41);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(201, 29);
            this.ContactLabel.TabIndex = 24;
            this.ContactLabel.Text = "Contact Number";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(680, 148);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(68, 29);
            this.RoleLabel.TabIndex = 23;
            this.RoleLabel.Text = "Role";
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(990, 180);
            this.BTDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(200, 37);
            this.BTDelete.TabIndex = 22;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.Location = new System.Drawing.Point(990, 133);
            this.BTUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(200, 37);
            this.BTUpdate.TabIndex = 21;
            this.BTUpdate.Text = "Update";
            this.BTUpdate.UseVisualStyleBackColor = true;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTRegister
            // 
            this.BTRegister.Location = new System.Drawing.Point(990, 77);
            this.BTRegister.Margin = new System.Windows.Forms.Padding(5);
            this.BTRegister.Name = "BTRegister";
            this.BTRegister.Size = new System.Drawing.Size(200, 40);
            this.BTRegister.TabIndex = 20;
            this.BTRegister.Text = "Register";
            this.BTRegister.UseVisualStyleBackColor = true;
            this.BTRegister.Click += new System.EventHandler(this.BTRegister_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(44, 148);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 31);
            this.PasswordLabel.TabIndex = 19;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(44, 41);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(118, 31);
            this.UserNameLabel.TabIndex = 18;
            this.UserNameLabel.Text = "Username";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(358, 73);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(234, 38);
            this.TxtFirstName.TabIndex = 27;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(50, 73);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(234, 38);
            this.TxtUsername.TabIndex = 28;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(50, 182);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(234, 38);
            this.TxtPassword.TabIndex = 29;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(358, 179);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(234, 38);
            this.TxtLastName.TabIndex = 30;
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(685, 73);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(234, 38);
            this.TxtContact.TabIndex = 31;
            // 
            // DataGridView_Admin
            // 
            this.DataGridView_Admin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Admin.Location = new System.Drawing.Point(50, 246);
            this.DataGridView_Admin.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView_Admin.Name = "DataGridView_Admin";
            this.DataGridView_Admin.RowHeadersWidth = 51;
            this.DataGridView_Admin.Size = new System.Drawing.Size(1140, 255);
            this.DataGridView_Admin.TabIndex = 33;
            this.DataGridView_Admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Admin_CellClick);
            this.DataGridView_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Admin_CellContentClick);
            // 
            // ErrorProviderUsername
            // 
            this.ErrorProviderUsername.ContainerControl = this;
            // 
            // ErrorProviderPassword
            // 
            this.ErrorProviderPassword.ContainerControl = this;
            // 
            // ErrorProviderFirstName
            // 
            this.ErrorProviderFirstName.ContainerControl = this;
            // 
            // ErrorProviderLastName
            // 
            this.ErrorProviderLastName.ContainerControl = this;
            // 
            // ErrorProviderContact
            // 
            this.ErrorProviderContact.ContainerControl = this;
            // 
            // ErrorProviderRole
            // 
            this.ErrorProviderRole.ContainerControl = this;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbRole.Location = new System.Drawing.Point(685, 187);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 24);
            this.cbRole.TabIndex = 34;
            this.cbRole.Text = "Roles";
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1227, 515);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.DataGridView_Admin);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRegister);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "Form_Admin";
            this.Text = "Admin Access";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTRegister;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.DataGridView DataGridView_Admin;
        private System.Windows.Forms.ErrorProvider ErrorProviderUsername;
        private System.Windows.Forms.ErrorProvider ErrorProviderPassword;
        private System.Windows.Forms.ErrorProvider ErrorProviderFirstName;
        private System.Windows.Forms.ErrorProvider ErrorProviderLastName;
        private System.Windows.Forms.ErrorProvider ErrorProviderContact;
        private System.Windows.Forms.ErrorProvider ErrorProviderRole;
        private System.Windows.Forms.ComboBox cbRole;
    }
}