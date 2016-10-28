using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.ErrorHandling;
using V3_Laboration5.Esthetics;
using V3_Laboration5.Models;

namespace V3_Laboration5
{
    class UI
    {

        #region Menus
        public static int MainMenu()
        {
            Console.Clear();
            TextAndColor.Header("Media Manager");
            Console.WriteLine("1. Add Media");
            Console.WriteLine("2. Remove Media");
            Console.WriteLine("3. Edit Media");
            Console.WriteLine("4. Exit Program");
            Console.WriteLine();

            return ValidateInput.Integer("Option: ");
        }

        public static int SubMenu(string text)
        {
            Console.Clear();
            TextAndColor.Header(text + ": Choose media type");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Music");
            Console.WriteLine("3. Return");
            Console.WriteLine();

            return ValidateInput.Integer("Option: ");
        }
        #endregion

        #region Add Song
        public static Music AddSong()
        {
            TextAndColor.Header("Insert song details");
            Music newSong = new Music();

            // Artist
            Console.Write("Artist: ");
            newSong.Creator = Console.ReadLine();

            // Song
            Console.Write("Song: ");
            newSong.Title = Console.ReadLine();

            // Length
            newSong.Length = ValidateInput.Integer("Length (in minutes): ");

            // Genre
            TextAndColor.Header("Select genre");
            DisplaySongGenres();
            newSong.Genre = (Music.GenreType)ValidateInput.Integer(1, Enum.GetNames(typeof(Music.GenreType)).Length, "Choice: ");

            return newSong;
        }
        #endregion

        #region Display Song Genres
        public static void DisplaySongGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Music.GenreType)))
            {
                Console.WriteLine("{0} - {1}", (int)genre, genre);
            }
            Console.WriteLine();
        }
        #endregion

        #region Add Book
        public static Book AddBook()
        {
            TextAndColor.Header("Insert book details");
            Book newBook = new Book();

            // Author
            Console.Write("Author: ");
            newBook.Creator = Console.ReadLine();

            // Title
            Console.Write("Title: ");
            newBook.Title = Console.ReadLine();

            // Number of pages
            newBook.Pages = ValidateInput.Integer("Number of pages: ");

            // Genre
            TextAndColor.Header("Select genre");
            DisplayBookGenres();
            newBook.Genre = (Book.GenreType)ValidateInput.Integer(1, Enum.GetNames(typeof(Book.GenreType)).Length, "Choice: ");

            return newBook;
        }
        #endregion

        #region Display Book Genres
        public static void DisplayBookGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Book.GenreType)))
            {
                Console.WriteLine("{0} - {1}", (int)genre, genre);
            }
            Console.WriteLine();
        }
        #endregion

        #region Edit Book Options
        public static string EditBookOptions()
        {
            return String.Format("{0} {1, 20} {2, 20} {3, 20} {4, 20}",
                "1. Author",
                "2. Book Title",
                "3. Pages",
                "4. Genre",
                "5. Return");
        }
        #endregion

        #region Edit Song Options
        public static string EditSongOptions()
        {
            return String.Format("{0} {1, 20} {2, 20} {3, 20} {4, 20}",
                "1. Artist",
                "2. Song Title",
                "3. Length",
                "4. Genre",
                "5. Return");
        }
        #endregion

        #region Confirm Changes Text
        public static void ConfirmChangesText(string text)
        {
            TextAndColor.Green(Environment.NewLine + text);
            Console.WriteLine(Environment.NewLine + "Press enter to continue.");
            Console.ReadKey();
        }
        #endregion
    }
}
