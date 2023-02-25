namespace BirdWatcher;

public class Bird
{
    public Action<string>? OnBehaviourChange { get; set; }

    private string[] behaviour = { "flaps wings", "sings", "dance" };

    public void ChangeBehaviour()
    {
        for (int i = 0; i < 12; i++)
        {
            int idx = i % behaviour.Length;
            Console.WriteLine("\tWatcherWatcherNamespace Bird "+ behaviour[idx]);
            OnBehaviourChange?.Invoke(behaviour[idx]);
            Thread.Sleep(1000);
        }
    }
}