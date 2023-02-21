namespace TrafficLIght;

public class Pedestrian
{
    private int id;

    public Pedestrian(TrafficLight tl,int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;

    }

    public void ReactToLight(string color)
    {
        string result = "Pedestrian "+id;
        switch (color)
        {
            case "Green":
                result += " The Pedestrian stops";
                break;
            case "Yellow":
                result += " The Pedestrian is ready to walk now";
                break;
            case "Red":
                result += " The Pedestrian Walks nowwwww";
                break;
        }
        Console.WriteLine(result);
    }
}