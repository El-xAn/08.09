using System;
using System.Dynamic;

namespace Account
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Account { get; set; }
        public int AccountNum { get; set; }
        public DateTime Date { get; set; }


        public Person()
        {
            InputData();
        }
        public void InputData()
        {
            Console.WriteLine("Ваше имя: ");
            Name = Check.checkString();
            Console.WriteLine("Ваша фамилия: ");
            Surname = Check.checkString();
            Console.WriteLine("Ваш номер счета: ");
            AccountNum = Check.checkInt();
            Console.WriteLine("Введите сумму: ");
            Account = Check.checkInt();   
            Date = DateTime.Today;
        }
        public int Control()
        {
            int prov=0;
            bool b = false;
            do
            {
            Console.WriteLine("Введите номер счета: ");
            prov = Check.checkInt();
                if (prov == AccountNum)
                {
                    b = true;
                }
                else
                {
                    Console.WriteLine("Неправильный номер.");
                    b = false;
                }
            } while (b == false);
           
            return prov;
        }
    }
    class IndAccount : Person
    {
        int Take { get; set; }
        double per = 0.1;

        public IndAccount(int take)
            :base( )
        {
            Take = take;
        }
        public void Input()
        {            
            Console.WriteLine($"{Name} {Surname} на вашем счету {Account}$. \nНачисленный процент:{Account*per}$. \nДата открытия счета: {Date}");
        }
        public void TakeSome()
        {
            Console.WriteLine("Сколько денег снять: ");
            Take = Check.checkInt();
            Account = Account - Take;
            Console.WriteLine($"На вашем счету осталось: {Account}$");
        }
    }
    class IndAccounts
    {
        public IndAccount[] data;
        public IndAccounts()
        {
            data = new IndAccount[100];
        }
        public IndAccount this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    class LegalAccount : Person
    {
        double per = 0.05;
        public LegalAccount() : base()
        {

        }
        public void Percent()
        {
            Console.WriteLine($"{Name} {Surname} на вашем счету {Account}$. \nНачисленный процент:{Account * per}$. \nДата открытия счета: {Date}");
        }
    }
    class LegalAccounts
    {
        public LegalAccount[] data;
        public LegalAccounts()
        {
            data = new LegalAccount[100];
        }
        public LegalAccount this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    class Check
    {
        public static int checkInt()
        {
            bool IsIt = false;
            int n;
            do
            {
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out n);
                if (result == false) { Console.WriteLine("Неправильный ввод.Введите цифры:"); }
                else { IsIt = true; }
            } while (IsIt == false);  
              return n;
        }
        public static string checkString()
        {
            bool IsIt = false;
            string s ;            
            do
            {
                int p = 0;
                 s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {                    
                        if (s[i] == j.ToString()[0])
                        {
                            p +=1;
                            IsIt = false;                            
                            break;
                        }
                        if (p != 0)
                        {
                            IsIt = false;
                        }
                        if(s[0]==' ')
                        {
                            IsIt = false;
                            break;
                        }
                        if (p == 0) 
                        {
                            IsIt = true;                            
                        }
                    }
                }  
                if (IsIt == false) 
                { 
                    Console.WriteLine("Неправильный ввод. Повторите еще раз:"); 
                }
            } while (IsIt == false);
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            bool IsIt = false;
            do
            {
            Console.WriteLine("Выберите счет:\n1.Счет физического лица.\n2.Счет юридического лица.\n3.Выйти из программы");
            Console.WriteLine("Выберите номер меню:");
            int r = Check.checkInt();
                IndAccounts acc1 = new IndAccounts();
                LegalAccounts acc2 = new LegalAccounts();
                switch (r)
                {
                case 1:
                    do
                    {
                    Console.WriteLine("\n1.Создать счет:" +
                                      "\n2.Информация о счете:" +
                                      "\n3.Снять деньги со счета:" +
                                      "\n4.Выход на главное меню:");

                    Console.WriteLine("Выберите номер меню:");
                    int d = Check.checkInt();
                    switch (d)
                    {                           
                    case 1:
                        acc1[0] = new IndAccount(0);                        
                        IsIt = false;
                        break;
                    case 2:
                        acc1[0].Control();                        
                        acc1[0].Input();                        
                        IsIt = false;
                        break;
    
                    case 3:
                        acc1[0].Control();
                        acc1[0].TakeSome();                                                            
                        IsIt = false;
                        break;

                    case 4:
                        IsIt = true;
                        break;
                    }
                    }while (IsIt == false) ;
                        IsIt = false;
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("\n1.Создать счет:" +
                                          "\n2.Информация о счете:" +
                                          "\n3.Выход на главное меню:");

                            Console.WriteLine("Выберите номер меню:");
                        int d = Check.checkInt();
                        switch (d)
                        {
                            case 1:
                                acc2[0] = new LegalAccount();
                                IsIt = false;
                                break;
                            case 2:
                                acc2[0].Control();
                                acc2[0].Percent();
                                IsIt = false;
                                break;

                            case 3:
                                IsIt = true;
                                break;
                        }
                    } while (IsIt == false);
                    IsIt = false;
                    break;
                        
                case 3:
                    Console.WriteLine("Конец работы");
                    IsIt = true;
                    break;
                }
            } while (IsIt == false);
        }
    }
}
