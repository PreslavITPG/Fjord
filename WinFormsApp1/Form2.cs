using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private string _username;

        // Dictionary to store song-tab mappings
        private Dictionary<string, string> _songTabs = new Dictionary<string, string>
        {
            {"1. Burzum - Dunkelheit", "Tabs/Burzum_Dunkelheit.txt"},
            {"2. Mayhem - Freezing Moon", "Tabs/Mayhem_FreezingMoon.txt"},
        };

        public Form2(string username)
        {
            InitializeComponent();
            _username = username;

            // Create Tabs directory if it doesn't exist
            if (!Directory.Exists("Tabs"))
            {
                Directory.CreateDirectory("Tabs");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Load songs from database instead of hardcoding
            LoadSongsFromDatabase();
        }

        private void LoadSongsFromDatabase()
        {
            string connectionString = "server=localhost;user id=guitar_app;password=5;database=guitar_learning;";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT song_id, title, artist FROM songs";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string songEntry = $"{reader["song_id"]}. {reader["artist"]} - {reader["title"]}";
                            listBox1.Items.Add(songEntry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading songs: {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedSong = listBox1.SelectedItem.ToString();

                // Show the tablature
                ShowTablature(selectedSong);
            }
        }

        private void ShowTablature(string song)
        {
            try
            {
                if (_songTabs.TryGetValue(song, out string tabPath))
                {
                    if (File.Exists(tabPath))
                    {
                        string tabContent = File.ReadAllText(tabPath);

                        // Create and show a new form to display the tab
                        TabViewerForm tabViewer = new TabViewerForm(song, tabContent);
                        tabViewer.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tablature file not found!", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No tablature available for this song.", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tab: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}