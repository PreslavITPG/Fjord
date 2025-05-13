using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static void ApplyDarkTheme(Form form)
    {
        form.BackColor = Color.FromArgb(30, 30, 30);
        form.Font = new Font("Segoe UI", 10);

        foreach (Control control in form.Controls)
        {
            if (control is Button btn)
            {
                btn.BackColor = Color.FromArgb(45, 45, 48);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.DarkCyan;
            }
            else if (control is ListBox list)
            {
                list.BackColor = Color.FromArgb(40, 40, 40);
                list.ForeColor = Color.Gainsboro;
            }
            else if (control is TextBox txt)
            {
                txt.BackColor = Color.FromArgb(40, 40, 40);
                txt.ForeColor = Color.White;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
