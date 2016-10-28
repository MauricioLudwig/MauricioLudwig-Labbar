using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.Controllers;
using V3_Laboration5.Models;

namespace V3_Laboration5
{
    class Client
    {

        public void Start()
        {
            BookController books = new BookController();
            MusicController music = new MusicController();

            bool mainMenuLoop = true;
            int option;

            do
            {
                option = UI.MainMenu();

                switch (option)
                {
                    case 1: // Add Media
                        do
                        {
                            option = UI.SubMenu("Add");
                            if (option == 1) // Add Book
                                books.AddBook();
                            else if (option == 2) // Add Music (Song)
                                music.AddSong();
                        } while (option != 3);
                        break;

                    case 2: // Remove Media
                        do
                        {
                            option = UI.SubMenu("Remove");
                            if (option == 1) // Remove Book
                                books.RemoveBook();
                            else if (option == 2) // Remove Music (Song)
                                music.RemoveSong();
                        } while (option != 3);
                        break;

                    case 3: // Edit Media
                        do
                        {
                            option = UI.SubMenu("Edit");
                            if (option == 1) // Edit Book
                                books.EditBook();
                            else if (option == 2) // Edit Music (Song)
                                music.EditSong();
                        } while (option != 3);
                        break;

                    case 4: // Exit Program
                        mainMenuLoop = false;
                        break;
                }

            } while (mainMenuLoop);
        }
    }
}
