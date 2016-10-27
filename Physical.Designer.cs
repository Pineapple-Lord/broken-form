namespace WindowsFormsApplication1
{
    partial class Physical
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBack2Menu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTNRetail = new System.Windows.Forms.Button();
            this.BTNTime = new System.Windows.Forms.Button();
            this.BTNConstraints = new System.Windows.Forms.Button();
            this.BTNSummary = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physical";
            // 
            // BTNBack2Menu
            // 
            this.BTNBack2Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack2Menu.Location = new System.Drawing.Point(765, 12);
            this.BTNBack2Menu.Name = "BTNBack2Menu";
            this.BTNBack2Menu.Size = new System.Drawing.Size(173, 66);
            this.BTNBack2Menu.TabIndex = 3;
            this.BTNBack2Menu.Text = "Back To Main Menu";
            this.BTNBack2Menu.UseVisualStyleBackColor = true;
            this.BTNBack2Menu.Click += new System.EventHandler(this.BTNBack2Menu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Installers Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "##No. Installers Required##";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. available meters in stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meter manufacturer lead time for delivery of stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // BTNRetail
            // 
            this.BTNRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRetail.Location = new System.Drawing.Point(765, 96);
            this.BTNRetail.Name = "BTNRetail";
            this.BTNRetail.Size = new System.Drawing.Size(173, 65);
            this.BTNRetail.TabIndex = 6;
            this.BTNRetail.Text = "Retailer Information";
            this.BTNRetail.UseVisualStyleBackColor = true;
            this.BTNRetail.Click += new System.EventHandler(this.BTNRetail_Click);
            // 
            // BTNTime
            // 
            this.BTNTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTime.Location = new System.Drawing.Point(765, 179);
            this.BTNTime.Name = "BTNTime";
            this.BTNTime.Size = new System.Drawing.Size(173, 65);
            this.BTNTime.TabIndex = 7;
            this.BTNTime.Text = "Time";
            this.BTNTime.UseVisualStyleBackColor = true;
            this.BTNTime.Click += new System.EventHandler(this.BTNTime_Click);
            // 
            // BTNConstraints
            // 
            this.BTNConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConstraints.Location = new System.Drawing.Point(765, 264);
            this.BTNConstraints.Name = "BTNConstraints";
            this.BTNConstraints.Size = new System.Drawing.Size(173, 69);
            this.BTNConstraints.TabIndex = 8;
            this.BTNConstraints.Text = "Constraints";
            this.BTNConstraints.UseVisualStyleBackColor = true;
            this.BTNConstraints.Click += new System.EventHandler(this.BTNConstraints_Click);
            // 
            // BTNSummary
            // 
            this.BTNSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSummary.Location = new System.Drawing.Point(765, 352);
            this.BTNSummary.Name = "BTNSummary";
            this.BTNSummary.Size = new System.Drawing.Size(173, 66);
            this.BTNSummary.TabIndex = 13;
            this.BTNSummary.Text = "Summary";
            this.BTNSummary.UseVisualStyleBackColor = true;
            this.BTNSummary.Click += new System.EventHandler(this.BTNSummary_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(-1, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(951, 98);
            this.label6.TabIndex = 14;
            // 
            // BTNSave
            // 
            this.BTNSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSave.Location = new System.Drawing.Point(507, 352);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(97, 44);
            this.BTNSave.TabIndex = 15;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // Physical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(950, 436);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNSummary);
            this.Controls.Add(this.BTNConstraints);
            this.Controls.Add(this.BTNTime);
            this.Controls.Add(this.BTNRetail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNBack2Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Physical";
            this.Text = "Physical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBack2Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTNRetail;
        private System.Windows.Forms.Button BTNTime;
        private System.Windows.Forms.Button BTNConstraints;
        private System.Windows.Forms.Button BTNSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNSave;
    }
}