namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button3 = new Button();
            button4 = new Button();
            listBox2 = new ListBox();
            button5 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            contextMenuStrip5 = new ContextMenuStrip(components);
            contextMenuStrip6 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 17);
            button1.Name = "button1";
            button1.Size = new Size(68, 64);
            button1.TabIndex = 0;
            button1.Text = "Tabs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 64);
            button2.TabIndex = 1;
            button2.Text = "Lessons";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 94);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(395, 43);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(238, 156);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(100, 17);
            button3.Name = "button3";
            button3.Size = new Size(66, 64);
            button3.TabIndex = 4;
            button3.Text = "Add Tab";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(283, 17);
            button4.Name = "button4";
            button4.Size = new Size(76, 64);
            button4.TabIndex = 5;
            button4.Text = "Add Lesson";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(26, 329);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(333, 109);
            listBox2.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(135, 269);
            button5.Name = "button5";
            button5.Size = new Size(92, 54);
            button5.TabIndex = 7;
            button5.Text = "Show Favorites";
            button5.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(61, 4);
            // 
            // contextMenuStrip6
            // 
            contextMenuStrip6.Name = "contextMenuStrip6";
            contextMenuStrip6.Size = new Size(61, 4);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 462);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button button3;
        private Button button4;
        private ListBox listBox2;
        private Button button5;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ContextMenuStrip contextMenuStrip5;
        private ContextMenuStrip contextMenuStrip6;
    }
}