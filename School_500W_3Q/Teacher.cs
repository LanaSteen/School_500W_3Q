using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_500W_3Q
{
    public class Teacher
    {
        /*
        Მასწავლებლის კლასი უნდა შეიცავდეს მასწავლების სახელს და გვარს და იმ საგნების სიას რომელსაც ასწავლის. 
            Ერთ მასწავლებელს არ უნდა შეეძლოს 3 ზე მეტი საგნის სწავლება. 
        Კლასს განუსაზღვრეთ საგნის დამატების და შეცვლის მეთოდები.*/

        public string Fname { get; set; }
        public string Lname { get; set; }

        private int _count = 0;

        public Subject [] _subjects = new Subject[3];


        public Teacher() {  }

        public Teacher (string Fname, string Lname)
        {
            this.Fname = Fname; 
            this.Lname = Lname; 
        }

        public void AddSubject (Subject subject)
        {
            if (!_subjects.Contains(subject))
            {
              
                _subjects[_count] = subject;
                _count++;
            }
            else
            {
                throw new Exception("One teacher cant add the same subject");
            }


        }
        public void EditSubject(Subject subject, Subject subject1)
        {
            for (int index = 0; index < _subjects.Length; index++)
                if (_subjects[index] == subject)
                    _subjects[index] = subject1;

        }



        public override string ToString()
        {
            return "Teacher Name: " + Fname + ",  Last Name: " + Lname + " Subject 1 : " + _subjects[0] + " Subject 2 : " + _subjects[1] + " Subject 3 : " + _subjects[2];
        }
    }
}
