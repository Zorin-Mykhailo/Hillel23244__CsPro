using System.Text;

namespace HW04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("✨ Створення нового користувача. Задайте необхідні параметри:");
            //
            Console.Write(" • Стать (0 - жіноча, 1 - чоловіча, інше - невизначено): ");
            Int32 inputGender;
            EGender? gender = null;
            if (Int32.TryParse(Console.ReadLine(), out inputGender)) 
                gender = inputGender == 0 ? EGender.Female : inputGender == 1 ? EGender.Male : null;
            //
            Console.Write(" • Вік: ");
            Int32 inputAge;
            Int32? age = Int32.TryParse(Console.ReadLine(), out inputAge) ? inputAge : null;
            //
            Console.Write(" • Ім'я: ");
            String firstName = Console.ReadLine() ?? String.Empty;
            //
            Console.Write(" • Прізвище: ");
            String lastName = Console.ReadLine() ?? String.Empty;
            //
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