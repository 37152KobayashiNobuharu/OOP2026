using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;  //¶‚Ü‚ê‚½“ú•t
            DateTime today = DateTime.Today; //¡“ú‚Ì“ú•t
            tbOut1.Text = $"{(today.Year - birth.Year)}Î‚Å‚·";
            
            tbOut2.Text = $"{today.Date - birth.Date}“úŒo‰ß";
        }
    }
}
