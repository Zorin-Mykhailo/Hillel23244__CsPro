namespace HW04
{
    public static class Validation
    {
        public static String ContainsOnlyLetters(String value)
            => value.All(ch => Char.IsLetter(ch)) ? String.Empty : "Значення повинно містити виключно літери";

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
            return Enum.IsDefined<EGender>((EGender)value) ? String.Empty 
                : $"Значення повинно бути одним із послідовності [{String.Join(", ", Enum.GetValues<EGender>().Cast<Int32>())}]";
        }
    }
}