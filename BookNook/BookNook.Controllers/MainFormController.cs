using System;
using BookNook.Base;
using BookNook.DomainModel.Repositories;
using BookNook.DomainModel;

namespace BookNook.Controllers
{
    public class MainFormController : IMainController
    {
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory _formsFactory = null;
		private readonly IReadRepository _readRepository = null;
		private readonly ITBRRepository _tbrRepository = null;
		private readonly IOwnedRepository _ownedRepository = null;
		private readonly ILibraryRepository _libraryRepository = null;
		private readonly IWishlistRepository _wishlistRepository = null;

		public MainFormController(IWindowFormsFactory inFormFactory, IReadRepository inReadRepo, ITBRRepository inTBRRepo, IOwnedRepository inOwnedRepo, ILibraryRepository inLibraryRepo, IWishlistRepository inWishlistRepo)
		{
			_formsFactory = inFormFactory;
			_readRepository = inReadRepo;
			_tbrRepository = inTBRRepo;
			_ownedRepository = inOwnedRepo;
			_libraryRepository = inLibraryRepo;
			_wishlistRepository = inWishlistRepo;
		}
		public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
				_readRepository.AddBookRead(new BookRead("It", "Stephen King", "Hodder", DateTime.Now, 1486, "horror", DateTime.Now, 5)) ;
				_readRepository.AddBookRead(new BookRead("Gone Girl", "Gillian Flynn", "Fraktura", DateTime.Now, 452, "thriller", DateTime.Now, 4));
				_readRepository.AddBookRead(new BookRead("It Ends WIth Us", "Colleen Hoover", "Atria", DateTime.Now, 341, "romance", DateTime.Now, 5));

				_tbrRepository.AddBookTBR(new BookTBR("Misery", "Stephen King", "Hodder", DateTime.Now, 410, "horror", "Ira"));
				_tbrRepository.AddBookTBR(new BookTBR("Little Fires Everywhere", "Celeste Ng", "Mozaik", DateTime.Now, 347, "literary fiction", "Tea"));

				_ownedRepository.AddBookOwned(new BookOwned("The Boy in the Headlights", "Samuel Bjork", "Znanje", DateTime.Now, 423, "crime", decimal.Parse("27.99"), "Tisak Media", false));
				_ownedRepository.AddBookOwned(new BookOwned("Bird Box", "Josh Malerman", "Hodder", DateTime.Now, 423, "horror", decimal.Parse("49.90"), "Book Depository", true));

				_libraryRepository.AddBookLibrary(new BookLibrary("Alive", "Anna Starobinets", "Hangar7", DateTime.Now, 298, "science fiction", DateTime.Now, DateTime.Now, "Gradska knjižnica Virovitica"));

				_wishlistRepository.AddBookWishlist(new BookWishlist("Anxious People", "Fredrik Backman", "Fokus", DateTime.Now, 423, "literary fiction", decimal.Parse("89")));
				_wishlistRepository.AddBookWishlist(new BookWishlist("Kill Creek", "Scott Thomas", "Atria", DateTime.Now, 501, "horror", decimal.Parse("120")));

				_defaultModelLoaded = true;
			}
		}

		public void AddBookRead()
		{
			var readController = new ReadController();

			var newFrm = _formsFactory.CreateAddNewReadBookView();

			readController.AddNewReadBook(newFrm, _readRepository);
		}

		public void ShowReadBooks()
		{
			var readController = new ReadController();

			var newFrm = _formsFactory.CreateShowReadBookListView();

			readController.ViewReadBooks(newFrm, _readRepository, this);
		}

		public void AddBookTBR()
		{
			var tbrController = new TBRController();

			var newFrm = _formsFactory.CreateAddNewTBRBookView();

			tbrController.AddNewTBRBook(newFrm, _tbrRepository);
		}

		public void ShowTBRBooks()
		{
			var tbrController = new TBRController();

			var newFrm = _formsFactory.CreateShowTBRBookListView();

			tbrController.ViewTBRBooks(newFrm, _tbrRepository, this);
		}

		public void AddBookOwned()
		{
			var ownedController = new OwnedController();

			var newFrm = _formsFactory.CreateAddNewOwnedBookView();

			ownedController.AddNewOwnedBook(newFrm, _ownedRepository);
		}

		public void ShowOwnedBooks()
		{
			var ownedController = new OwnedController();

			var newFrm = _formsFactory.CreateShowOwnedBookListView();

			ownedController.ViewOwnedBooks(newFrm, _ownedRepository, this);
		}

		public void AddBookLibrary()
		{
			var libraryController = new LibraryController();

			var newFrm = _formsFactory.CreateAddNewLibraryBookView();

			libraryController.AddNewLibraryBook(newFrm, _libraryRepository);
		}

		public void ShowLibraryBooks()
		{
			var libraryController = new LibraryController();

			var newFrm = _formsFactory.CreateShowLibraryBookListView();

			libraryController.ViewLibraryBooks(newFrm, _libraryRepository, this);
		}

		public void AddBookWishlist()
		{
			var wishlistController = new WishlistController();

			var newFrm = _formsFactory.CreateAddNewWishlistBookView();

			wishlistController.AddNewWishlistBook(newFrm, _wishlistRepository);
		}

		public void ShowWishlistBooks()
		{
			var wishlistController = new WishlistController();

			var newFrm = _formsFactory.CreateShowWishlistBookListView();

			wishlistController.ViewWishlistBooks(newFrm, _wishlistRepository, this);
		}
	}
}
