using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> Client1 = new BankAccount<int>();
            Client1.Input();
            Client1.GetInfo();
            BankAccount<string> Client2 = new BankAccount<string>();
            Client2.Input();
            Client2.GetInfo();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        public T Account { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public double Balance { get; set; }
        public void Input()
        {
            Console.Write("Введите номер счета: ");
            Account = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введите фамилию: ");
            LastName = Console.ReadLine();
            Console.Write("Введите имя: ");
            FirstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            Patronymic = Console.ReadLine();
            Console.Write("Введите баланс: ");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void GetInfo()
        {
            Console.WriteLine("Данные о клиенте:");
            Console.WriteLine("Клиент: {0}/{1}/{2}", LastName, FirstName, Patronymic);
            Console.WriteLine("Номер счета: {0}", Account);
            Console.WriteLine("Баланс: {0}", Balance);
        }
    }

}
