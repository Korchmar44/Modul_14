using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_3_3
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Contact contact = new Contact(); // создаем пустой объект Contact для доступа к методу AddContact

            contact.AddContact(new Contact("Иван", "Иванов", "+123456789", "ivanov@example.com"));
            contact.AddContact(new Contact("Петр", "Петров", "+987654321", "petrov@example.com"));
            contact.AddContact(new Contact("Мария", "Сидорова", "+555555555", "sidorova@example.com"));
            contact.AddContact(new Contact("Елена", "Козлова", "+333333333", "kozlova@example.com"));
            contact.AddContact(new Contact("Алексей", "Смирнов", "+999999999", "smirnov@example.com"));

            List<Contact> allContacts = contact.Contacts; // получаем обновленный список контактов

            Console.WriteLine("Без сортировки");
            foreach (var item in allContacts)
            {
                Console.WriteLine(item.ToString()); // Выводим информацию о контакте в консоль
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка по имени");
            allContacts = contact.GetContactsByName();

            foreach (var item in allContacts)
            {
                Console.WriteLine(item.ToString()); // Выводим информацию
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка по Фамилии");
            allContacts = contact.GetContactsByLastName();

            foreach (var item in allContacts)
            {
                Console.WriteLine(item.ToString()); // Выводим информацию
            }

            Console.ReadKey();
        }
    }
}
