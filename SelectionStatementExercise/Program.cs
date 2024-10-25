namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); //This line creates a new `Random` object, which is used to generate random numbers.
            int favNumber = random.Next(1, 11);  //This line generates a random integer between 1 and 11 and assigns it to the `favNumber` variable.
            int response = 0;


            while (response != favNumber) 
            {
                Console.WriteLine("Guess my favorite number(It's between 1-10):");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine($"You guessed correctly!!!\nThe number was {favNumber}!");
                }
            }

           
        }
    }
}
