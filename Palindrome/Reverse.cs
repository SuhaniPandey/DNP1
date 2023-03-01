using System.Text.RegularExpressions;

namespace Palindrome;

public class Reverse
{
    private string? Sentence { get; set; }

    public Reverse(string? sentence)
    {
        this.Sentence = sentence;
    }

    public bool Palindromes()
    {
        Console.WriteLine(Sentence.ToString());
        
        char[] charArray = Sentence.Replace(" ","").ToCharArray();
       char[] reverseArray =  charArray.Reverse().ToArray();

     
           for (int i = 0; i < charArray.Length; i++)
           {
               if (charArray[i] != reverseArray[i])
               {
                   return false;
               }
           }

           return true;
    }
       
       

    }
    
    //public bool IsPalindrome()
   // {
        //first reverse the string
     //   string reversedString = new string(sentence.Reverse().ToArray());
     //   return string.Compare(sentence, reversedString) == 0 ? true : false;
    //}
