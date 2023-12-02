namespace Modual_5
{
    partial class Program5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program5));
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.picGreatPumpkin = new System.Windows.Forms.PictureBox();
            this.picPatch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreatPumpkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatch)).BeginInit();
            this.SuspendLayout();
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(72, 338);
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(120, 31);
            this.numDistance.TabIndex = 0;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(198, 375);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(31, 140);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(35, 375);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 140);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(72, 375);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 41);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(72, 474);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 41);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // picGreatPumpkin
            // 
            this.picGreatPumpkin.Image = ((System.Drawing.Image)(resources.GetObject("picGreatPumpkin.Image")));
            this.picGreatPumpkin.Location = new System.Drawing.Point(170, 163);
            this.picGreatPumpkin.Name = "picGreatPumpkin";
            this.picGreatPumpkin.Size = new System.Drawing.Size(99, 93);
            this.picGreatPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreatPumpkin.TabIndex = 5;
            this.picGreatPumpkin.TabStop = false;
            this.picGreatPumpkin.Click += new System.EventHandler(this.picGreatPumpkin_Click);
            // 
            // picPatch
            // 
            this.picPatch.Image = ((System.Drawing.Image)(resources.GetObject("picPatch.Image")));
            this.picPatch.Location = new System.Drawing.Point(458, 152);
            this.picPatch.Name = "picPatch";
            this.picPatch.Size = new System.Drawing.Size(279, 206);
            this.picPatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPatch.TabIndex = 6;
            this.picPatch.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Great Pumpkin";
            // 
            // Program5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(888, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPatch);
            this.Controls.Add(this.picGreatPumpkin);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.numDistance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Program5";
            this.Text = "Great Pumpkin";
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreatPumpkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PictureBox picGreatPumpkin;
        private System.Windows.Forms.PictureBox picPatch;
        private System.Windows.Forms.Label label1;
    }
}

