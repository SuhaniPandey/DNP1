namespace BirdWatcher;

public class Observer
{
    private int id;

    public Observer(Bird bird,int id)
    {
        this.id = id;
        bird.OnBehaviourChange += ReactToChange;
    }

    public void ReactToChange(string behavior)
    {
        string result = $"People {id} ";
        switch (behavior)
        {
            case "dance":
                result += " Wow! what a dance";
                break;
            case "sings":
                result += "  Pleasure to ear";
                break;
            case "flaps wings":
                result += "I wish i had a wing like that";
                break;
        }

        Console.WriteLine(result);
    }
}