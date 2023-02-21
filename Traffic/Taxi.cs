namespace TrafficLIght;

public class Taxi
{
    private int id;


    public Taxi(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }

    public void ReactToLight(string color)
    {
        string result = $"Taxi {id} ";
        switch (color)
        {
            case "Green":
                result += " Taxi races across";
                break;
            case "Yellow":
                result += "  Taxi speeds up, crosses while yelling TAXI GREEN";
                break;
            case "Red":
                result += " Taxi slams the breaks and comes to a screeching halt";
                break;
        }

        Console.WriteLine(result);
    }
}