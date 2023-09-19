using System.Text;

namespace HW04
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("✨ Створення нового користувача. Задайте необхідні параметри:");
            ConsoleInput.Take(out String lastName, " • Прізвище", Validation.IsNotEmpty, Validation.ContainsOnlyLetters);
            ConsoleInput.Take(out String firstName, " • Ім'я", Validation.IsNotEmpty,  Validation.ContainsOnlyLetters);
            ConsoleInput.Take(out EGender? gender, " • Стать (0 - жіноча, 1 - чоловіча)", Validation.IsAcceptableValue);
            ConsoleInput.Take(out Int32? age, " • Вік", Validation.IsNotEmpty, Validation.IsGreatherOrEqualThanMinAge, Validation.IsLessOrEqualThanMaxAge);
            
            User newUser = new ()
            {
                LastName = lastName,
                FirstName = firstName,
                Gender = gender,
                Age = age,
            };

            Console.WriteLine(newUser);
        }
    }
}