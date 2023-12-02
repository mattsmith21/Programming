namespace Program_9
{
    partial class frmDetails
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            this.lastNameTextBox1 = new System.Windows.Forms.TextBox();
            this.firstNameTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.streetTextBox1 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.stateTextBox1 = new System.Windows.Forms.TextBox();
            this.zipTextBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblContactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataSet1 = new Program_9.contactsDataSet();
            this.tblContactsTableAdapter1 = new Program_9.contactsDataSetTableAdapters.tblContactsTableAdapter();
            this.tableAdapterManager1 = new Program_9.contactsDataSetTableAdapters.TableAdapterManager();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(78, 106);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 24);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(76, 141);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(106, 24);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(120, 176);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 24);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(119, 215);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(63, 24);
            streetLabel.TabIndex = 7;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(137, 255);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(45, 24);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(126, 293);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(56, 24);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(140, 333);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(42, 24);
            zipLabel.TabIndex = 13;
            zipLabel.Text = "Zip:";
            // 
            // lastNameTextBox1
            // 
            this.lastNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "LastName", true));
            this.lastNameTextBox1.Location = new System.Drawing.Point(188, 103);
            this.lastNameTextBox1.Name = "lastNameTextBox1";
            this.lastNameTextBox1.Size = new System.Drawing.Size(251, 29);
            this.lastNameTextBox1.TabIndex = 2;
            // 
            // firstNameTextBox1
            // 
            this.firstNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "FirstName", true));
            this.firstNameTextBox1.Location = new System.Drawing.Point(188, 138);
            this.firstNameTextBox1.Name = "firstNameTextBox1";
            this.firstNameTextBox1.Size = new System.Drawing.Size(251, 29);
            this.firstNameTextBox1.TabIndex = 4;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(188, 173);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(258, 29);
            this.emailTextBox1.TabIndex = 6;
            // 
            // streetTextBox1
            // 
            this.streetTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "Street", true));
            this.streetTextBox1.Location = new System.Drawing.Point(188, 212);
            this.streetTextBox1.Name = "streetTextBox1";
            this.streetTextBox1.Size = new System.Drawing.Size(251, 29);
            this.streetTextBox1.TabIndex = 8;
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "City", true));
            this.cityTextBox1.Location = new System.Drawing.Point(188, 252);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(238, 29);
            this.cityTextBox1.TabIndex = 10;
            // 
            // stateTextBox1
            // 
            this.stateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "State", true));
            this.stateTextBox1.Location = new System.Drawing.Point(188, 290);
            this.stateTextBox1.Name = "stateTextBox1";
            this.stateTextBox1.Size = new System.Drawing.Size(227, 29);
            this.stateTextBox1.TabIndex = 12;
            // 
            // zipTextBox1
            // 
            this.zipTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource1, "Zip", true));
            this.zipTextBox1.Location = new System.Drawing.Point(188, 330);
            this.zipTextBox1.Name = "zipTextBox1";
            this.zipTextBox1.Size = new System.Drawing.Size(113, 29);
            this.zipTextBox1.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 42);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblContactsBindingSource1
            // 
            this.tblContactsBindingSource1.DataMember = "tblContacts";
            this.tblContactsBindingSource1.DataSource = this.contactsDataSet1;
            // 
            // contactsDataSet1
            // 
            this.contactsDataSet1.DataSetName = "contactsDataSet";
            this.contactsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblContactsTableAdapter1
            // 
            this.tblContactsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Program_9.contactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDetails
            // 
            this.ClientSize = new System.Drawing.Size(655, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox1);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox1);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox1);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private contactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource tblContactsBindingSource;
        private contactsDataSetTableAdapters.tblContactsTableAdapter tblContactsTableAdapter;
        private contactsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblContactsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblContactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private contactsDataSet contactsDataSet1;
        private System.Windows.Forms.BindingSource tblContactsBindingSource1;
        private contactsDataSetTableAdapters.tblContactsTableAdapter tblContactsTableAdapter1;
        private contactsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox lastNameTextBox1;
        private System.Windows.Forms.TextBox firstNameTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox streetTextBox1;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.TextBox stateTextBox1;
        private System.Windows.Forms.TextBox zipTextBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}