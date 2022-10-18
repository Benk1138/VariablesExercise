namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string dogName; //Decleration syntax

            dogName = "Fido";

            int dogAge = 7;

            char firstInitial = 'F';
            bool isHappy = true;
            double dogWeight = 30;
            decimal dogHeight = 12.5m;

            Console.WriteLine($"My Dog's Name Is {dogName}. He's {dogAge} years old, and is {dogWeight} pounds and he is {dogHeight} inches tall");
        }


    }

}
