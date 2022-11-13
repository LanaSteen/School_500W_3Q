using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_500W_3Q
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            /*
             * Შექმენით სტუდენტის, მასწავლებლის და საგნის კლასები.  
            Სტუდენტის კლასში უნდა არსეობდეს ინფორმაცია სტუდენტის სახელი გვარი პირადი ნომერი (პირადი ნომერი არ უნდა აღემატებოდეს 11 ციფრს), 
            საგნების ჩამონათვალს და სემესტრების შესახებ ინფორმაციას.(ეს ცალკე კლასად შეგიძლიათ აღწეროთ). 
            Შექმენით property რომელიც გამოტანს სახელს და გვარს ერთად. Სტუდენტს არ უნდა შეეძოს 35 GPA ზე მეტის აღება. 
            Შექმენით მეთოდები რომელიც გამოიტანს სემესტრის ან სემესტრების საგნების ჩამონათვალს და ლექტორების შესახებ ინფორმაციას. 
            Სტუდენტ კლასს ასევე უნდა ჰქონდეს მეთოდები რომელიც დაამატებს სემესტრს და ამ სემესტრის საგნებს. 
            Ან კონკრეტულ სემესტრში დაამატებს საგანს.
            Მასწავლებლის კლასი უნდა შეიცავდეს მასწავლების სახელს და გვარს და იმ საგნების სიას რომელსაც ასწავლის. 
            Ერთ მასწავლებელს არ უნდა შეეძლოს 3 ზე მეტი საგნის სწავლება. Კლასს განუსაზღვრეთ საგნის დამატების და შეცვლის მეთოდები.
            Საგნის კლასი უნდა შეიცავდეს საგნის დასახელებას, წინაპირობებეს (იმ საგნებს რომელიც არის წინაპირობა ახალი საგნის ასარჩევად), კრედიტის რაოდენობას და საგანზე მაქსიმალური სტუდენტების რაოდენობას. 
            Გადატვირთეთ ToString() მეთოდი , განსაზღვრეთ პარამეტრიანი და უპარამეტრო კონსტრუქტორები ყველა კლასისთვის.
            */

       
            Subject subject = new Subject { SubName = "Geometry", BeforeSub ="Math", Credit=5};
            Console.WriteLine(subject.ToString());


            Subject subject1 = new Subject { SubName = "Algebra", BeforeSub = "Math", Credit = 5 };
            Console.WriteLine(subject1.ToString());

            Subject subject2 = new Subject { SubName = "Calculus", BeforeSub = "Math", Credit = 5 };
            Console.WriteLine(subject2.ToString());

            Subject subject3 = new Subject { SubName = "Phisics", BeforeSub = "Math", Credit = 5 };
            Console.WriteLine(subject3.ToString());


            Teacher teacher = new Teacher { Fname = "Jane", Lname = "Doe"};
            teacher.AddSubject(subject);
            teacher.AddSubject(subject1);
            teacher.AddSubject(subject2);
            Console.WriteLine(teacher.ToString());


            teacher.EditSubject(subject2,subject3);
            Console.WriteLine(teacher.ToString());



            Student student = new Student { FirstName = "John", LastName = "Doe", semester = Semester.FirstGradeSpringSemester};
            student.AddSubject(subject, Semester.FirstGradeSpringSemester);
            Console.WriteLine(student.ToString());
        }
    }
}
