using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_500W_3Q
{
    public class Student
    {
        /*
          Სტუდენტის კლასში უნდა არსეობდეს ინფორმაცია სტუდენტის სახელი გვარი პირადი ნომერი 
         (პირადი ნომერი არ უნდა აღემატებოდეს 11 ციფრს), საგნების ჩამონათვალს და სემესტრების შესახებ ინფორმაციას.
         (ეს ცალკე კლასად შეგიძლიათ აღწეროთ). Შექმენით property რომელიც გამოტანს სახელს და გვარს ერთად. 
          Სტუდენტს არ უნდა შეეძოს 35 GPA ზე მეტის აღება.
         * 
         * Შექმენით მეთოდები რომელიც გამოიტანს სემესტრის ან 
         * სემესტრების საგნების ჩამონათვალს და ლექტორების შესახებ ინფორმაციას.  Სტუდენტ კლასს ასევე უნდა ჰქონდეს მეთოდები 
         * რომელიც დაამატებს სემესტრს და ამ სემესტრის საგნებს. Ან კონკრეტულ სემესტრში დაამატებს საგანს.
*/
        private int _count = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string id;
        public string ID { get
            {
                return id;  
            }
            set
            {
                if (value.Count() <= 11)
                { id = value; }
                else
                {
                    throw new Exception("Id number cant contain more then 11 digits");
                }
            }
        }

        public Semester semester { get; set; }
        public Subject[] _subjects = new Subject[5];


        public Student() { }

        public Student (string FirstName, string LastName, Semester semester)
        {
            this.FirstName = FirstName; 
            this.LastName = LastName;
            this.semester = semester;
        }


        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
        }

        public void AddSubject(Subject subject, Semester semester)
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


        public void EditSubject(Subject subject, Subject subject1, Semester semester)
        {
            for (int index = 0; index < _subjects.Length; index++)
                if (_subjects[index] == subject)
                    _subjects[index] = subject1;

        }


        public void GetSubject( Semester semester)
        {
            for (int index = 0; index < _subjects.Length; index++)
                Console.WriteLine($"Subject{index} {_subjects[index]}");

        }

 

        public override string ToString()
        {
            return "Student Name: " + FirstName + ",  Last Name: " + LastName + " Semester : " + semester + " Subject 1 : " + _subjects[0] + " Subject 2 : " + _subjects[1] + " Subject 3 : " + _subjects[2] +" Subject 4 : " + _subjects[3] + " Subject 5 : " + _subjects[4];
        }

    }

 }


public enum  Semester
{
      FirstGradeOutumnSemester,
      FirstGradeSpringSemester,
      SecondGradeOutumnSemester,
      SecondGradeSpringSemester
}