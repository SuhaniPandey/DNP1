using System.Collections;
using System.Security.AccessControl;

namespace SumAndQuestionMark;

public class SumRandom
{
    public void GenerateRandomString()
    {
        /*Array randomnumbers = new Array[20];
        Random random = new Random();
        int randomNumber = random.Next(0, 9);
        //Console.WriteLine(randomNumber);
        int numberOfChar = random.Next(0, 26);
        char generateRandomLetters = (char)('a' + numberOfChar);
       // Console.WriteLine(generateRandomLetters);
        string questionMark = "?";

        ArrayList list = new ArrayList();
        list.Add(randomNumber);
        list.Add(generateRandomLetters);
        list.Add(questionMark);

        for (int i = 0; i < randomnumbers.Length; i++)
        {
            randomnumbers = list[random.Next(list.Count)];
        }

    
    */
        var chars = "?abcdefghi?jklmn?opqrs?tuvwx?yz0123?45678?9";
        var stringChars = new char[20];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        var finalString = new String(stringChars);
        Console.WriteLine(finalString);
    }


    
}