using System;

namespace DraftRandomizer
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 1;
            string[] DraftMembers = { "Bandari", "Corey", "Demar", "Jelani", "Jhuvy", "Kheemy", "Kishane", "Raheem" }; //Array containing participants of draft
            Shuffle(DraftMembers); //Calling Shuffle function
            foreach (string value in DraftMembers) //foreach loop to display final order of participants
            {
                Console.WriteLine("Number " + count + " pick is " + value);
                count++;
            }
        }
   
        public static void Shuffle <RandArray>(RandArray[] arr) //Shuffles array at random 
        {
            int n = arr.Length;
            Random num = new Random();
            for (int i =0; i < n; i++)
            {
                int x = i + num.Next(n - i);
                RandArray temp = arr[x];
                arr[x] = arr[i];
                arr[i] = temp;
            }
          
        } 
    }
    
}
