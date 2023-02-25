namespace DoctorsWaitingRoom;

public class WaitingRoom
{
    public Action<int>? NumberChange { get; set; }
    private int currentNumber;
    private int ticketCount;

    public void RunWaitingRoom()
    {
        
            while (currentNumber< ticketCount)
            {
                Console.WriteLine("Ding ");
                NumberChange?.Invoke(currentNumber);
                currentNumber++;
                Console.WriteLine("the patient "+currentNumber+"can now enter");
                Thread.Sleep(1000);
            }
    }

    public int DrawNumber()
    {
        return ++ticketCount;
    }


}