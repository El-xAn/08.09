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

    }
    class IndividualAccount : Account
    {

    }
    class 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
