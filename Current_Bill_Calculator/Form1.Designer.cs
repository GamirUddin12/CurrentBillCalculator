namespace Current_Bill_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prevtext = new System.Windows.Forms.TextBox();
            this.pretext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.consutext = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.electircity_charge_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.demand_chagre_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vat_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.principal_amount_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vatTotal_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(165, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Present Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meter Reeding";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Meter Reeding";
            // 
            // prevtext
            // 
            this.prevtext.Location = new System.Drawing.Point(503, 17);
            this.prevtext.Name = "prevtext";
            this.prevtext.Size = new System.Drawing.Size(163, 26);
            this.prevtext.TabIndex = 6;
            this.prevtext.TextChanged += new System.EventHandler(this.prevtext_TextChanged);
            // 
            // pretext
            // 
            this.pretext.Location = new System.Drawing.Point(503, 70);
            this.pretext.Name = "pretext";
            this.pretext.Size = new System.Drawing.Size(163, 26);
            this.pretext.TabIndex = 7;
            this.pretext.TextChanged += new System.EventHandler(this.pretext_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Consumed Unit";
            // 
            // consutext
            // 
            this.consutext.Location = new System.Drawing.Point(503, 127);
            this.consutext.Name = "consutext";
            this.consutext.Size = new System.Drawing.Size(163, 26);
            this.consutext.TabIndex = 9;
            this.consutext.TextChanged += new System.EventHandler(this.consutext_TextChanged);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(355, 287);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(311, 34);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // electircity_charge_textBox
            // 
            this.electircity_charge_textBox.Location = new System.Drawing.Point(165, 131);
            this.electircity_charge_textBox.Name = "electircity_charge_textBox";
            this.electircity_charge_textBox.Size = new System.Drawing.Size(161, 26);
            this.electircity_charge_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Electricity Charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Demand Charge";
            // 
            // demand_chagre_textBox
            // 
            this.demand_chagre_textBox.Location = new System.Drawing.Point(165, 184);
            this.demand_chagre_textBox.Name = "demand_chagre_textBox";
            this.demand_chagre_textBox.Size = new System.Drawing.Size(161, 26);
            this.demand_chagre_textBox.TabIndex = 11;
            this.demand_chagre_textBox.Text = "30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vat (%)";
            // 
            // vat_textBox
            // 
            this.vat_textBox.Location = new System.Drawing.Point(165, 240);
            this.vat_textBox.Name = "vat_textBox";
            this.vat_textBox.Size = new System.Drawing.Size(160, 26);
            this.vat_textBox.TabIndex = 11;
            this.vat_textBox.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Amount To Be Paid";
            // 
            // amount_textbox
            // 
            this.amount_textbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.amount_textbox.Location = new System.Drawing.Point(165, 295);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(163, 26);
            this.amount_textbox.TabIndex = 7;
            this.amount_textbox.TextChanged += new System.EventHandler(this.pretext_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Principal Amount";
            // 
            // principal_amount_textBox
            // 
            this.principal_amount_textBox.Location = new System.Drawing.Point(501, 187);
            this.principal_amount_textBox.Name = "principal_amount_textBox";
            this.principal_amount_textBox.Size = new System.Drawing.Size(163, 26);
            this.principal_amount_textBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 2;
            this.label11.Tag = "";
            this.label11.Text = "Vat Total";
            // 
            // vatTotal_textBox
            // 
            this.vatTotal_textBox.Location = new System.Drawing.Point(501, 240);
            this.vatTotal_textBox.Name = "vatTotal_textBox";
            this.vatTotal_textBox.Size = new System.Drawing.Size(163, 26);
            this.vatTotal_textBox.TabIndex = 11;
            this.vatTotal_textBox.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 348);
            this.Controls.Add(this.vatTotal_textBox);
            this.Controls.Add(this.principal_amount_textBox);
            this.Controls.Add(this.vat_textBox);
            this.Controls.Add(this.demand_chagre_textBox);
            this.Controls.Add(this.electircity_charge_textBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.consutext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.pretext);
            this.Controls.Add(this.prevtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prevtext;
        private System.Windows.Forms.TextBox pretext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox consutext;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox electircity_charge_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox demand_chagre_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vat_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox principal_amount_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vatTotal_textBox;
    }
}

