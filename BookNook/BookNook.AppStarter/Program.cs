using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using BookNook.Controllers;
using BookNook.PresentationLayer;
using BookNook.MemoryBasedDAL;

namespace BookNook.AppStarter
{
	public static class Program
	{
		
		[STAThread]
		public static void Main()
		{
			WindowFormsFactory _formsFactory = new WindowFormsFactory();
			
			ReadRepository _readRepo = new ReadRepository();
			TBRRepository _tbrRepo = new TBRRepository();
			OwnedRepository _ownedRepo = new OwnedRepository();
			LibraryRepository _libraryRepo = new LibraryRepository();
			WishlistRepository _wishlistRepo = new WishlistRepository();
			
			MainFormController mainController = new MainFormController(_formsFactory, _readRepo, _tbrRepo, _ownedRepo, _libraryRepo, _wishlistRepo);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BookNook.PresentationLayer.frmMainWindow(mainController));
		}
	}
}
