namespace Drink_Machine 
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
            this.all_drinks_table = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sugar_txt = new System.Windows.Forms.ComboBox();
            this.milk_txt = new System.Windows.Forms.ComboBox();
            this.cocoa_txt = new System.Windows.Forms.ComboBox();
            this.coffee_txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.new_name_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.all_drinks_table)).BeginInit();
            this.SuspendLayout();
            // 
            // all_drinks_table
            // 
            this.all_drinks_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_drinks_table.Location = new System.Drawing.Point(464, 317);
            this.all_drinks_table.Name = "all_drinks_table";
            this.all_drinks_table.RowHeadersWidth = 51;
            this.all_drinks_table.RowTemplate.Height = 24;
            this.all_drinks_table.Size = new System.Drawing.Size(803, 170);
            this.all_drinks_table.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(521, 229);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "הוספה";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(1073, 229);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "עדכון";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(802, 236);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "מחיקה";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "סוכר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "חלב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "קקאו";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "קפה";
            // 
            // sugar_txt
            // 
            this.sugar_txt.FormattingEnabled = true;
            this.sugar_txt.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.sugar_txt.Location = new System.Drawing.Point(167, 181);
            this.sugar_txt.Name = "sugar_txt";
            this.sugar_txt.Size = new System.Drawing.Size(121, 24);
            this.sugar_txt.TabIndex = 12;
            // 
            // milk_txt
            // 
            this.milk_txt.FormattingEnabled = true;
            this.milk_txt.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.milk_txt.Location = new System.Drawing.Point(167, 390);
            this.milk_txt.Name = "milk_txt";
            this.milk_txt.Size = new System.Drawing.Size(121, 24);
            this.milk_txt.TabIndex = 13;
            // 
            // cocoa_txt
            // 
            this.cocoa_txt.FormattingEnabled = true;
            this.cocoa_txt.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cocoa_txt.Location = new System.Drawing.Point(167, 324);
            this.cocoa_txt.Name = "cocoa_txt";
            this.cocoa_txt.Size = new System.Drawing.Size(121, 24);
            this.cocoa_txt.TabIndex = 14;
            // 
            // coffee_txt
            // 
            this.coffee_txt.FormattingEnabled = true;
            this.coffee_txt.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.coffee_txt.Location = new System.Drawing.Point(175, 252);
            this.coffee_txt.Name = "coffee_txt";
            this.coffee_txt.Size = new System.Drawing.Size(121, 24);
            this.coffee_txt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "הזן את שם המשקה החדש\r\nאותיות אנגליות בלבד\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "מכונת קפה";
            // 
            // new_name_txt
            // 
            this.new_name_txt.Location = new System.Drawing.Point(188, 84);
            this.new_name_txt.Name = "new_name_txt";
            this.new_name_txt.Size = new System.Drawing.Size(100, 22);
            this.new_name_txt.TabIndex = 18;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(175, 497);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 22);
            this.price_txt.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "מחיר\r\nהזן ערך במספרים בלבד";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(755, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "בחר את השורה שברצונך למחוק\r\n ולאחר מכן לחץ על כפתור מחק";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 48);
            this.label9.TabIndex = 22;
            this.label9.Text = "בחר את השורה שברצונך לעדכן\r\nמלא ערכים חדשים עבור המשקה\r\n ולאחר מכן לחץ על כפתור ע" +
    "דכן  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "קבע את שם המשקה\r\nמלא ערכים עבור המשקה\r\nלחץ על כפתור ההוספה\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 584);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.new_name_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coffee_txt);
            this.Controls.Add(this.cocoa_txt);
            this.Controls.Add(this.milk_txt);
            this.Controls.Add(this.sugar_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.all_drinks_table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.all_drinks_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView all_drinks_table;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sugar_txt;
        private System.Windows.Forms.ComboBox milk_txt;
        private System.Windows.Forms.ComboBox cocoa_txt;
        private System.Windows.Forms.ComboBox coffee_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox new_name_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

