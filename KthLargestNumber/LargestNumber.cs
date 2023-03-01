namespace KthLargestNumber;

public class LargestNumber
{

    public void Largest(int[] ints, int k)
    {
        if (k > ints.Length)
        {
            throw new Exception("value is larger than array size---");
        }
        else
        {
            int[] descending = ints.OrderDescending().ToArray();//order the number in descending form
            int[] ignoreRepeats = descending.Distinct().ToArray();//ignore the repeated numbers
            Console.WriteLine("These are the numbers:");
            Array.ForEach(ignoreRepeats, Console.WriteLine);//prints all the numbers
            Console.WriteLine($"The {k}th largest number is:");
            Console.WriteLine(ignoreRepeats[k-1]);//prints the value in k-1 index as index starts from 0
        }
    }
}