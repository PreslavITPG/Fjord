using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TabViewerForm : Form
    {
        public TabViewerForm(string songTitle, string tabContent)
        {
            InitializeComponent();

            // Remove the Load event handler from designer if it exist
            // Set up the form
            this.Text = $"Tablature: {songTitle}";

            // Create and configure TextBox
            TextBox txtTab = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Both,
                Font = new System.Drawing.Font("Courier New", 10),
                Text = tabContent,
                ReadOnly = true
            };

            this.Controls.Add(txtTab);
            this.Size = new System.Drawing.Size(600, 400);
        }

        private void TabViewerForm_Load(object sender, EventArgs e)
        {

        }
    }
}