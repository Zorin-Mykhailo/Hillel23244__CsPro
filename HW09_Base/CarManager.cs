namespace HW09_Base;

public class CarManager<T> where T : Car
{
    public T Car { get; set; }

    public CarManager(T car)
    {
        Car = car;
    }

    public static void Tune<TCar>(TCar car) where TCar : Car
    {
        if (car == null) throw new ArgumentNullException("Car is null");
        car.Name += " TUNED";
    }

    public String GetCarFullInfo()
    {
        String carFullInfo = $"""
            Full info
            - Name:                 {Car.Name}
            - Number of seats:      {Car.NumberOfSeats}
            - Manufacturing date:   {Car.ManufacturingDate:yyyy.MM.dd(dd)}
            - Engine power, Horses: {Car.EnginePower_Horses}
            - Description:          {Car.GetCarDescription()}
            """;
        return carFullInfo;
    }
}
