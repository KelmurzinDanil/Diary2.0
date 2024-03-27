using System;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class StudentScheduleWindow : Form
    {
        public StudentScheduleWindow()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }
    }
}
