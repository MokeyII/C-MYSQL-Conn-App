namespace First_cSharp_SQL_APP
{
    partial class Form2
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
            this.GUID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GUID_txt = new System.Windows.Forms.TextBox();
            this.Ban_txt = new System.Windows.Forms.TextBox();
            this.Reason_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GUID
            // 
            this.GUID.AutoSize = true;
            this.GUID.Location = new System.Drawing.Point(28, 15);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(34, 13);
            this.GUID.TabIndex = 0;
            this.GUID.Text = "GUID";
            this.GUID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ban Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reason";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proof";
            // 
            // GUID_txt
            // 
            this.GUID_txt.Location = new System.Drawing.Point(68, 12);
            this.GUID_txt.Name = "GUID_txt";
            this.GUID_txt.Size = new System.Drawing.Size(250, 20);
            this.GUID_txt.TabIndex = 4;
            this.GUID_txt.TextChanged += new System.EventHandler(this.GUID_txt_TextChanged);
            // 
            // Ban_txt
            // 
            this.Ban_txt.Location = new System.Drawing.Point(68, 52);
            this.Ban_txt.Name = "Ban_txt";
            this.Ban_txt.Size = new System.Drawing.Size(44, 20);
            this.Ban_txt.TabIndex = 5;
            // 
            // Reason_txt
            // 
            this.Reason_txt.Location = new System.Drawing.Point(68, 87);
            this.Reason_txt.Name = "Reason_txt";
            this.Reason_txt.Size = new System.Drawing.Size(326, 20);
            this.Reason_txt.TabIndex = 6;
            this.Reason_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "-1 = Permanant Ban (all bans should fall under this category)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 162);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "For the Reason Please Add \"Appeal @ www.yoursitehere.com\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reason_txt);
            this.Controls.Add(this.Ban_txt);
            this.Controls.Add(this.GUID_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GUID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GUID_txt;
        private System.Windows.Forms.TextBox Ban_txt;
        private System.Windows.Forms.TextBox Reason_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}