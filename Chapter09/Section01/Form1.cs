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
            DateTime birth = dtpBirth.Value;  //ê∂Ç‹ÇÍÇΩì˙ït
            DateTime today = DateTime.Today; //ç°ì˙ÇÃì˙ït
            tbOut1.Text = $"{GetAge(birth, today)}çŒÇ≈Ç∑";
            TimeSpan ts = today - birth;
            tbOut2.Text = $"{ts.Days}ì˙åoâﬂ";
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            CalendarWeekRule rule = CalendarWeekRule.FirstDay;
            DayOfWeek firstDay = DayOfWeek.Sunday;
            
            tbOut3.Text = $"ê∂Ç‹ÇÍÇΩ{birth:D}" +
                $"ÇÕëÊ{CultureInfo.CurrentCulture.Calendar.GetWeekOfYear
                (birth, CalendarWeekRule.FirstDay, DayOfWeek.Sunday)
                }èTÇÃ{birth:dddd}Ç≈Ç∑";
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
