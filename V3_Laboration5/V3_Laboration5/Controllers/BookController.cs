using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.DataStores.Repositories;
using V3_Laboration5.DataStores;
using V3_Laboration5.Models;
using V3_Laboration5.ErrorHandling;
using V3_Laboration5.Esthetics;

namespace V3_Laboration5.Controllers
{
    class BookController
    {

        private IRepository bookRepository = new BookRepository();

        public void AddBook()
        {
            var newBook = UI.AddBook();
            bookRepository.AddMedia(newBook);
            UI.ConfirmChangesText("Book " + newBook.Title + " added.");
        }

        public void RemoveBook()
        {
            if (MediaLists.Books.Count < 1)
            {
                TextAndColor.Red(Environment.NewLine + "No available books.");
                Console.ReadKey();
            }
            else
            {
                int max = bookRepository.PrintList();
                TextAndColor.Header("Select book to remove");
                bookRepository.RemoveMedia(MediaLists.Books[ValidateInput.Integer(1, max, "Nr: ") - 1]);
                UI.ConfirmChangesText("Book removed.");
            }
        }

        public void EditBook()
        {
            if (MediaLists.Books.Count < 1)
            {
                TextAndColor.Red(Environment.NewLine + "No available books.");
                Console.ReadKey();
            }
            else
            {
                int max = bookRepository.PrintList();
                TextAndColor.Header("Select book to edit");
                var book = MediaLists.Books[ValidateInput.Integer(1, max, Environment.NewLine + "Nr: ") - 1];
                int option;

                do
                {
                    Console.Clear();
                    TextAndColor.Header("Selected book: " + book.PrintAttributes());
                    Console.WriteLine(UI.EditBookOptions());
                    option = ValidateInput.Integer(Environment.NewLine + "Change: ");
                    Console.WriteLine();

                    switch (option)
                    {

                        case 1:
                            TextAndColor.White("Author" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, book.Creator);
                            TextAndColor.Green("New value: ");
                            book.Creator = Console.ReadLine();
                            break;
                        case 2:
                            TextAndColor.White("Book" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, book.Title);
                            TextAndColor.Green("New value: ");
                            book.Title = Console.ReadLine();
                            break;
                        case 3:
                            TextAndColor.White("Pages" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, book.Pages);
                            book.Pages = ValidateInput.Integer("New value: ");
                            break;
                        case 4:
                            TextAndColor.White("Genre" + Environment.NewLine);
                            Console.WriteLine("Old value: {0}" + Environment.NewLine, book.Genre);
                            UI.DisplayBookGenres();
                            book.Genre = (Book.GenreType)ValidateInput.Integer(1, Enum.GetNames(typeof(Book.GenreType)).Length, "New value: ");
                            break;
                        case 5:
                            break;
                    }

                } while (option != 5);
            }
        }
    }
}
