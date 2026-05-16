
using Cinema.Domain.Entities;
using Cinema.Domain.Repository;

ICinemaRepository repository = new CinemaRepository();
IMovieCategoryRepository categoryRepository = new MovieCategoryRepository();

var movie1 = new Movie()
{
    Id = 1,
    Description = "Terminator opis",
    DurationInMinutes = 90,
    Name = "Terminator",
    Category = categoryRepository.GetMovieCategyByName("Historyczny"),
    Rating = 5,
    Year = 2001,
};

var movie2 = new Movie()
{
    Id = 2,
    Description = "Rocky opis",
    DurationInMinutes = 120,
    Name = "Rocky",
    Category = categoryRepository.GetMovieCategyByName("Historyczny"),
    Rating = 4.5,
    Year = 1995,
};

repository.Add(movie1);
repository.Add(movie2);


foreach(var movie in repository.GetMovies())
{
    Console.WriteLine("Nazwa filmu: " + movie.Name);
    Console.WriteLine("Rok: " + movie.Year);
    Console.WriteLine("Opis: " + movie.Description);
    Console.WriteLine("Czas trwania: " + movie.DurationInMinutes);
    Console.WriteLine("Ocena: " + movie.Rating);
    Console.WriteLine("Kategoria: " + movie.Category.Name);
    Console.WriteLine("\n\n____________________________________");
}
