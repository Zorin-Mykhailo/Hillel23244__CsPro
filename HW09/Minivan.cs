namespace HW09;

public class Minivan : Car
{
    public Minivan(String name, Int32 numberOfSeats, DateOnly manufacturingDate)
        : base(name, numberOfSeats, manufacturingDate)
    {
    }

    public override int GetNumberOfSeats() => 4;

    public new Int32 GetYear() => base.GetYear() + 1;
        
}
