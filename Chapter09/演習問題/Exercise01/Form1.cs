using System;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            tbOut1.Text = $"{DateTime.Now:d} {DateTime.Now:t}";
        }

        private void btButton2_Click(object sender, EventArgs e) {
            tbOut2.Text = $"{DateTime.Now:D} " +
                $"{DateTime.Now.ToString("HH時mm分ss秒")}";
        }

        private void btButton3_Click(object sender, EventArgs e) {
            tbOut3.Text = $"令和　{DateTime.Now.Year - 2018}年" +
                $"{DateTime.Now.ToString("　M月　d日(dddd)")}";
        }
    }
}
