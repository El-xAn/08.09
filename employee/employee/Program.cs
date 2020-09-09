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

        public Student()
        {
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
        public void Display()
        {
            Console.WriteLine($"\n" +
                $"Student {LastName} from course {Kurs}. Number of grade book is {Number}");
        }
    }

    class Students
    {
        Student[] data;
        public Students()
        {
            data = new Student[100];
        }
        public Student this [int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    class Aspirant : Student
    {
        string Diss { get; set; }
        public Aspirant(string lastName, String kurs, int number, string diss)
            :base ( )
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
                Console.WriteLine("Wrong input. Enter again : ");
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
                    Console.WriteLine("Wrong input. Enter again : ");
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
            Console.WriteLine("1.Register students:" +
                "\n2.Show all registered students:" +
                "\n3.Find student:" +
                "\n4.Exit:");

            Aspirant asp = new Aspirant("", "", 0, "");            
            Student st = new Student();    
            bool b = false;
            do
            {
                Console.WriteLine("Select number of menu:");
                int menu = Check.CheckInt();
                switch (menu)
                {
                    case 1:
                        bool b1 = false;
                        do
                        {
                            Console.WriteLine("Are you:" +
                                "\n1.Student" +
                                "\n2.Graduate student");
                            int m = Check.CheckInt();
                            if (m == 1)
                            {
                                Console.WriteLine("How much students want you to register?");
                                int n = Check.CheckInt();
                                for (int i = 0; i < n; i++)
                                {
                                    st.InputData();
                                }
                                b1 = true;
                                break;
                            }

                            if (m == 2)
                            {
                                Console.WriteLine("How much Graduate students want you to register?");
                                int n = Check.CheckInt();
                                for (int i = 0; i < n; i++)
                                {
                                    st.InputData();
                                    asp.Disp();
                                }
                                b1 = true;
                                break;
                            }

                        } while (b1 == false);
                        break;  
                    case 2:
                        st.Display();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("The program has finished.");
                        b = true;
                        break;
                }
            } while (b == false);
        }
    }
}
