namespace Projectปี1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            เพิ่มลูกค้า = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ชื่อลูกค้า = new TextBox();
            next_customer = new Button();
            Queue_listBox = new ListBox();
            status_machine1 = new Label();
            status_machine2 = new Label();
            status_machine3 = new Label();
            menuStrip1 = new MenuStrip();
            status_machine4 = new Label();
            label10 = new Label();
            label11 = new Label();
            status_machine5 = new Label();
            label13 = new Label();
            label14 = new Label();
            status_machine6 = new Label();
            label16 = new Label();
            label17 = new Label();
            label9 = new Label();
            time_numericUpDown = new NumericUpDown();
            เวลาที่จะเข้ามาซักผ้า = new Label();
            Clear = new Button();
            clear1 = new Button();
            clear2 = new Button();
            clear3 = new Button();
            clear4 = new Button();
            clear5 = new Button();
            clear6 = new Button();
            ReadCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)time_numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // เพิ่มลูกค้า
            // 
            เพิ่มลูกค้า.Location = new Point(512, 550);
            เพิ่มลูกค้า.Name = "เพิ่มลูกค้า";
            เพิ่มลูกค้า.Size = new Size(150, 57);
            เพิ่มลูกค้า.TabIndex = 0;
            เพิ่มลูกค้า.Text = "เพิ่มลูกค้า";
            เพิ่มลูกค้า.UseVisualStyleBackColor = true;
            เพิ่มลูกค้า.Click += เพิ่มลูกค้า_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 432);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "ชื่อลูกค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24.75F);
            label2.Location = new Point(382, 209);
            label2.Name = "label2";
            label2.Size = new Size(119, 38);
            label2.TabIndex = 2;
            label2.Text = "เครื่อง 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24.75F);
            label3.Location = new Point(382, 278);
            label3.Name = "label3";
            label3.Size = new Size(119, 38);
            label3.TabIndex = 4;
            label3.Text = "เครื่อง 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24.75F);
            label4.Location = new Point(378, 345);
            label4.Name = "label4";
            label4.Size = new Size(119, 38);
            label4.TabIndex = 6;
            label4.Text = "เครื่อง 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 24.75F);
            label5.Location = new Point(498, 209);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 8;
            label5.Text = "สถานะ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24.75F);
            label6.Location = new Point(925, 209);
            label6.Name = "label6";
            label6.Size = new Size(101, 38);
            label6.TabIndex = 9;
            label6.Text = "สถานะ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 24.75F);
            label7.Location = new Point(498, 278);
            label7.Name = "label7";
            label7.Size = new Size(101, 38);
            label7.TabIndex = 10;
            label7.Text = "สถานะ";
            // 
            // ชื่อลูกค้า
            // 
            ชื่อลูกค้า.Location = new Point(601, 429);
            ชื่อลูกค้า.Name = "ชื่อลูกค้า";
            ชื่อลูกค้า.Size = new Size(184, 23);
            ชื่อลูกค้า.TabIndex = 14;
            // 
            // next_customer
            // 
            next_customer.Location = new Point(668, 550);
            next_customer.Name = "next_customer";
            next_customer.Size = new Size(150, 57);
            next_customer.TabIndex = 17;
            next_customer.Text = "ลูกค้าถัดไป";
            next_customer.UseVisualStyleBackColor = true;
            next_customer.Click += next_customer_Click;
            // 
            // Queue_listBox
            // 
            Queue_listBox.FormattingEnabled = true;
            Queue_listBox.ItemHeight = 15;
            Queue_listBox.Location = new Point(10, 18);
            Queue_listBox.Name = "Queue_listBox";
            Queue_listBox.Size = new Size(337, 589);
            Queue_listBox.TabIndex = 18;
            // 
            // status_machine1
            // 
            status_machine1.AutoSize = true;
            status_machine1.Font = new Font("Microsoft Sans Serif", 24.75F);
            status_machine1.Location = new Point(599, 209);
            status_machine1.Name = "status_machine1";
            status_machine1.Size = new Size(61, 38);
            status_machine1.TabIndex = 20;
            status_machine1.Text = "ว่าง";
            status_machine1.Click += status_machine1_Click;
            // 
            // status_machine2
            // 
            status_machine2.AutoSize = true;
            status_machine2.Font = new Font("Microsoft Sans Serif", 24.75F);
            status_machine2.Location = new Point(599, 281);
            status_machine2.Name = "status_machine2";
            status_machine2.Size = new Size(61, 38);
            status_machine2.TabIndex = 21;
            status_machine2.Text = "ว่าง";
            // 
            // status_machine3
            // 
            status_machine3.AutoSize = true;
            status_machine3.Font = new Font("Microsoft Sans Serif", 24.75F);
            status_machine3.Location = new Point(599, 345);
            status_machine3.Name = "status_machine3";
            status_machine3.Size = new Size(61, 38);
            status_machine3.TabIndex = 22;
            status_machine3.Text = "ว่าง";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1268, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // status_machine4
            // 
            status_machine4.AutoSize = true;
            status_machine4.Font = new Font("Microsoft Sans Serif", 24.75F);
            status_machine4.Location = new Point(1023, 209);
            status_machine4.Name = "status_machine4";
            status_machine4.Size = new Size(61, 38);
            status_machine4.TabIndex = 27;
            status_machine4.Text = "ว่าง";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 24.75F);
            label10.Location = new Point(925, 276);
            label10.Name = "label10";
            label10.Size = new Size(101, 38);
            label10.TabIndex = 26;
            label10.Text = "สถานะ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 24.75F);
            label11.Location = new Point(809, 209);
            label11.Name = "label11";
            label11.Size = new Size(119, 38);
            label11.TabIndex = 25;
            label11.Text = "เครื่อง 4";
            // 
            // status_machine5
            // 
            status_machine5.AutoSize = true;
            status_machine5.Font = new Font("Segoe UI", 25F);
            status_machine5.Location = new Point(1021, 273);
            status_machine5.Name = "status_machine5";
            status_machine5.Size = new Size(63, 46);
            status_machine5.TabIndex = 30;
            status_machine5.Text = "ว่าง";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 25F);
            label13.Location = new Point(494, 337);
            label13.Name = "label13";
            label13.Size = new Size(105, 46);
            label13.TabIndex = 29;
            label13.Text = "สถานะ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 25F);
            label14.Location = new Point(806, 273);
            label14.Name = "label14";
            label14.Size = new Size(122, 46);
            label14.TabIndex = 28;
            label14.Text = "เครื่อง 5";
            // 
            // status_machine6
            // 
            status_machine6.AutoSize = true;
            status_machine6.Font = new Font("Segoe UI", 25F);
            status_machine6.Location = new Point(1021, 333);
            status_machine6.Name = "status_machine6";
            status_machine6.Size = new Size(63, 46);
            status_machine6.TabIndex = 33;
            status_machine6.Text = "ว่าง";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 25F);
            label16.Location = new Point(921, 333);
            label16.Name = "label16";
            label16.Size = new Size(105, 46);
            label16.TabIndex = 32;
            label16.Text = "สถานะ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 25F);
            label17.Location = new Point(809, 333);
            label17.Name = "label17";
            label17.Size = new Size(122, 46);
            label17.TabIndex = 31;
            label17.Text = "เครื่อง 6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 60F);
            label9.Location = new Point(521, 24);
            label9.Name = "label9";
            label9.Size = new Size(502, 106);
            label9.TabIndex = 34;
            label9.Text = "ร้านซักผ้าจองดี";
            // 
            // time_numericUpDown
            // 
            time_numericUpDown.Location = new Point(601, 458);
            time_numericUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            time_numericUpDown.Name = "time_numericUpDown";
            time_numericUpDown.Size = new Size(73, 23);
            time_numericUpDown.TabIndex = 35;
            // 
            // เวลาที่จะเข้ามาซักผ้า
            // 
            เวลาที่จะเข้ามาซักผ้า.AutoSize = true;
            เวลาที่จะเข้ามาซักผ้า.Location = new Point(474, 458);
            เวลาที่จะเข้ามาซักผ้า.Name = "เวลาที่จะเข้ามาซักผ้า";
            เวลาที่จะเข้ามาซักผ้า.Size = new Size(96, 15);
            เวลาที่จะเข้ามาซักผ้า.TabIndex = 36;
            เวลาที่จะเข้ามาซักผ้า.Text = "เวลาที่จะเข้ามาซักผ้า";
            // 
            // Clear
            // 
            Clear.Location = new Point(1167, 550);
            Clear.Name = "Clear";
            Clear.Size = new Size(76, 79);
            Clear.TabIndex = 37;
            Clear.Text = "button1";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // clear1
            // 
            clear1.Location = new Point(721, 209);
            clear1.Name = "clear1";
            clear1.Size = new Size(82, 38);
            clear1.TabIndex = 38;
            clear1.Text = "ล้างเครื่อง1";
            clear1.UseVisualStyleBackColor = true;
            clear1.Click += clear1_Click;
            // 
            // clear2
            // 
            clear2.Location = new Point(721, 283);
            clear2.Name = "clear2";
            clear2.Size = new Size(82, 38);
            clear2.TabIndex = 39;
            clear2.Text = "ล้างเครื่อง2";
            clear2.UseVisualStyleBackColor = true;
            clear2.Click += clear2_Click;
            // 
            // clear3
            // 
            clear3.Location = new Point(721, 345);
            clear3.Name = "clear3";
            clear3.Size = new Size(82, 38);
            clear3.TabIndex = 40;
            clear3.Text = "ล้างเครื่อง3";
            clear3.UseVisualStyleBackColor = true;
            clear3.Click += clear3_Click;
            // 
            // clear4
            // 
            clear4.Location = new Point(1186, 209);
            clear4.Name = "clear4";
            clear4.Size = new Size(82, 38);
            clear4.TabIndex = 41;
            clear4.Text = "ล้างเครื่อง4";
            clear4.UseVisualStyleBackColor = true;
            clear4.Click += clear4_Click;
            // 
            // clear5
            // 
            clear5.Location = new Point(1186, 278);
            clear5.Name = "clear5";
            clear5.Size = new Size(82, 38);
            clear5.TabIndex = 42;
            clear5.Text = "ล้างเครื่อง5";
            clear5.UseVisualStyleBackColor = true;
            clear5.Click += clear5_Click;
            // 
            // clear6
            // 
            clear6.Location = new Point(1186, 345);
            clear6.Name = "clear6";
            clear6.Size = new Size(82, 38);
            clear6.TabIndex = 43;
            clear6.Text = "ล้างเครื่อง6";
            clear6.UseVisualStyleBackColor = true;
            clear6.Click += clear6_Click;
            // 
            // ReadCsv
            // 
            ReadCsv.Location = new Point(987, 458);
            ReadCsv.Name = "ReadCsv";
            ReadCsv.Size = new Size(112, 52);
            ReadCsv.TabIndex = 44;
            ReadCsv.Text = "Read Csv";
            ReadCsv.UseVisualStyleBackColor = true;
            ReadCsv.Click += ReadCsv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 641);
            Controls.Add(ReadCsv);
            Controls.Add(clear6);
            Controls.Add(clear5);
            Controls.Add(clear4);
            Controls.Add(clear3);
            Controls.Add(clear2);
            Controls.Add(clear1);
            Controls.Add(Clear);
            Controls.Add(เวลาที่จะเข้ามาซักผ้า);
            Controls.Add(time_numericUpDown);
            Controls.Add(label9);
            Controls.Add(status_machine6);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(status_machine5);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(status_machine4);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(status_machine3);
            Controls.Add(status_machine2);
            Controls.Add(status_machine1);
            Controls.Add(Queue_listBox);
            Controls.Add(next_customer);
            Controls.Add(ชื่อลูกค้า);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(เพิ่มลูกค้า);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "363";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)time_numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button เพิ่มลูกค้า;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ชื่อลูกค้า;
        private Button next_customer;
        private ListBox Queue_listBox;
        private Label status_machine1;
        private Label status_machine2;
        private Label status_machine3;
        private MenuStrip menuStrip1;
        private Label status_machine4;
        private Label label10;
        private Label label11;
        private Label status_machine5;
        private Label label13;
        private Label label14;
        private Label status_machine6;
        private Label label16;
        private Label label17;
        private Label label9;
        private NumericUpDown time_numericUpDown;
        private Label เวลาที่จะเข้ามาซักผ้า;
        private Button Clear;
        private Button clear1;
        private Button clear2;
        private Button clear3;
        private Button clear4;
        private Button clear5;
        private Button clear6;
        private Button ReadCsv;
    }
}
