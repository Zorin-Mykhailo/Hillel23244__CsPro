namespace HW04;

public class User
{
    public String FirstName { get; set; }

    public String LastName { get; set; }

    public Int32? Age { get; init; }

    public EGender? Gender { get; set; }

    public User() => Age = null;

    public User(Int32 age) => Age = age;

    public override string ToString()
    {
        return $"Hi, my name is {FirstName} and last name {LastName}. "
            + (Age == null ? "My age is unknown. " : Age < 10 ? "I am a baby. " : $"I am {Age} years old. ")
            + (Gender == null ? "My gender is unknown." : Gender == EGender.Male ? "I am 🚹 male." : "I am 🚺 female.");
    }
}
