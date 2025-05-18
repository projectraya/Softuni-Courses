using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        public HomeController(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            
            var allBooks = _dbContext.Books.Select(x => new BookViewModel
            {
                Id = x.Id,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                YearPublished = x.YearPublished
            }).ToList();
            var totalBooksCount = _dbContext.Books.Count();
            var latestBook = allBooks[0];
            foreach(var book in allBooks)
            {
                if(book.YearPublished > latestBook.YearPublished)
                {
                    latestBook = book;
                }
            }

            HomePageViewModel model = new HomePageViewModel();
            model.AllBooks = allBooks;
            model.BooksCount = totalBooksCount;
            model.LatestBookTitle = latestBook.Title;

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            
            BookDetailsModel model = new BookDetailsModel();
            var bookWithId = _dbContext.Books
                .Where(x => x.Id == id)
                .Select(x => new BookDetailsModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                    YearPublished = x.YearPublished,
                    AuthorName = x.Author.Name,
                    CategoryName = x.Category.Name

                }).FirstOrDefault();

            model.Id = bookWithId.Id;
            model.ImageUrl = bookWithId.ImageUrl;
            model.Title = bookWithId.Title;
            model.YearPublished = bookWithId.YearPublished;
            model.AuthorName = bookWithId.AuthorName;
            model.CategoryName = bookWithId.CategoryName;

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(BookFormModel formModel)
        {
			// TODO
			Book newBook = new Book()
			{
				Title = formModel.Title,
				ImageUrl = formModel.ImageUrl,
				YearPublished = formModel.YearPublished,

			};
			//trqbva da namerq avtora i kategoriqta v bazata danni i togava da gi zapazq kum knigata

			var allBooksWithGivenTitle = _dbContext.Books.Where(b => b.Title == formModel.Title).ToList();
			if (allBooksWithGivenTitle.Count > 0)
			{
				return ValidationProblem();
			}

			var categories = _dbContext.Categories.Where(c => c.Name == formModel.CategoryName).ToList();
			if (categories.Count == 0) //there aren't any categories with this name
			{
				Category newCategory = new Category();
				newCategory.Name = formModel.CategoryName;

				_dbContext.Categories.Add(newCategory);
				newBook.Category = newCategory;

			}
            else
            {
                newBook.Category = categories.FirstOrDefault();
            }


            var authors = _dbContext.Authors.Where(a => a.Name == formModel.AuthorName).ToList();
			if (authors.Count == 0) //there aren't any authors with this name
			{
				Author newAuthor = new Author();
				newAuthor.Name = formModel.AuthorName;

				_dbContext.Authors.Add(newAuthor);
				newBook.Author = newAuthor;
			}
            else
            {
                newBook.Author = authors.FirstOrDefault();
            }

            _dbContext.Books.Add(newBook);
			_dbContext.SaveChanges();

			return RedirectToAction(nameof(Index), "Home");
		}
        [HttpGet]
        public IActionResult Add()
        {
            return View(CreateDummyViewModel(typeof(BookFormModel)));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // TODO
            return View(CreateDummyViewModel(typeof(BookFormModel)));
        }
        [HttpPost]
        public IActionResult Edit(int id, BookFormModel model)
        {
            //not working
            Book editBook = _dbContext.Books
                .Where(b => b.Id == id)
                .Select(x => x)
                .FirstOrDefault();

			var allBooksWithGivenTitle = _dbContext.Books.Where(b => b.Title == model.Title).ToList();
			if (allBooksWithGivenTitle.Count > 0)
			{
				return ValidationProblem();
			}
			var categories = _dbContext.Categories.Where(c => c.Name == model.CategoryName).ToList();
			if (categories.Count == 0) //there aren't any categories with this name
			{
				Category newCategory = new Category();
				newCategory.Name = model.CategoryName;

				_dbContext.Categories.Add(newCategory);
				editBook.Category = newCategory;

			}
			else
			{
				editBook.Category = categories.FirstOrDefault();
			}


			var authors = _dbContext.Authors.Where(a => a.Name == model.AuthorName).ToList();
			if (authors.Count == 0) //there aren't any authors with this name
			{
				Author newAuthor = new Author();
				newAuthor.Name = model.AuthorName;

				_dbContext.Authors.Add(newAuthor);
				editBook.Author = newAuthor;
			}
			else
			{
				editBook.Author = authors.FirstOrDefault();
			}
            _dbContext.SaveChanges();

			return RedirectToAction(nameof(Index), "Home");
		}

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _dbContext.Books.Where(b => b.Id == id).FirstOrDefault();

            _dbContext.Remove(book);
            if(book.Category.Books == null)
            {
                _dbContext.Categories.Remove(book.Category);
            }

            if(book.Author.Books == null)
            {
                _dbContext.Authors.Remove(book.Author);
            }

            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// This method generates an empty view model according to the given class type.
        /// Feel free to delete it when you no longer need it
        /// </summary>
        /// <param name="type">Type of which to create view model</param>
        /// <returns>An empty view model of a given type</returns>
        private static object CreateDummyViewModel(Type type)
        {
            if (type == typeof(HomePageViewModel))
            {
                return new HomePageViewModel
                {
                    AllBooks = new List<BookViewModel>(),
                    BooksCount = 0,
                    LatestBookTitle = string.Empty
                };
            }
            
            if (type == typeof(BookFormModel))
            {
                return new BookFormModel
                {
                    Title = string.Empty,
                    ImageUrl = string.Empty,
                    YearPublished = 0,
                    AuthorName = string.Empty,
                    CategoryName = string.Empty
                };
            }

            if (type == typeof(BookDetailsModel))
            {
                return new BookDetailsModel
                {
                    Id = 0,
                    Title = string.Empty,
                    ImageUrl = string.Empty,
                    YearPublished = 0,
                    AuthorName = string.Empty,
                    CategoryName = string.Empty
                };
            }

            return null!;
        }
    }
}
