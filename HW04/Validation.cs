namespace HW04
{
    public static class Validation
    {
        private static readonly HashSet<Char> AuxilaryLetters;

        static Validation()
        {
            AuxilaryLetters = new (){ 'І', 'і' };
        }

        public static String ContainsOnlyLetters(String value)
        {
            foreach(Char c in AuxilaryLetters)
            {
                if (Char.IsLetter(c)) continue;
                if (AuxilaryLetters.Contains(c)) continue;
                return $"{c} не літера";
            }
            return String.Empty;
            //return value.All(ch => Char.IsLetter(ch) || AuxilaryLetters.Contains(ch)) ? String.Empty : "Значення повинно містити виключно літери";
        }

        public static String IsNotEmpty(String value) =>
            !String.IsNullOrWhiteSpace(value) ? String.Empty : "Значення не повинно бути порожньою стрічкою";

        public static String IsNotEmpty(Int32? value) =>
            value != null ? String.Empty : "Значення не повинно бути порожнім";

        public static String IsGreatherOrEqualThanMinAge(Int32? value)
            => value == null || value >= 0 ? String.Empty : "Вік повинен бути >= 0";

        public static String IsLessOrEqualThanMaxAge(Int32? value)
            => value == null || value <= 120 ? String.Empty : "Вік повинен бути <= 120";

        public static String IsAcceptableValue(EGender? value)
        {
            if(value == null) return String.Empty;
            HashSet<Int32> acceptableValues = new (Enum.GetValues<EGender>().Cast<Int32>());            
            return acceptableValues.Contains((Int32)value) ? String.Empty : $"Значення повинно бути одним із послідовності [{String.Join(", ", acceptableValues)}]";
        }
    }
}