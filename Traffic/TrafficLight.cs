namespace TrafficLIght;

public class TrafficLight
{
    public Action<string>? OnLightChange { get; set; }

    private string[] colors = { "Green", "Yellow", "Red" };

    public void RunTrafficLight()
    {
        for (int i = 0; i < 12; i++)
        {
            int idx = i % colors.Length;
            Console.WriteLine("Light is "+ colors[idx]);
            OnLightChange?.Invoke(colors[idx]);
            Thread.Sleep(1000);
        }
    }
    
    
}