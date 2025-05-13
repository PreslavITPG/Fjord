using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        private string connectionString = "server=localhost;user id=guitar_app;password=5;database=guitar_learning;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyDarkTheme(this);
        }
        // Login button click event
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();



            if (CheckLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                Form2 mainForm = new Form2(username); // Pass username to Form2
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        // --- ADD THIS NEW METHOD FOR LOGIN VERIFICATION ---
        private bool CheckLogin(string username, string password)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!"); // Debug message

                    string query = "SELECT Password FROM Users WHERE Username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("User not found in database"); // Debug
                        return false;
                    }

                    string storedHash = result.ToString();
                    string inputHash = ComputeSha256Hash(password);

                    return storedHash.Equals(inputHash);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}\n{ex.StackTrace}");
                    return false;
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Convert to hex
                }

                return builder.ToString();
            }
        }

        


        // Other existing methods (like textbox events) can remain below...
    }
}