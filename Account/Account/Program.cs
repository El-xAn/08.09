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
        public int Sum { get; set; }
        public int AccountNum { get; set; }
        public string OpenDate { get; set; }
        
        public Account(int sum,int accountNum, string openDate)
        {
            Sum = sum;
            AccountNum = accountNum;
            OpenDate = openDate;
        }
        void GetSum()
        {
            Console.WriteLine($"Vasha summa na scetu: {Sum}");
        }
        void GetDate()
        {
            Console.WriteLine($"Data otkritiya sceta :{OpenDate}");
        }

    }
    class IndividualAccount : Account
    {
        string Account { get; set; }
        public IndividualAccount(int sum, int accountNum, string openDate, string account)
            : base( sum,  accountNum,  openDate )
        {
            Account = account;
        }      
    
    public void CountPer()
        {

        }
    public void TakeMoney()
        {

        }    
    }

    //class 
    class Program
    {
        static void Main(string[] args)
        {
            IndividualAccount acc1 = new IndividualAccount(5,6, "21.06" , "salam" );
        }
    }
}
