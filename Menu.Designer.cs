namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNRetail = new System.Windows.Forms.Button();
            this.BTNPhysical = new System.Windows.Forms.Button();
            this.BTNTime = new System.Windows.Forms.Button();
            this.BTNConstraints = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Desired Information Area";
            // 
            // BTNRetail
            // 
            this.BTNRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRetail.Location = new System.Drawing.Point(37, 130);
            this.BTNRetail.Name = "BTNRetail";
            this.BTNRetail.Size = new System.Drawing.Size(182, 102);
            this.BTNRetail.TabIndex = 1;
            this.BTNRetail.Text = "Retailer Information";
            this.BTNRetail.UseVisualStyleBackColor = true;
            this.BTNRetail.Click += new System.EventHandler(this.BTNRetail_Click);
            // 
            // BTNPhysical
            // 
            this.BTNPhysical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPhysical.Location = new System.Drawing.Point(37, 322);
            this.BTNPhysical.Name = "BTNPhysical";
            this.BTNPhysical.Size = new System.Drawing.Size(182, 102);
            this.BTNPhysical.TabIndex = 1;
            this.BTNPhysical.Text = "Physical";
            this.BTNPhysical.UseVisualStyleBackColor = true;
            this.BTNPhysical.Click += new System.EventHandler(this.BTNPhysical_Click);
            // 
            // BTNTime
            // 
            this.BTNTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTime.Location = new System.Drawing.Point(734, 130);
            this.BTNTime.Name = "BTNTime";
            this.BTNTime.Size = new System.Drawing.Size(182, 102);
            this.BTNTime.TabIndex = 1;
            this.BTNTime.Text = "Time";
            this.BTNTime.UseVisualStyleBackColor = true;
            this.BTNTime.Click += new System.EventHandler(this.BTNTime_Click);
            // 
            // BTNConstraints
            // 
            this.BTNConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConstraints.Location = new System.Drawing.Point(734, 322);
            this.BTNConstraints.Name = "BTNConstraints";
            this.BTNConstraints.Size = new System.Drawing.Size(182, 102);
            this.BTNConstraints.TabIndex = 1;
            this.BTNConstraints.Text = "Constraints";
            this.BTNConstraints.UseVisualStyleBackColor = true;
            this.BTNConstraints.Click += new System.EventHandler(this.BTNConstraints_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 138);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(951, 98);
            this.label2.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(952, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNConstraints);
            this.Controls.Add(this.BTNPhysical);
            this.Controls.Add(this.BTNTime);
            this.Controls.Add(this.BTNRetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNRetail;
        private System.Windows.Forms.Button BTNPhysical;
        private System.Windows.Forms.Button BTNTime;
        private System.Windows.Forms.Button BTNConstraints;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

