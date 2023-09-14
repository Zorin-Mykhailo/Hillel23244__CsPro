namespace HW04
{
    public static class ConsoleInput
    {
        private static String? GetConsoleInput(String inputPrompt)
        {
            Console.Write(inputPrompt);
            return Console.ReadLine();
        }

        public static Boolean Take(String inputPrompt, out String result)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            if (consoleInput != null)
            {
                result = consoleInput;
                return true;
            }
            result = String.Empty;
            return false;
        }

        public static Boolean Take(String inputPrompt, out Int32? result)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            if (Int32.TryParse(consoleInput, out Int32 inputValue))
            {
                result = inputValue;
                return true;
            }
            result = null;
            return false;
        }

        public static Boolean Take(String inputPrompt, out EGender? result)
        {
            String? consoleInput = GetConsoleInput(inputPrompt);
            if (Int32.TryParse(consoleInput, out Int32 inputValue))
            {
                EGender? gender = inputValue == 0 ? EGender.Female : inputValue == 1 ? EGender.Male : null;
                result = gender;
                return result != null;
            }
            result = null;
            return false;
        }
    }
}