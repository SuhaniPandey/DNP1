namespace CarPredicates;

public class Car
{
    private string? Color { get; set; }
    private string? EngineSize { get; set; }
    private int FuelEconomy { get; set; }
    private bool? IsManualShift { get; set; }

    public Car(string? color, string? engineSize, int fuelEconomy, bool? isManualShift)
    {
        Color = color;
        EngineSize = engineSize;
        FuelEconomy = fuelEconomy;
        IsManualShift = isManualShift;
    }

    public override string ToString()
    {
        return $"Color:{Color}\tEngine Size:{EngineSize}\tFuelEconomy:{FuelEconomy}\tIsmanualshift:{IsManualShift}";
    }

    public void GetListOfType(List<Car> cars, string color)
    {
        Console.WriteLine("Cars of color "+color);
        IEnumerable<Car> typesOfCar =cars.Where(car => car.Color.Equals(color));
        Console.WriteLine(cars.ToString());
    }
}