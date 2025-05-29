namespace Test1.Solution
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoSchoolGroup = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGroupSize = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupSize = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZOO ENTRY DISCOUNT FOR GROUPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Groups - $5.00 per person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tours Groups - $10.00 per person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Group Type";
            // 
            // rdoSchoolGroup
            // 
            this.rdoSchoolGroup.AutoSize = true;
            this.rdoSchoolGroup.Location = new System.Drawing.Point(56, 158);
            this.rdoSchoolGroup.Name = "rdoSchoolGroup";
            this.rdoSchoolGroup.Size = new System.Drawing.Size(97, 19);
            this.rdoSchoolGroup.TabIndex = 4;
            this.rdoSchoolGroup.TabStop = true;
            this.rdoSchoolGroup.Text = "School Group";
            this.rdoSchoolGroup.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(56, 183);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tour Group";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Name of group";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(165, 220);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 23);
            this.txtGroupName.TabIndex = 7;
            this.txtGroupName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter number of people in group";
            // 
            // txtGroupSize
            // 
            this.txtGroupSize.Location = new System.Drawing.Point(242, 259);
            this.txtGroupSize.Name = "txtGroupSize";
            this.txtGroupSize.Size = new System.Drawing.Size(36, 23);
            this.txtGroupSize.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(357, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ticket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Group Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Group Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Ticket price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total discount amount is";
            // 
            // lblGroupName
            // 
            this.lblGroupName.BackColor = System.Drawing.SystemColors.Menu;
            this.lblGroupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGroupName.Location = new System.Drawing.Point(612, 152);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(100, 16);
            this.lblGroupName.TabIndex = 16;
            this.lblGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // lblGroupSize
            // 
            this.lblGroupSize.BackColor = System.Drawing.SystemColors.Menu;
            this.lblGroupSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGroupSize.Location = new System.Drawing.Point(599, 176);
            this.lblGroupSize.Name = "lblGroupSize";
            this.lblGroupSize.Size = new System.Drawing.Size(100, 16);
            this.lblGroupSize.TabIndex = 17;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrice.Location = new System.Drawing.Point(632, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 16);
            this.lblPrice.TabIndex = 18;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.lblDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDiscountAmount.Location = new System.Drawing.Point(672, 234);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(100, 16);
            this.lblDiscountAmount.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGroupSize);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGroupSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdoSchoolGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AUCKLAND ZOO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rdoSchoolGroup;
        private RadioButton radioButton2;
        private Label label5;
        private TextBox txtGroupName;
        private Label label6;
        private TextBox txtGroupSize;
        private Button btnCalculate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox lblGroupName;
        private TextBox lblGroupSize;
        private TextBox lblPrice;
        private TextBox lblDiscountAmount;
    }
}