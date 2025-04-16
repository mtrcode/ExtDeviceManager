namespace ExtDeviceManager
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            button1 = new Button();
            newDevices_checkBox = new CheckBox();
            removeDevice_checkBox = new CheckBox();
            listBox1 = new ListBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            testAreaToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 371);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "with love from (c) MTR-Code";
            // 
            // button1
            // 
            button1.Location = new Point(320, 33);
            button1.Name = "button1";
            button1.Size = new Size(304, 23);
            button1.TabIndex = 1;
            button1.Text = "Test Get Device List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // newDevices_checkBox
            // 
            newDevices_checkBox.AutoSize = true;
            newDevices_checkBox.Location = new Point(12, 33);
            newDevices_checkBox.Name = "newDevices_checkBox";
            newDevices_checkBox.Size = new Size(235, 19);
            newDevices_checkBox.TabIndex = 3;
            newDevices_checkBox.Text = "Отслеживать подключение устройств";
            newDevices_checkBox.UseVisualStyleBackColor = true;
            // 
            // removeDevice_checkBox
            // 
            removeDevice_checkBox.AutoSize = true;
            removeDevice_checkBox.Checked = true;
            removeDevice_checkBox.CheckState = CheckState.Checked;
            removeDevice_checkBox.Location = new Point(12, 58);
            removeDevice_checkBox.Name = "removeDevice_checkBox";
            removeDevice_checkBox.Size = new Size(227, 19);
            removeDevice_checkBox.TabIndex = 4;
            removeDevice_checkBox.Text = "Отслеживать отключение устройств";
            removeDevice_checkBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(323, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 424);
            listBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "Периодичность:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(115, 83);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(156, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "мсек.";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 141);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(302, 363);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { testAreaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(320, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // testAreaToolStripMenuItem
            // 
            testAreaToolStripMenuItem.Name = "testAreaToolStripMenuItem";
            testAreaToolStripMenuItem.Size = new Size(66, 20);
            testAreaToolStripMenuItem.Text = "Test Area";
            testAreaToolStripMenuItem.Click += testAreaToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 112);
            button2.Name = "button2";
            button2.Size = new Size(302, 23);
            button2.TabIndex = 11;
            button2.Text = "Начать отслеживание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 62);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 12;
            label4.Text = "Устройства: ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(256, 507);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Copy Log";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(633, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 175);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 531);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(removeDevice_checkBox);
            Controls.Add(newDevices_checkBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeviceManager - DAFUQOW Edition";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private CheckBox newDevices_checkBox;
        private CheckBox removeDevice_checkBox;
        private ListBox listBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testAreaToolStripMenuItem;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
