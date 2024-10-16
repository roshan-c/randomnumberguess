namespace RandomNumberGuess;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Random rd = new Random();

        int randNum = rd.Next(1, 10);

        Console.WriteLine("A random number has been generated");
        Console.WriteLine("You must guess what that number is");
        Console.WriteLine("Enter your guess: ");
        int guess = Convert.ToInt32(Console.ReadLine());

        do
        {
            if (guess > randNum)
            {
                Console.WriteLine("Your guess is too high");
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            else if (guess < randNum)
            {
                Console.WriteLine("Your guess is too low");
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            
        } while (guess != randNum);
        
        if (guess == randNum)
        {
            Console.WriteLine("Congratulations! You guessed the correct number");
            Console.ReadLine();
        }
        
    }
}