namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't like Math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "p.e.":
                case "pe":
                case "physical education":
                    Console.WriteLine("P.E. is fun");
                    break;
                case "history":
                    Console.WriteLine("History is boring!");
                    break;
                case "social studies":
                    Console.WriteLine("I like Social Studies too!");
                    break;
                default:
                    Console.WriteLine("I like that too.");
                    break;
            }
        }
    }
}