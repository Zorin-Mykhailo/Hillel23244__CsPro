namespace HW04;

public enum EGender : Int32
{
    Female = 0,
    Male = 1,
}


public interface IEmployee
{
    string Name { get; set; }
}