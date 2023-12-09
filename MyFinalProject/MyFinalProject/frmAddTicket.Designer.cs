namespace MyFinalProject
{
    partial class frmAddTicket
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
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label creation_DateLabel;
            System.Windows.Forms.Label assigned_ToLabel;
            System.Windows.Forms.Label requesterLabel;
            System.Windows.Forms.Label subjectLabel;
            this.btnAddTic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.assigned_ToTextBox = new System.Windows.Forms.TextBox();
            this.requesterTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.ticketsDataSet = new MyFinalProject.TicketsDataSet();
            this.tblTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTicketsTableAdapter = new MyFinalProject.TicketsDataSetTableAdapters.tblTicketsTableAdapter();
            this.tableAdapterManager = new MyFinalProject.TicketsDataSetTableAdapters.TableAdapterManager();
            this.creation_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            priorityLabel = new System.Windows.Forms.Label();
            creation_DateLabel = new System.Windows.Forms.Label();
            assigned_ToLabel = new System.Windows.Forms.Label();
            requesterLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(72, 255);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(85, 25);
            priorityLabel.TabIndex = 28;
            priorityLabel.Text = "Priority:";
            // 
            // creation_DateLabel
            // 
            creation_DateLabel.AutoSize = true;
            creation_DateLabel.Location = new System.Drawing.Point(15, 220);
            creation_DateLabel.Name = "creation_DateLabel";
            creation_DateLabel.Size = new System.Drawing.Size(150, 25);
            creation_DateLabel.TabIndex = 26;
            creation_DateLabel.Text = "Creation Date:";
            // 
            // assigned_ToLabel
            // 
            assigned_ToLabel.AutoSize = true;
            assigned_ToLabel.Location = new System.Drawing.Point(21, 185);
            assigned_ToLabel.Name = "assigned_ToLabel";
            assigned_ToLabel.Size = new System.Drawing.Size(138, 25);
            assigned_ToLabel.TabIndex = 24;
            assigned_ToLabel.Text = "Assigned To:";
            // 
            // requesterLabel
            // 
            requesterLabel.AutoSize = true;
            requesterLabel.Location = new System.Drawing.Point(41, 150);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new System.Drawing.Size(117, 25);
            requesterLabel.TabIndex = 22;
            requesterLabel.Text = "Requester:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(65, 115);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(90, 25);
            subjectLabel.TabIndex = 20;
            subjectLabel.Text = "Subject:";
            // 
            // btnAddTic
            // 
            this.btnAddTic.Location = new System.Drawing.Point(438, 318);
            this.btnAddTic.Name = "btnAddTic";
            this.btnAddTic.Size = new System.Drawing.Size(87, 35);
            this.btnAddTic.TabIndex = 32;
            this.btnAddTic.Text = "Add";
            this.btnAddTic.UseVisualStyleBackColor = true;
            this.btnAddTic.Click += new System.EventHandler(this.btnAddTic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add Ticket Page";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(531, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(164, 252);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(97, 31);
            this.priorityTextBox.TabIndex = 29;
            // 
            // assigned_ToTextBox
            // 
            this.assigned_ToTextBox.Location = new System.Drawing.Point(164, 182);
            this.assigned_ToTextBox.Name = "assigned_ToTextBox";
            this.assigned_ToTextBox.Size = new System.Drawing.Size(229, 31);
            this.assigned_ToTextBox.TabIndex = 25;
            // 
            // requesterTextBox
            // 
            this.requesterTextBox.Location = new System.Drawing.Point(164, 147);
            this.requesterTextBox.MaxLength = 50;
            this.requesterTextBox.Name = "requesterTextBox";
            this.requesterTextBox.Size = new System.Drawing.Size(229, 31);
            this.requesterTextBox.TabIndex = 23;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(164, 112);
            this.subjectTextBox.MaxLength = 150;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(431, 31);
            this.subjectTextBox.TabIndex = 21;
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
            // creation_DateDateTimePicker
            // 
            this.creation_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblTicketsBindingSource, "Creation Date", true));
            this.creation_DateDateTimePicker.Location = new System.Drawing.Point(164, 220);
            this.creation_DateDateTimePicker.Name = "creation_DateDateTimePicker";
            this.creation_DateDateTimePicker.Size = new System.Drawing.Size(431, 31);
            this.creation_DateDateTimePicker.TabIndex = 34;
            this.creation_DateDateTimePicker.ValueChanged += new System.EventHandler(this.creation_DateDateTimePicker_ValueChanged);
            // 
            // frmAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 373);
            this.Controls.Add(this.creation_DateDateTimePicker);
            this.Controls.Add(this.btnAddTic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(creation_DateLabel);
            this.Controls.Add(assigned_ToLabel);
            this.Controls.Add(this.assigned_ToTextBox);
            this.Controls.Add(requesterLabel);
            this.Controls.Add(this.requesterTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddTicket";
            this.Text = "frmAddTicket";
            this.Load += new System.EventHandler(this.frmAddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTicketsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox assigned_ToTextBox;
        private System.Windows.Forms.TextBox requesterTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private TicketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource tblTicketsBindingSource;
        private TicketsDataSetTableAdapters.tblTicketsTableAdapter tblTicketsTableAdapter;
        private TicketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker creation_DateDateTimePicker;
    }
}