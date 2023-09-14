using System.Text;

namespace HW04
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("✨ Створення нового користувача. Задайте необхідні параметри:");
            ConsoleInput.Take(" • Стать (0 - жіноча, 1 - чоловіча, інше - невизначено): ", out EGender? gender);
            ConsoleInput.Take(" • Вік: ", out Int32? age);
            ConsoleInput.Take(" • Ім'я: ", out String firstName);
            ConsoleInput.Take(" • Прізвище: ", out String lastName);
            
            User newUser = new ()
            {
                Gender = gender,
                Age = age,
                FirstName = firstName,
                LastName = lastName,
            };

            Console.WriteLine(newUser);
        }
    }
}