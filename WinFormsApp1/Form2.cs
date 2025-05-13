using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private string _username;

        private string connectionString = "server=localhost;user id=guitar_app;password=5;database=guitar_learning;";

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

        private void Form2_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyDarkTheme(this);
        }

        private Dictionary<string, string> _videoLessons = new Dictionary<string, string>
        {
            {"Beginner Lesson 1: Intro to Guitar", "Lessons/IntroToGuitar.mp4"},
            {"Beginner Lesson 2: Basic Chords", "Lessons/BasicChords.mp4"},
            {"Beginner Lesson 3: Simple Strumming", "Lessons/SimpleStrumming.mp4"},
            {"Beginner Lesson 4: Easy Riffs", "Lessons/EasyRiffs.mp4"},
            {"Beginner Lesson 5: First Song", "Lessons/FirstSong.mp4"},
        };

        private Dictionary<string, string> _songTabs = new Dictionary<string, string>
        {
            {"1. Burzum - Dunkelheit", "Tabs/Burzum_Dunkelheit.txt"},
            {"2. Mayhem - Freezing Moon", "Tabs/Mayhem_FreezingMoon.txt"},
            {"3. Emperor - I Am the Black Wizards", "Tabs/Emperor_BlackWizards.txt"},
            {"4. Darkthrone - Transilvanian Hunger", "Tabs/Darkthrone_Transilvanian.txt"},
            {"5. Immortal - One by One", "Tabs/Immortal_OneByOne.txt"},
            {"6. Gorgoroth - Sign of an Open Eye", "Tabs/Gorgoroth_Sign.txt"},
            {"7. Satyricon - Mother North", "Tabs/Satyricon_MotherNorth.txt"},
            {"8. Enslaved - Isa", "Tabs/Enslaved_Isa.txt"},
            {"9. Watain - Outlaw", "Tabs/Watain_Outlaw.txt"},
            {"10. Bathory - A Fine Day to Die", "Tabs/Bathory_FineDay.txt"},
        };


        private Dictionary<string, string> _dbVideoLessons = new();
        private Dictionary<string, string> _dbTabs = new();


        private void LoadLessonsFromDatabase()
        {
            _dbVideoLessons.Clear();
            listBox1.Items.Clear();

            string query = "SELECT title, filepath FROM lessons";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = reader.GetString("title");
                        string path = reader.GetString("filepath");
                        _dbVideoLessons[title] = path;
                        listBox1.Items.Add(title);
                    }
                }
            }
        }

        private void LoadTabsFromDatabase()
        {
            _dbTabs.Clear();
            listBox1.Items.Clear();

            string query = "SELECT title, filepath FROM tabs";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = reader.GetString("title");
                        string path = reader.GetString("filepath");
                        _dbTabs[title] = path;
                        listBox1.Items.Add(title);
                    }
                }
            }
        }


        private void PlayLessonVideo(string lessonTitle)
        {
            if (_videoLessons.TryGetValue(lessonTitle, out string videoPath))
            {
                if (File.Exists(videoPath))
                {
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = videoPath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("Video file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem?.ToString();
            if (selected == null) return;

            if (_dbVideoLessons.ContainsKey(selected))
            {
                string videoPath = _dbVideoLessons[selected];
                if (File.Exists(videoPath))
                {
                    axWindowsMediaPlayer1.URL = videoPath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("Video file not found.");
                }
            }
            else if (_dbTabs.ContainsKey(selected))
            {
                string tabPath = _dbTabs[selected];
                if (File.Exists(tabPath))
                {
                    string content = File.ReadAllText(tabPath);
                    new TabViewerForm(selected, content).Show();
                }
                else
                {
                    MessageBox.Show("Tab file not found.");
                }
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



        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTabsFromDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLessonsFromDatabase();
        }
        }
        private void StopVideo()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Tab Text File";
                ofd.Filter = "Text Files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);
                    string targetPath = Path.Combine("Tabs", fileName);

                    // Copy file to Tabs folder
                    if (!Directory.Exists("Tabs"))
                        Directory.CreateDirectory("Tabs");

                    File.Copy(sourcePath, targetPath, true); // Overwrite if exists

                    string title = Path.GetFileNameWithoutExtension(fileName);

                    // Save to DB
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tabs (title, filepath) VALUES (@title, @filepath)";
                        using (var cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@filepath", targetPath);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Tab added successfully!");
                    LoadTabsFromDatabase();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Video Lesson File";
                ofd.Filter = "Video Files (*.mp4)|*.mp4";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);
                    string targetPath = Path.Combine("Lessons", fileName);

                    // Copy file to Lessons folder
                    if (!Directory.Exists("Lessons"))
                        Directory.CreateDirectory("Lessons");

                    File.Copy(sourcePath, targetPath, true); // Overwrite if exists

                    string title = Path.GetFileNameWithoutExtension(fileName);

                    // Save to DB
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO lessons (title, filepath) VALUES (@title, @filepath)";
                        using (var cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@filepath", targetPath);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Lesson added successfully!");
                    LoadLessonsFromDatabase();
                }
            }
        }
    }
}