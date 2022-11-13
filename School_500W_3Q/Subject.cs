using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_500W_3Q
{
    public class Subject
    {
        /*
        Საგნის კლასი უნდა შეიცავდეს საგნის დასახელებას, წინაპირობებეს 
            (იმ საგნებს რომელიც არის წინაპირობა ახალი საგნის ასარჩევად),
            კრედიტის რაოდენობას და საგანზე მაქსიმალური სტუდენტების რაოდენობას.*/
        public string SubName { get; set; }
        public string BeforeSub { get; set; }

        private double credit;

        public double Credit
        {
            get
            {
                return credit;
            }
            set
            {
                if (value <= 7.0)
                    credit = value;
            }
        }
        private const int maxStudents = 20;

        public Subject() { }

        public Subject(string subName, string beforeSub, double credit)
        {
            SubName = subName;
            BeforeSub = beforeSub;
            Credit = credit;
       

        }

        public override string ToString()
        {
            return "Subject: " + SubName + ",  Before Subject: " + BeforeSub + " Credit: " + credit + " Max Number of Students: " + maxStudents;
        }

    }
}
