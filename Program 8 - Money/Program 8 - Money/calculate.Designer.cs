namespace Program_8___Money
{
    partial class calculate
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
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPayPerYr = new System.Windows.Forms.TextBox();
            this.txtHoursPerYr = new System.Windows.Forms.TextBox();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 20;
            this.lstEmployees.Location = new System.Drawing.Point(12, 12);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(303, 304);
            this.lstEmployees.TabIndex = 0;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDetails.Controls.Add(this.buttonCancel);
            this.grpDetails.Controls.Add(this.btnUpdate);
            this.grpDetails.Controls.Add(this.txtPayPerYr);
            this.grpDetails.Controls.Add(this.txtHoursPerYr);
            this.grpDetails.Controls.Add(this.numHours);
            this.grpDetails.Controls.Add(this.numRate);
            this.grpDetails.Controls.Add(this.txtFirst);
            this.grpDetails.Controls.Add(this.txtLast);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(332, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(499, 359);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Employee Details";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(348, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 33);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(224, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPayPerYr
            // 
            this.txtPayPerYr.Location = new System.Drawing.Point(208, 279);
            this.txtPayPerYr.Name = "txtPayPerYr";
            this.txtPayPerYr.ReadOnly = true;
            this.txtPayPerYr.Size = new System.Drawing.Size(276, 26);
            this.txtPayPerYr.TabIndex = 11;
            // 
            // txtHoursPerYr
            // 
            this.txtHoursPerYr.Location = new System.Drawing.Point(208, 227);
            this.txtHoursPerYr.Name = "txtHoursPerYr";
            this.txtHoursPerYr.ReadOnly = true;
            this.txtHoursPerYr.Size = new System.Drawing.Size(276, 26);
            this.txtHoursPerYr.TabIndex = 10;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(208, 172);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(276, 26);
            this.numHours.TabIndex = 9;
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(209, 122);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(276, 26);
            this.numRate.TabIndex = 8;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(208, 78);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(276, 26);
            this.txtFirst.TabIndex = 7;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(208, 31);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(276, 26);
            this.txtLast.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Annual Pay (Gross):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hours Per Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours Per Week:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "last name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 388);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "calculate";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculate_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayPerYr;
        private System.Windows.Forms.TextBox txtHoursPerYr;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button buttonCancel;
    }
}

