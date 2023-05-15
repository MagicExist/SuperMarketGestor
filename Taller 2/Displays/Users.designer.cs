namespace SingIn.Displays
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUserCreator = new System.Windows.Forms.Button();
            this.cbBoxRolOptions = new System.Windows.Forms.ComboBox();
            this.txtBoxPasswordCreator = new System.Windows.Forms.TextBox();
            this.txtBoxUserNameCreator = new System.Windows.Forms.TextBox();
            this.dgvUsersData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInventario = new System.Windows.Forms.Button();
            this.cbBoxBranch = new System.Windows.Forms.ComboBox();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserCreator
            // 
            this.btnUserCreator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserCreator.Location = new System.Drawing.Point(243, 78);
            this.btnUserCreator.Name = "btnUserCreator";
            this.btnUserCreator.Size = new System.Drawing.Size(127, 40);
            this.btnUserCreator.TabIndex = 18;
            this.btnUserCreator.Text = "Add User";
            this.btnUserCreator.UseVisualStyleBackColor = true;
            this.btnUserCreator.Click += new System.EventHandler(this.btnUserCreator_Click);
            // 
            // cbBoxRolOptions
            // 
            this.cbBoxRolOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxRolOptions.FormattingEnabled = true;
            this.cbBoxRolOptions.Items.AddRange(new object[] {
            "Cajero"});
            this.cbBoxRolOptions.Location = new System.Drawing.Point(433, 36);
            this.cbBoxRolOptions.Name = "cbBoxRolOptions";
            this.cbBoxRolOptions.Size = new System.Drawing.Size(121, 33);
            this.cbBoxRolOptions.TabIndex = 17;
            this.cbBoxRolOptions.Text = "Rol";
            // 
            // txtBoxPasswordCreator
            // 
            this.txtBoxPasswordCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPasswordCreator.Location = new System.Drawing.Point(36, 116);
            this.txtBoxPasswordCreator.Name = "txtBoxPasswordCreator";
            this.txtBoxPasswordCreator.Size = new System.Drawing.Size(161, 31);
            this.txtBoxPasswordCreator.TabIndex = 16;
            this.txtBoxPasswordCreator.Text = "Password";
            // 
            // txtBoxUserNameCreator
            // 
            this.txtBoxUserNameCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserNameCreator.Location = new System.Drawing.Point(36, 36);
            this.txtBoxUserNameCreator.Name = "txtBoxUserNameCreator";
            this.txtBoxUserNameCreator.Size = new System.Drawing.Size(161, 31);
            this.txtBoxUserNameCreator.TabIndex = 15;
            this.txtBoxUserNameCreator.Text = "UserName";
            // 
            // dgvUsersData
            // 
            this.dgvUsersData.AllowUserToAddRows = false;
            this.dgvUsersData.AutoGenerateColumns = false;
            this.dgvUsersData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.Branch,
            this.Delete});
            this.dgvUsersData.DataSource = this.userBindingSource;
            this.dgvUsersData.Location = new System.Drawing.Point(23, 316);
            this.dgvUsersData.Name = "dgvUsersData";
            this.dgvUsersData.Size = new System.Drawing.Size(547, 150);
            this.dgvUsersData.TabIndex = 19;
            this.dgvUsersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersData_CellContentClick);
            this.dgvUsersData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersData_CellValueChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.userNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.passwordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.rolDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // Branch
            // 
            this.Branch.DataPropertyName = "Branch";
            this.Branch.DataSource = this.userBindingSource;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Branch.DefaultCellStyle = dataGridViewCellStyle5;
            this.Branch.DisplayMember = "Branch";
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ClassUser.User);
            // 
            // Delete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnInventario
            // 
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInventario.Location = new System.Drawing.Point(12, 625);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(109, 23);
            this.btnInventario.TabIndex = 20;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // cbBoxBranch
            // 
            this.cbBoxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxBranch.FormattingEnabled = true;
            this.cbBoxBranch.Items.AddRange(new object[] {
            "Sucursal 1",
            "Sucursal 2",
            "Sucursal 3"});
            this.cbBoxBranch.Location = new System.Drawing.Point(433, 116);
            this.cbBoxBranch.Name = "cbBoxBranch";
            this.cbBoxBranch.Size = new System.Drawing.Size(121, 33);
            this.cbBoxBranch.TabIndex = 21;
            this.cbBoxBranch.Text = "Branch";
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(ClassUser.User);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(590, 660);
            this.Controls.Add(this.cbBoxBranch);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.dgvUsersData);
            this.Controls.Add(this.btnUserCreator);
            this.Controls.Add(this.cbBoxRolOptions);
            this.Controls.Add(this.txtBoxPasswordCreator);
            this.Controls.Add(this.txtBoxUserNameCreator);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUserCreator;
        private System.Windows.Forms.ComboBox cbBoxRolOptions;
        private System.Windows.Forms.TextBox txtBoxPasswordCreator;
        private System.Windows.Forms.TextBox txtBoxUserNameCreator;
        private System.Windows.Forms.DataGridView dgvUsersData;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.ComboBox cbBoxBranch;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Branch;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}