using MoviesConsole.Models;

namespace MoviesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Movies_W3Context();
            var moviesList = context.Movies;
            foreach (var movie in moviesList)
            {
                Console.WriteLine(movie.MovTitle +" "+ movie.MovYear);
            }
        }
    }
}