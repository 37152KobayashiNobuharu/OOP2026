using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public int Year { get; init; }
        public int Month { get; init; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }
        public bool is21Century {
            get {
                return Year >= 2001 && Year <= 2100;
            }
        }
        public YearMonth AddOneMonth() {
            if (Month ==12) {
                return new YearMonth(Year + 1, 1);
            } else {
                return new YearMonth(Year, Month + 1);
            }
        }
        public override string ToString() => $"{Year}年{Month}月";      
    }
}
