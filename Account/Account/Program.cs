using System;

namespace Account
{/*Создать базовый класс Счет, котороый содержит информацию - сумма, номер счета, дата открытия, 
    а также методы Выдача суммы и Выдача даты открытия счета. С помошью механизма наследования 
    создать класс "Счет физического лица" и "Счет юридического лица.

"Счет физического лица" содержит:
поле "Вид счета"
 методы "Начисление процентов" и "Снятие денег со счета"

"Счет юридического лица содержит:
метод начисления процентов*/
class Account
    {
        public static double Sum { get; set; }
        public int AccountNum { get; set; }
        public string OpenDate { get; set; }
        public int Date { get; set; }
        public Account()
        {
            Input();
        }
        public void Input()
        {
            Console.WriteLine("Сколько денег хотите выложить в счет:");
            Sum = Check.checkInt();
            Console.WriteLine("Ваш номер счета:");
            AccountNum = Check.checkInt();
            Console.WriteLine("Дата открытия счета:");
            OpenDate = Console.ReadLine();
            Console.WriteLine("mesyac");
            Date = Check.checkInt();
        }
        //void GetSum()
        //{
        //    Console.WriteLine($"Vasha summa na scetu: {Sum}");
        //}
        //void GetDate()
        //{
        //    Console.WriteLine($"Data otkritiya sceta :{OpenDate}");
        //}

    }
    class IndividualAccount : Account
    {
        double percent = 0.05;
        public IndividualAccount(int sum, int accountNum, string openDate)
            : base(  )
        {
          
        }      
    
    public void CountPer()
        {
           double f= (Sum) * percent;
        }
    public void TakeMoney()
        {

        }    
    }
    class IndividualAccounts
    {
        IndividualAccount[] data;
        public IndividualAccounts()
        {
            data = new IndividualAccount[100];
        }
        public IndividualAccount this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }

    class Check
    {
        public static int checkInt()
        {
            int n;
            bool IsIt = false;
            do
            {
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out n);
                if (result == false) { Console.WriteLine("Неправильный ввод.Неправильный ввод"); }
                else { result = true; }
                return n;
            } while (IsIt == false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите счет:\n1.Счет физического лица.\n2.Счет юридического лица.\n3.Выйти из программы");
            bool IsIt = false;
            do
            {
                int r = Check.checkInt();
                switch (r) 
                {
                    case 1:
                        IndividualAccount ind = new IndividualAccount(0,0,"");
                        
                        break;
                    //case 2:
                    

                    case 3:
                        Console.WriteLine("Конец работы");                        
                        IsIt = true;
                        break;
                }
            }while (IsIt = false);
        }
    }
}
