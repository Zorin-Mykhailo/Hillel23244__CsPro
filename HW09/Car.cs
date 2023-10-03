namespace HW09;

public abstract class Car
{
    public String Name { get; set; }

    public Int32 NumberOfSeats { get; set; }

    public DateOnly ManufacturingDate { get; set; }

    public Car(String name, int numberOfSeats, DateOnly manufacturingDate)
    {
        Name = name;
        NumberOfSeats = numberOfSeats;
        ManufacturingDate = manufacturingDate;
    }

    public virtual Int32 GetNumberOfSeats() => NumberOfSeats;

    public Int32 GetYear() => ManufacturingDate.Year;

    public override string ToString() => Name;
}
