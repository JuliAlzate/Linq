// See https://aka.ms/new-console-template for more information
using MiAppConsola;


var games = new List<Game>
{
    new Game { Title = "Halo", Genre = "Racing", ReleaseYear = 2001, Rating = 9.7, Price = 59 },
    new Game { Title = "Gears of War", Genre = "Shooter", ReleaseYear = 2006, Rating = 9.5, Price = 49 },
    new Game { Title = "Forza Horizon 4", Genre = "Racing", ReleaseYear = 2018, Rating = 9.8, Price = 39 },
    new Game { Title = "Minecraft", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.9, Price = 29 },
    new Game { Title = "Sea of Thieves", Genre = "Adventure", ReleaseYear = 2018, Rating = 8.5, Price = 19 }

};

var allGames = games.Select(g => g.Title);
Console.WriteLine("All games:");
foreach (var game in allGames)
{
    Console.Write(game + " ");
}

var RacingGames = games.Where(g => g.Genre == "Racing").Select(g => g.Title);
Console.WriteLine("\n\nRacing games:");
foreach (var game in RacingGames)
{
    Console.Write(game + " ");
}

//var modernGames = games.Where(g => g.ReleaseYear > 2010).Select(g => g.Title);
var modernGames = games.Any(g => g.ReleaseYear > 2010);

Console.WriteLine("\n\nModern games:");
if (modernGames)
{
    Console.WriteLine("There are modern games");
}
else
{
    Console.WriteLine("There are no modern games");
}

var sortGames = games.OrderBy(g => g.ReleaseYear);

Console.WriteLine("Games sorted by release year:");
foreach (var game in sortGames)
{
    Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
}

var priceMax = games.Max(g => g.Price); 
Console.WriteLine($"The most expensive game is {priceMax}");

var min =games.Min(g=>g.Price);

Console.WriteLine($"The cheapest game is {min}");

var promedio = games.Average(g=>g.Price);

Console.WriteLine($"The average price of the games is {promedio}");


var gameByGroup = games.GroupBy(g => g.Genre);

foreach (var group in gameByGroup)
{
    Console.WriteLine($"\n\nGames of the genre {group.Key}:");
    foreach (var game in group)
    {
        Console.WriteLine($"{game.Title} - {game.Genre}");
    }
}  

var budgetGames = games
.Where(g => g.Price < 80 && g.Genre=="Shooter")
.OrderBy(g => g.ReleaseYear)
.Select(g=>$"Title: {g.Title} - Price: {g.Price}");

Console.WriteLine("\n\nBudget shooter games:");
foreach (var game in budgetGames)
{
    Console.WriteLine(game);
}

//Filtra y muestra los títulos de los juegos que tienen una calificación (Rating) mayor a 9.5.

var gamesByRating= games.Where(g=> g.Rating>9.5);

foreach(var game in gamesByRating){

     Console.WriteLine(game.Title);
}

//Cuenta y muestra el número de juegos disponibles para cada género.

var gemesByGender= games.GroupBy(g=>g.Genre);


foreach(var game in gemesByGender){

 Console.WriteLine($"{game.Key}: {game.Count()} games");



}
//version simplificada

games.GroupBy(g => g.Genre)
     .ToList()
     .ForEach(group => Console.WriteLine($"{group.Key}: {group.Count()} games"));



// //Encuentra y muestra el juego más antiguo 
// //y el juego más reciente basándote en el año de lanzamiento
// // (ReleaseYear).

// var latestReleaseYear  = games.Max(g=> g.ReleaseYear);
// var earliestReleaseYear = games.Min(g=> g.ReleaseYear);

//  Console.WriteLine($"latestReleaseYear {latestReleaseYear}");
//   Console.WriteLine($"earliestReleaseYear {earliestReleaseYear}");


//   //Calcula y muestra el precio 
//   //total de todos los juegos pertenecientes al género "Racing".

//   var totalRacing = games.Where(g=>g.Genre=="Racing").Sum(p=>p.Price);


// Console.WriteLine(totalRacing);


// //Calcula la calificación promedio de los juegos agrupados por género y 
// //muestra los resultados ordenados de mayor a menor promedio.


// var gamesByGenre = games.GroupBy(g => g.Genre)
//                         .Select(g => new 
//                         {
//                             Genre = g.Key,
//                             AverageRating = g.Average(p => p.Rating)
//                         })
//                         .OrderByDescending(g => g.AverageRating); // Ordena de mayor a menor

// foreach (var genre in gamesByGenre)
// {
//     Console.WriteLine($"{genre.Genre} - {genre.AverageRating:F2}");
// }


// Enunciado: Calcula la cantidad total de juegos lanzados después del año 2010. 
// Muestra el número total de juegos y los títulos de los juegos que cumplen con esa condición.

var lanzadosdespues2010 = games.Where(g => g.ReleaseYear > 2010).Select(g => g.Title);
Console.WriteLine(lanzadosdespues2010.Count());

foreach (var game in lanzadosdespues2010)
{
    Console.WriteLine(game);
}

// Enunciado: Obtén el juego con la calificación más alta 
// y muestra su título y calificación.

var calificacionMasAlta = games.Where(g => g.Rating == games.Max(g => g.Rating));

foreach (var genre in calificacionMasAlta)
{
    Console.WriteLine($"{genre.Title} - {genre.Rating:F2}");
}






