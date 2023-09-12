namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("matta in en heltal");
            int num;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(),out num)) 
                {
                    break;
                }
                Console.WriteLine("ogiltigt heltal");
            }
            string input = Console.ReadLine();
            
            Console.WriteLine(num);

            if (num > 10) // If sats
                Console.WriteLine("Talet är stort");
            else
                Console.WriteLine("Oj. Lågt tal!");

            Console.WriteLine(" Skriv in ditt namn");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name);
            for(int i =0; i <= 11; i++) // for lopp
            {
                Console.WriteLine(i);

            }
        }
    }
}