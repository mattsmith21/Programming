namespace MyFinalProject
{
    partial class frmDetail
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label requesterLabel;
            System.Windows.Forms.Label assigned_ToLabel;
            System.Windows.Forms.Label creation_DateLabel;
            System.Windows.Forms.Label priorityLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ticketsDataSet = new MyFinalProject.TicketsDataSet();
            this.tblTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTicketsTableAdapter = new MyFinalProject.TicketsDataSetTableAdapters.tblTicketsTableAdapter();
            this.tableAdapterManager = new MyFinalProject.TicketsDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.requesterTextBox = new System.Windows.Forms.TextBox();
            this.assigned_ToTextBox = new System.Windows.Forms.TextBox();
            this.creation_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            requesterLabel = new System.Windows.Forms.Label();
            assigned_ToLabel = new System.Windows.Forms.Label();
            creation_DateLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(130, 79);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 31;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(75, 116);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(90, 25);
            subjectLabel.TabIndex = 32;
            subjectLabel.Text = "Subject:";
            // 
            // requesterLabel
            // 
            requesterLabel.AutoSize = true;
            requesterLabel.Location = new System.Drawing.Point(48, 153);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new System.Drawing.Size(117, 25);
            requesterLabel.TabIndex = 33;
            requesterLabel.Text = "Requester:";
            // 
            // assigned_ToLabel
            // 
            assigned_ToLabel.AutoSize = true;
            assigned_ToLabel.Location = new System.Drawing.Point(27, 190);
            assigned_ToLabel.Name = "assigned_ToLabel";
            assigned_ToLabel.Size = new System.Drawing.Size(138, 25);
            assigned_ToLabel.TabIndex = 34;
            assigned_ToLabel.Text = "Assigned To:";
            // 
            // creation_DateLabel
            // 
            creation_DateLabel.AutoSize = true;
            creation_DateLabel.Location = new System.Drawing.Point(15, 228);
            creation_DateLabel.Name = "creation_DateLabel";
            creation_DateLabel.Size = new System.Drawing.Size(150, 25);
            creation_DateLabel.TabIndex = 35;
            creation_DateLabel.Text = "Creation Date:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(80, 264);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(85, 25);
            priorityLabel.TabIndex = 36;
            priorityLabel.Text = "Priority:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(465, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ticket Info Page";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(558, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 35);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ticketsDataSet
            // 
            this.ticketsDataSet.DataSetName = "TicketsDataSet";
            this.ticketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTicketsBindingSource
            // 
            this.tblTicketsBindingSource.DataMember = "tblTickets";
            this.tblTicketsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // tblTicketsTableAdapter
            // 
            this.tblTicketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblTicketsTableAdapter = this.tblTicketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyFinalProject.TicketsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(171, 76);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 31);
            this.idTextBox.TabIndex = 32;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(171, 113);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(381, 31);
            this.subjectTextBox.TabIndex = 33;
            // 
            // requesterTextBox
            // 
            this.requesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Requester", true));
            this.requesterTextBox.Location = new System.Drawing.Point(171, 150);
            this.requesterTextBox.Name = "requesterTextBox";
            this.requesterTextBox.Size = new System.Drawing.Size(381, 31);
            this.requesterTextBox.TabIndex = 34;
            // 
            // assigned_ToTextBox
            // 
            this.assigned_ToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Assigned To", true));
            this.assigned_ToTextBox.Location = new System.Drawing.Point(171, 187);
            this.assigned_ToTextBox.Name = "assigned_ToTextBox";
            this.assigned_ToTextBox.Size = new System.Drawing.Size(381, 31);
            this.assigned_ToTextBox.TabIndex = 35;
            // 
            // creation_DateDateTimePicker
            // 
            this.creation_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblTicketsBindingSource, "Creation Date", true));
            this.creation_DateDateTimePicker.Location = new System.Drawing.Point(171, 224);
            this.creation_DateDateTimePicker.Name = "creation_DateDateTimePicker";
            this.creation_DateDateTimePicker.Size = new System.Drawing.Size(381, 31);
            this.creation_DateDateTimePicker.TabIndex = 36;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(171, 261);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 31);
            this.priorityTextBox.TabIndex = 37;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(creation_DateLabel);
            this.Controls.Add(this.creation_DateDateTimePicker);
            this.Controls.Add(assigned_ToLabel);
            this.Controls.Add(this.assigned_ToTextBox);
            this.Controls.Add(requesterLabel);
            this.Controls.Add(this.requesterTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDetail";
            this.Text = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private TicketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource tblTicketsBindingSource;
        private TicketsDataSetTableAdapters.tblTicketsTableAdapter tblTicketsTableAdapter;
        private TicketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox requesterTextBox;
        private System.Windows.Forms.TextBox assigned_ToTextBox;
        private System.Windows.Forms.DateTimePicker creation_DateDateTimePicker;
        private System.Windows.Forms.TextBox priorityTextBox;
    }
}