using System;
using System.Collections;

namespace Substitution
{
    public class Program3
    {
        
        public static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

            Console.Write(paragraph);

            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.
        }
        public static string CekValue(string hasil, ArrayList list)
        {  
            foreach(string wrd in list)
            {
            string censorer = "";
            for(int i=0; i<wrd.Length; i++)
                censorer += '*';
            hasil = hasil.Replace(wrd, censorer);
        }

        return hasil;

        }
    }
}
