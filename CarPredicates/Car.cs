namespace CarPredicates;

public class Car
{
    private string? Color { get; set; }
    private int EngineSize { get; set; }
    private int FuelEconomy { get; set; }
    private bool? IsManualShift { get; set; }

    public Car(string? color, int engineSize, int fuelEconomy, bool? isManualShift)
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
        string[] listOfColors = new[] { "Blue", "Green", "Red", "Yellow" };
        int[] engineSize = new[] { 100, 200, 300 };
        int[] fuelEconomy = new[] { 1, 2, 3, 4, 5 };
        bool[] isManualShift = new[] { true, false };
        Random random = new Random();
        
        cars.Add(new Car(listOfColors(listOfColors.),engineSize.Length,fuelEconomy.Length,isManualShift.Length));
    }
}