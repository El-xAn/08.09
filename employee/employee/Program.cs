using System;

namespace employee
{/*Создать базовый класс Student, который будет содержать информацию о студенте 
    (фамилия, курс обучения, номер зачетной книги). С помощью механизма наследование 
    реализовать класс Aspirant (аспирант – студент, который готовится к защите кандидатской 
    диссертации). Класс Aspirant есть производным от класса Student.

В классах Student и Aspirant необходимо реализовать следующие элементы:

конструкторы классов с соответствующим количеством параметров. В классе Aspirant для доступа 
к методам класса Student нужно использовать ключевое слово base;
свойства get/set для доступа к полям класса;
метод Print(), который выводит информацию о содержимом полей класса.*/
    class Student
    {
        public string LastName { get; set; }
        public string Kurs { get; set; }
        public int Number { get; set; }

        public Student (string lastName, string kurs, int number)
        {
            LastName = lastName;
            Kurs = kurs;
            Number = number;
        }

        public void InputData()
        {
            Console.WriteLine("Enter lastname :");
            LastName = Check.CheckString();
            Console.WriteLine("Enter course of study :");
            Kurs = Check.CheckString();
            Console.WriteLine("Enter grade book number :");
            Number = Check.CheckInt();
        }        
    }
    
    class Aspirant : Student
    {
        string Diss { get; set; }
        public Aspirant(string lastName, String kurs, int number, string diss)
            :base ( lastName,  kurs,  number)
        {
            Diss = diss;
        }
        public void Disp()
        {
            Console.WriteLine("Thesis :");
            Diss = Check.CheckString();
        }

    }
    class Check
    {
        public static string CheckString()
        {
            bool IsIt = false;
            string name;
            do
            {
                name = Console.ReadLine();

                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        if (name[i] == j.ToString()[0])
                        {                         
                            IsIt = false;
                            break;                            
                        }
                        else
                        {
                            IsIt = true;
                        }
                    }
                }
                if (IsIt == false)
                Console.WriteLine("Wrong enter. Enter again : ");

            } while (IsIt == false);
                return name;
        }
        public static int CheckInt()
        {
            bool IsIt = false;
            int num;
            do
            {
                string input = Console.ReadLine();

                bool result = int.TryParse(input, out num);
                if (result == false)
                    Console.WriteLine("Wrong enter. Enter again : ");
                else                   
                        break;

            } while (IsIt == false);
            return num;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Alekberov","IT engineering", 019632 );
            st.InputData();
            Console.WriteLine("\nClass Aspirant:");
            Aspirant asp = new Aspirant("", "", 0 , "");
            asp.InputData();
            asp.Disp();

        }
    }
}
