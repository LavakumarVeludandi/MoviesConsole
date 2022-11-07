using MoviesConsole.Models;

namespace MoviesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose an option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 0:
                        Console.WriteLine("Entered case 0");
                        break;
                    default:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                }
            }

            var context = new Movies_W3Context();
            var moviesList = context.Movies.
                                     Where(m => m.MovYear > 1995);
            
            if(!moviesList.Equals(null))
            {
                foreach (var movie in moviesList)
                {
                    Console.WriteLine(movie.MovTitle + " " + movie.MovYear);
                }
            }
        }
    }
}