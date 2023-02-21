namespace TrafficLIght;

public class Car
{
    private int id; 
    public Car(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    private void ReactToLight(string color)
    {
        string result = $"Car {id} ";
        switch (color)
        {
            case "Green":
                result += " drives";
                break;
            case "Yellow":
                result += " slows";
                break;
            case "Red":
                result += " stops";
                break;
        }
        Console.WriteLine(result);
    }
}