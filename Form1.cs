using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class RegistrationForm : Form
    {
        // Variables and methods for making the borderless form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constructor
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Event Method when the Form Load
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            setDefaultValue();
            populateDay();
            populateMonth();
            populateYear();
        }

        // Event method that makes the borderless form movable
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Closes the Application when clicking the X
        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method for the Default value of the Combobox
        public void setDefaultValue()
        {
            // Default Value for Day Combobox
            day_combo_box.Items.Insert(0, "-Day-");
            day_combo_box.SelectedIndex = 0;

            // Default Value for Month Combobox
            month_combo_box.Items.Insert(0, "-Month-");
            month_combo_box.SelectedIndex = 0;

            // Default Value for Year Combobox
            year_combo_box.Items.Insert(0, "-Year-");
            year_combo_box.SelectedIndex = 0;
        }

        // Method that populates the Day Combobox
        public void populateDay()
        {
            for(int x = 1; x <= 31; x++) day_combo_box.Items.Add(x);
        }

        // Method that populates the Month Combobox
        public void populateMonth()
        {
            for (int x = 1; x <= 12; x++) month_combo_box.Items.Add(x);
        }

        // Method that populates the Year Combobox
        public void populateYear()
        {
            for (int x = 1900; x <= DateTime.Now.Year; x++) year_combo_box.Items.Add(x);
        }
    }
}
