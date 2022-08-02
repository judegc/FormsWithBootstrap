using MovieDatabaseLab;

var movieList = new List<Movie>();
movieList.Add(new Movie("Star Wars", "scifi"));
movieList.Add(new Movie("Casablanca", "drama"));
movieList.Add(new Movie("The Lion King", "animated"));
movieList.Add(new Movie("E.T. The Extra-Terrestrial", "scifi"));
movieList.Add(new Movie("The Shawshank Redemption", "drama"));
movieList.Add(new Movie("The Truman Show", "drama"));
movieList.Add(new Movie("The Exorcist", "horror"));
movieList.Add(new Movie("Close Encounters of the Third Kind", "scifi"));

Console.WriteLine("Welcome to the movie list application!");

bool shouldContinue = true;

while (shouldContinue)
{
    Console.WriteLine("Enter a category: ");
    string input = Console.ReadLine();

    int movieMatches = 0;

    foreach (var movie in movieList)
    {
        if (movie.Category == input)
        {
            Console.WriteLine(movie.Title);
            movieMatches++;
        }
    }

    if (movieMatches == 0) Console.WriteLine("We don't have any movies in that category");

    Console.WriteLine("Continue? y/n");
    if (Console.ReadLine().ToLower() == "n") shouldContinue = false;
}