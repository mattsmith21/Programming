namespace Modual_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAve = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 25;
            this.lstStudents.Items.AddRange(new object[] {
            "Charlie Brown",
            "Lucy VanPelt",
            "Linus VanPelt",
            "Joe Cool"});
            this.lstStudents.Location = new System.Drawing.Point(39, 76);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(358, 279);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.DoubleClick += new System.EventHandler(this.lstStudents_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(163, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(288, 381);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(109, 34);
            this.btnDlt.TabIndex = 3;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miss Othmars\'s Class";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblAve);
            this.panel1.Controls.Add(this.lblHigh);
            this.panel1.Controls.Add(this.lblLow);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(434, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 161);
            this.panel1.TabIndex = 6;
            // 
            // lblAve
            // 
            this.lblAve.AutoSize = true;
            this.lblAve.Location = new System.Drawing.Point(194, 113);
            this.lblAve.Name = "lblAve";
            this.lblAve.Size = new System.Drawing.Size(18, 25);
            this.lblAve.TabIndex = 6;
            this.lblAve.Text = " ";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(194, 32);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(18, 25);
            this.lblHigh.TabIndex = 5;
            this.lblHigh.Text = " ";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(194, 75);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(18, 25);
            this.lblLow.TabIndex = 4;
            this.lblLow.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lowest Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Average Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highest Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class Info";
            // 
            // grpStudent
            // 
            this.grpStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpStudent.Controls.Add(this.txtStudent);
            this.grpStudent.Controls.Add(this.numScore);
            this.grpStudent.Controls.Add(this.btnCancel);
            this.grpStudent.Controls.Add(this.btnUpdate);
            this.grpStudent.Controls.Add(this.label7);
            this.grpStudent.Controls.Add(this.label6);
            this.grpStudent.Location = new System.Drawing.Point(461, 261);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(356, 154);
            this.grpStudent.TabIndex = 7;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Infomation";
            this.grpStudent.Visible = false;
            this.grpStudent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(187, 24);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(163, 31);
            this.txtStudent.TabIndex = 6;
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(187, 61);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(163, 31);
            this.numScore.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(52, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Percent Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstStudents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Class Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAve;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudent;
    }
}

