using Cinema.Data;
using Cinema.Data.Models;
using Cinema.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaDbContext _dbContext;

        public MovieController(CinemaDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var alllMovies = _dbContext.Movies
             .Select(x => new MovieViewModel
             {
                Id = x.Id,
                Title = x.Title,
                YearPublished = x.YearReleased,
                Poster = x.Poster,
                Likes = x.Likes,
                
            })
            .ToList();
			if(alllMovies == null)
            {
                return NotFound();
            }

			var topGenre = _dbContext.Genres
                .Select(x => new
                {
                    Name = x.Name,
                    Movies = x.Movies.OrderByDescending(m => m.Likes).ToList()
                }).ToList().FirstOrDefault();

            var topDirector = _dbContext.Directors
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Movies = x.Movies.OrderByDescending(m => m.Likes).ToList()
                }).ToList().FirstOrDefault();

            if(topDirector == null || topGenre == null)
            {
                return NotFound();
            }
           
            IndexViewModel model = new IndexViewModel
            {
                AllMovies = alllMovies,
                TotalMoviesCount = alllMovies.Count,
                LatestMovieTitle = alllMovies.OrderByDescending(x => x.YearPublished).FirstOrDefault()!.Title,
                OldestMovieTitle = alllMovies.OrderBy(x => x.YearPublished).FirstOrDefault()!.Title,
                MostLikedMovieTitle = alllMovies.OrderByDescending(x => x.Likes).FirstOrDefault()!.Title,
                MostLikedGenre = topGenre.Name,
                MostLikedDirector = $"{topDirector.FirstName} {topDirector.LastName}"
			};

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var movieGivenId = _dbContext.Movies.Where(x => x.Id == id)
                .Include(x => x.Director)
                .Include(x => x.Genre)
                .Select(x => new MovieDetailsModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Poster = x.Poster,
                    Description = x.Description,
                    Likes = x.Likes,
                    YearPublished = x.YearReleased,
                    GenreName = x.Genre.Name,
                    DirectorFullName = $"{x.Director.FirstName} {x.Director.LastName}"

                }).ToList().FirstOrDefault();

            if(movieGivenId == null)
            {
                return NotFound();
            }

            return View(movieGivenId);
        }

        [HttpGet]
        public IActionResult Like(int id)
        {
            var movieGivenId = _dbContext.Movies.Where(x => x.Id == id).ToList().FirstOrDefault();
            
            if(movieGivenId == null)
            {
                return NotFound();
            }

            var likes = movieGivenId.Likes;
            likes++;

            movieGivenId.Likes = likes;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Dislike(int id)
        {
			var movieGivenId = _dbContext.Movies.Where(x => x.Id == id).ToList().FirstOrDefault();

			if (movieGivenId == null)
			{
				return NotFound();
			}

			var likes = movieGivenId.Likes;
			likes--;

			movieGivenId.Likes = likes;
			_dbContext.SaveChanges();

			return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(MovieFormModel model)
        {
            Movie brandNewMovie = new Movie
            {
                Title = model.Title,
                Poster = model.Poster,
                YearReleased = model.YearPublished,
                Description = model.Description,
                Likes = 0,

            };


            var allMovies = _dbContext.Movies
                .Include(x => x.Genre)
                .Include(x => x.Director).ToList();
                
            if(allMovies.Any(x => x.Title == model.Title))
            {
                return Forbid();
            }

            

            if(allMovies.Any(x => x.Genre.Name == model.GenreName)) //if there is such genre
            {
                //add the movie to the genre's collection
                _dbContext.Genres.Where(x => x.Name == model.GenreName).FirstOrDefault()!.Movies.Add(brandNewMovie);
            }
            else
            {
                //create the genre and add the movie to its collection
                Genre brandNewGenre = new Genre
                {
                    Name = model.GenreName
                };
                brandNewGenre.Movies.Add(brandNewMovie);
                _dbContext.Genres.Add(brandNewGenre);
                
            }

			if (allMovies.Any(x => $"{x.Director.FirstName} {x.Director.LastName}" == model.DirectorFullName))
            {
				//add the movie to the director's collection
				_dbContext.Directors.Where(x => $"{x.FirstName} {x.LastName}" == model.DirectorFullName).FirstOrDefault()!.Movies.Add(brandNewMovie);
			}
            else
            {
                //create the director and add the movie to its collection
                Director brandNewDirector = new Director
                {
                    FirstName = model.DirectorFullName.Split(" ")[0],
                    LastName = model.DirectorFullName.Split(" ")[1]
                };
                brandNewDirector.Movies.Add(brandNewMovie);
                _dbContext.Directors.Add(brandNewDirector);
            }

            //add the movie to movies database
            _dbContext.Movies.Add(brandNewMovie);
            _dbContext.SaveChanges();

			return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movieGivenId = _dbContext.Movies
                .Where(x => x.Id == id)
                .Select(x => new MovieFormModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Poster = x.Poster,
                    Description = x.Description,
                    YearPublished = x.YearReleased,
                    GenreName = x.Genre.Name,
                    DirectorFullName = $"{x.Director.FirstName} {x.Director.LastName}"
                })
                .ToList()
                .FirstOrDefault();

			if (movieGivenId == null)
			{
				return NotFound();
			}

			return View(movieGivenId);
        }
        [HttpPost]
		public IActionResult Edit(int id, MovieFormModel formModel)
		{
            var theMovie = _dbContext.Movies
                .Where(x => x.Id == id).ToList().FirstOrDefault();
			
			var allMovies = _dbContext.Movies
				.Include(x => x.Genre)
				.Include(x => x.Director)
                .ToList();

			if (theMovie == null)
			{
				return NotFound();
			}

			if (theMovie.Title != formModel.Title)
            {
				if (allMovies.Any(x => x.Title == formModel.Title))
				{
					return Forbid();
				}
			}
			

			if (allMovies.Any(x => x.Genre.Name == formModel.GenreName)) //if there is such genre
			{
				//add the movie to the genre's collection
				_dbContext.Genres
                    .Where(x => x.Name == formModel.GenreName)
                    .FirstOrDefault()!
                    .Movies.Add(theMovie);
			}
			else
			{
				//create the genre and add the movie to its collection
				Genre brandNewGenre = new Genre
				{
					Name = formModel.GenreName
				};
				brandNewGenre.Movies.Add(theMovie);
				_dbContext.Genres.Add(brandNewGenre);

			}
            

			if (allMovies.Any(x => x.Director.FirstName + x.Director.LastName == formModel.DirectorFullName))
			{
				//add the movie to the director's collection
				_dbContext.Directors.Where(x => $"{x.FirstName} {x.LastName}" == formModel.DirectorFullName).FirstOrDefault()!.Movies.Add(theMovie);
			}
			else
			{
				//create the director and add the movie to its collection
				Director brandNewDirector = new Director
				{
					FirstName = formModel.DirectorFullName.Split(" ")[0],
					LastName = formModel.DirectorFullName.Split(" ")[1]
				};
				brandNewDirector.Movies.Add(theMovie);
				_dbContext.Directors.Add(brandNewDirector);
			}

            theMovie.Title = formModel.Title;
            theMovie.Poster = formModel.Poster;
            theMovie.YearReleased = formModel.YearPublished;
            theMovie.Likes = 0;
            theMovie.Description = formModel.Description;

            _dbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
        public IActionResult Delete(int id)
        {
			var theMovie = _dbContext
                .Movies
                .Include(x => x.Genre)
                .Include(x => x.Director)
				.Where(x => x.Id == id).ToList().FirstOrDefault();

            if(theMovie == null)
            {
                return NotFound();
            }

            if(theMovie.Likes > 500)
            {
                return Unauthorized();
            }

            _dbContext.Movies.Remove(theMovie);
            _dbContext.SaveChanges();

            if(_dbContext.Genres.Any(x => x.Movies.Count == 0))
            {
                _dbContext.Genres.Remove(_dbContext.Genres.Where(x => x.Movies.Count == 0).ToList().FirstOrDefault()!);

			}
			if (_dbContext.Directors.Any(x => x.Movies.Count == 0))
			{
				_dbContext.Directors.Remove(_dbContext.Directors.Where(x => x.Movies.Count == 0).ToList().FirstOrDefault()!);

			}

            _dbContext.SaveChanges();
			return RedirectToAction("Index");
		}
    }
}
