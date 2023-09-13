namespace HW04;

public class User
{
    public String FirstName { get; set; }

    public String LastName { get; set; }

    public Int32? Age { get; }

    public EGender Gender { get; set; }

    public User()
    {
        Age = null;
    }

    public User(Int32 age)
    {
        Age = age;
    }
}
