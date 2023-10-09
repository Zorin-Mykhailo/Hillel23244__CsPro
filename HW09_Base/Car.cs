namespace HW09_Base;

public abstract class Car
{
    public abstract Int32 EnginePower_Horses { get; set; }

    public String Name { get; set; }

    public Int32 NumberOfSeats { get; set; }

    public DateOnly ManufacturingDate { get; set; }

    public Car(String name, int numberOfSeats, DateOnly manufacturingDate)
    {
        Name = name;
        NumberOfSeats = numberOfSeats;
        ManufacturingDate = manufacturingDate;
    }

    public abstract String GetCarDescription();

    public virtual Int32 GetNumberOfSeats() => NumberOfSeats;

    public Int32 GetYear() => ManufacturingDate.Year;

    public override String ToString() => Name;
}
