
namespace scicalculator
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bx = new System.Windows.Forms.RadioButton();
            this.bj = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wb1 = new System.Windows.Forms.RichTextBox();
            this.wb2 = new System.Windows.Forms.RichTextBox();
            this.wb3 = new System.Windows.Forms.RichTextBox();
            this.wb4 = new System.Windows.Forms.RichTextBox();
            this.wb5 = new System.Windows.Forms.RichTextBox();
            this.wb6 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "还款方式：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(400, 117);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "贷款年限（年）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "贷款金额（万元）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(68, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "贷款月利率（%）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(68, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "月均还款（元）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(68, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "利息总额（元）：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(68, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "还款总额（元）：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bx
            // 
            this.bx.AutoSize = true;
            this.bx.Checked = true;
            this.bx.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bx.Location = new System.Drawing.Point(239, 37);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(102, 24);
            this.bx.TabIndex = 9;
            this.bx.TabStop = true;
            this.bx.Text = "等额本息";
            this.bx.UseVisualStyleBackColor = true;
            this.bx.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bj
            // 
            this.bj.AutoSize = true;
            this.bj.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bj.Location = new System.Drawing.Point(434, 39);
            this.bj.Name = "bj";
            this.bj.Size = new System.Drawing.Size(102, 24);
            this.bj.TabIndex = 10;
            this.bj.Text = "等额本金";
            this.bj.UseVisualStyleBackColor = true;
            this.bj.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(253, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(400, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "重新计算";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wb1
            // 
            this.wb1.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb1.Location = new System.Drawing.Point(253, 98);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(262, 33);
            this.wb1.TabIndex = 13;
            this.wb1.Text = "";
            this.wb1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // wb2
            // 
            this.wb2.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb2.Location = new System.Drawing.Point(253, 159);
            this.wb2.Name = "wb2";
            this.wb2.Size = new System.Drawing.Size(262, 33);
            this.wb2.TabIndex = 14;
            this.wb2.Text = "";
            this.wb2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // wb3
            // 
            this.wb3.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb3.Location = new System.Drawing.Point(253, 219);
            this.wb3.Name = "wb3";
            this.wb3.Size = new System.Drawing.Size(262, 33);
            this.wb3.TabIndex = 15;
            this.wb3.Text = "";
            this.wb3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // wb4
            // 
            this.wb4.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb4.Location = new System.Drawing.Point(253, 343);
            this.wb4.Name = "wb4";
            this.wb4.Size = new System.Drawing.Size(262, 33);
            this.wb4.TabIndex = 16;
            this.wb4.Text = "";
            this.wb4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // wb5
            // 
            this.wb5.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb5.Location = new System.Drawing.Point(255, 407);
            this.wb5.Name = "wb5";
            this.wb5.Size = new System.Drawing.Size(260, 33);
            this.wb5.TabIndex = 17;
            this.wb5.Text = "";
            this.wb5.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // wb6
            // 
            this.wb6.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wb6.Location = new System.Drawing.Point(253, 472);
            this.wb6.Name = "wb6";
            this.wb6.Size = new System.Drawing.Size(262, 33);
            this.wb6.TabIndex = 18;
            this.wb6.Text = "";
            this.wb6.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 548);
            this.Controls.Add(this.wb6);
            this.Controls.Add(this.wb5);
            this.Controls.Add(this.wb4);
            this.Controls.Add(this.wb3);
            this.Controls.Add(this.wb2);
            this.Controls.Add(this.wb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bj);
            this.Controls.Add(this.bx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "LoanCalculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton bx;
        private System.Windows.Forms.RadioButton bj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox wb1;
        private System.Windows.Forms.RichTextBox wb2;
        private System.Windows.Forms.RichTextBox wb3;
        private System.Windows.Forms.RichTextBox wb4;
        private System.Windows.Forms.RichTextBox wb5;
        private System.Windows.Forms.RichTextBox wb6;
    }
}