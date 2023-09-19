using System.ComponentModel.DataAnnotations;

namespace HW04
{
    public static class ConsoleInput
    {
        private static String? GetConsoleInput(String inputPrompt)
        {
            ConsoleColor prevConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{inputPrompt} > ");
            Console.ForegroundColor = ConsoleColor.Green;
            String? consoleInput = Console.ReadLine();
            Console.ForegroundColor = prevConsoleColor;
            return consoleInput;
        }

        private static Boolean ValueIsInvalid<T>(T value, params Func<T, String>[] validators)
        {
            if (validators == null || validators.Length == 0) return true;

            String? validationError = null;
            Boolean isValid = true;
            foreach (var validator in validators)
            {
                validationError = validator(value);
                isValid = String.IsNullOrWhiteSpace(validationError);
                if (!isValid) break;
            }
            if(isValid) return false;
            ShowInputError(validationError!);
            return true;
        }

        private static void ShowInputError(String errorMessage)
        {
            ConsoleColor prevBackgroundConsoleColor = Console.BackgroundColor;
            ConsoleColor prevForegroundConsoleColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ПОМИЛКА ВВОДУ ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {errorMessage}");
            //
            Console.BackgroundColor = prevBackgroundConsoleColor;
            Console.ForegroundColor = prevForegroundConsoleColor;
        }


        public static void Take(out String value, String inputPrompt, params Func<String, String>[] validators)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            value = consoleInput ?? String.Empty;
            if (ValueIsInvalid(value, validators)) 
                Take(out value, inputPrompt, validators);
        }

        public static void Take(out Int32? result, String inputPrompt, params Func<Int32?, String>[] validators)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            Boolean consoleInputIsEmpty = String.IsNullOrWhiteSpace(consoleInput);
            result = null;
            if (Int32.TryParse(consoleInput, out Int32 value) || consoleInputIsEmpty)
            {
                if (!consoleInputIsEmpty) result = value;                
                if (ValueIsInvalid(result, validators))
                    Take(out result, inputPrompt, validators);
                return;
            }
            ShowInputError("Значення не є цілим числом");
            Take(out result, inputPrompt, validators);
        }

        public static void Take(out EGender? result, String inputPrompt, params Func<EGender?, String>[] validators)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            Boolean consoleInputIsEmpty = String.IsNullOrWhiteSpace(consoleInput);
            result = null;
            if (Int32.TryParse(consoleInput, out Int32 value) || consoleInputIsEmpty)
            {
                if (!consoleInputIsEmpty)
                    result = (EGender)value;
                if (ValueIsInvalid(result, validators))
                    Take(out result, inputPrompt, validators);
                return;                
            }
            ShowInputError("Значення не є цілим числом");
            Take(out result, inputPrompt, validators);
        }
    }
}