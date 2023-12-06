namespace MyFinalProject
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
            System.Windows.Forms.Label ticket_IDLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label requesterLabel;
            System.Windows.Forms.Label assigned_ToLabel;
            System.Windows.Forms.Label creation_DateLabel;
            System.Windows.Forms.Label priorityLabel;
            this.ticket_IDTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.requesterTextBox = new System.Windows.Forms.TextBox();
            this.assigned_ToTextBox = new System.Windows.Forms.TextBox();
            this.creation_DateTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsDataSet = new MyFinalProject.TicketsDataSet();
            this.tblTicketsTableAdapter = new MyFinalProject.TicketsDataSetTableAdapters.tblTicketsTableAdapter();
            this.tableAdapterManager = new MyFinalProject.TicketsDataSetTableAdapters.TableAdapterManager();
            this.btnSave = new System.Windows.Forms.Button();
            ticket_IDLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            requesterLabel = new System.Windows.Forms.Label();
            assigned_ToLabel = new System.Windows.Forms.Label();
            creation_DateLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ticket_IDLabel
            // 
            ticket_IDLabel.AutoSize = true;
            ticket_IDLabel.Location = new System.Drawing.Point(57, 68);
            ticket_IDLabel.Name = "ticket_IDLabel";
            ticket_IDLabel.Size = new System.Drawing.Size(87, 24);
            ticket_IDLabel.TabIndex = 3;
            ticket_IDLabel.Text = "Ticket ID:";
            ticket_IDLabel.Click += new System.EventHandler(this.ticket_IDLabel_Click);
            // 
            // ticket_IDTextBox
            // 
            this.ticket_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Ticket ID", true));
            this.ticket_IDTextBox.Location = new System.Drawing.Point(150, 65);
            this.ticket_IDTextBox.MaxLength = 50;
            this.ticket_IDTextBox.Name = "ticket_IDTextBox";
            this.ticket_IDTextBox.Size = new System.Drawing.Size(97, 29);
            this.ticket_IDTextBox.TabIndex = 4;
            this.ticket_IDTextBox.TextChanged += new System.EventHandler(this.ticket_IDTextBox_TextChanged);
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(66, 103);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(78, 24);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(150, 100);
            this.subjectTextBox.MaxLength = 150;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(431, 29);
            this.subjectTextBox.TabIndex = 6;
            // 
            // requesterLabel
            // 
            requesterLabel.AutoSize = true;
            requesterLabel.Location = new System.Drawing.Point(42, 138);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new System.Drawing.Size(102, 24);
            requesterLabel.TabIndex = 7;
            requesterLabel.Text = "Requester:";
            // 
            // requesterTextBox
            // 
            this.requesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Requester", true));
            this.requesterTextBox.Location = new System.Drawing.Point(150, 135);
            this.requesterTextBox.MaxLength = 50;
            this.requesterTextBox.Name = "requesterTextBox";
            this.requesterTextBox.Size = new System.Drawing.Size(229, 29);
            this.requesterTextBox.TabIndex = 8;
            // 
            // assigned_ToLabel
            // 
            assigned_ToLabel.AutoSize = true;
            assigned_ToLabel.Location = new System.Drawing.Point(22, 173);
            assigned_ToLabel.Name = "assigned_ToLabel";
            assigned_ToLabel.Size = new System.Drawing.Size(122, 24);
            assigned_ToLabel.TabIndex = 9;
            assigned_ToLabel.Text = "Assigned To:";
            // 
            // assigned_ToTextBox
            // 
            this.assigned_ToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Assigned To", true));
            this.assigned_ToTextBox.Location = new System.Drawing.Point(150, 170);
            this.assigned_ToTextBox.Name = "assigned_ToTextBox";
            this.assigned_ToTextBox.Size = new System.Drawing.Size(229, 29);
            this.assigned_ToTextBox.TabIndex = 10;
            // 
            // creation_DateLabel
            // 
            creation_DateLabel.AutoSize = true;
            creation_DateLabel.Location = new System.Drawing.Point(16, 208);
            creation_DateLabel.Name = "creation_DateLabel";
            creation_DateLabel.Size = new System.Drawing.Size(128, 24);
            creation_DateLabel.TabIndex = 11;
            creation_DateLabel.Text = "Creation Date:";
            // 
            // creation_DateTextBox
            // 
            this.creation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Creation Date", true));
            this.creation_DateTextBox.Location = new System.Drawing.Point(150, 205);
            this.creation_DateTextBox.Name = "creation_DateTextBox";
            this.creation_DateTextBox.Size = new System.Drawing.Size(229, 29);
            this.creation_DateTextBox.TabIndex = 12;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(73, 243);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(71, 24);
            priorityLabel.TabIndex = 13;
            priorityLabel.Text = "Priority:";
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTicketsBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(150, 240);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(97, 29);
            this.priorityTextBox.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(537, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ticket Info Page";
            // 
            // tblTicketsBindingSource
            // 
            this.tblTicketsBindingSource.DataMember = "tblTickets";
            this.tblTicketsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // ticketsDataSet
            // 
            this.ticketsDataSet.DataSetName = "TicketsDataSet";
            this.ticketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(444, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 341);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(creation_DateLabel);
            this.Controls.Add(this.creation_DateTextBox);
            this.Controls.Add(assigned_ToLabel);
            this.Controls.Add(this.assigned_ToTextBox);
            this.Controls.Add(requesterLabel);
            this.Controls.Add(this.requesterTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(ticket_IDLabel);
            this.Controls.Add(this.ticket_IDTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDetails";
            this.Text = "TicketDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TicketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource tblTicketsBindingSource;
        private TicketsDataSetTableAdapters.tblTicketsTableAdapter tblTicketsTableAdapter;
        private TicketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ticket_IDTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox requesterTextBox;
        private System.Windows.Forms.TextBox assigned_ToTextBox;
        private System.Windows.Forms.TextBox creation_DateTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}