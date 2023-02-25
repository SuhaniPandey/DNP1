namespace DoctorsWaitingRoom;

public class Patient
{
    private int queueNumber;
    public Patient(WaitingRoom waitingRoom)
    {
        queueNumber = waitingRoom.DrawNumber();
        waitingRoom.NumberChange += ReactToChange;
    }

    public void ReactToChange(int currentNumber)
    {
        Console.WriteLine("Patient "+queueNumber+" looks up");
        if (queueNumber==currentNumber)
        {
            Console.WriteLine("Patient "+queueNumber+" Goes to doctor´s office");
        }
        else
        {
            Console.WriteLine("Patient "+queueNumber+" goes back to looking his phone");
        }
    }
}