using HW09_Base;

namespace HW09;

public class Minivan : Car
{
    public Minivan(String name, Int32 numberOfSeats, DateOnly manufacturingDate, Int32 enginePower_Horses)
        : base(name, numberOfSeats, manufacturingDate)
    {
        EnginePower_Horses = enginePower_Horses;
    }

    public override int EnginePower_Horses { get; set; }

    public override string GetCarDescription()
        => $"Легковий автомобіль з однооб'ємним кузовом та безкапотною компоновкою. Зазвичай, цей тип автомобіля має три ряди сидінь.";

    public override int GetNumberOfSeats() => 4;

    public new Int32 GetYear() => base.GetYear() + 1;

    public override string ToString() => $"{Name} ({EnginePower_Horses} л.с.)";
}
