using System.Globalization;
using System.Text.RegularExpressions;

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
            tbOut1.Text = $"{GetAge(birth, today)}Î‚Å‚·";
            TimeSpan ts = today - birth;
            tbOut2.Text = $"{ts.Days}“úŒo‰ß";

            tbOut3.Text = $"¶‚Ü‚ê‚½{birth:D}" +
                $"‚Í‘æ{CultureInfo.CurrentCulture.Calendar.GetWeekOfYear
                (birth, CalendarWeekRule.FirstDay, DayOfWeek.Sunday)}T‚Ì{birth:dddd}‚Å‚·";

            if (birth.Date == today.Date) {
                tbOut4.Text = $"’a¶“ú‚Í¡“ú‚Å‚·";
            } else {
               tbOut4.Text = $"Ÿ‚Ì’a¶“ú‚Ü‚Å{(birth.Date - today.Date).Days.ToString()}“ú" ;
            }
        }
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

       
    }
}
