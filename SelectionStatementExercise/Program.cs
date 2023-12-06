namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber) 
            {
                Console.WriteLine("You guessed too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("You guessed too high.");
            }
            else
            {
                Console.WriteLine("Ayyyy, you got it!");
            }
            
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            //I'm not totally sure why, and google can't seem to be helping, but my command window auto closes in VS code so I have to add likes like the above two
        }
    }
}
