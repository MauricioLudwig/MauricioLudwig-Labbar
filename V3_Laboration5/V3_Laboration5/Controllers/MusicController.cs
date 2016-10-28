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
    class MusicController
    {

        private IRepository musicRepository = new MusicRepository();

        public void AddSong()
        {
            var newSong = UI.AddSong();
            musicRepository.AddMedia(newSong);
            UI.ConfirmChangesText("Song " + newSong.Title + " added.");
        }

        public void RemoveSong()
        {
            if (MediaLists.Music.Count < 1)
            {
                Esthetics.TextAndColor.Red(Environment.NewLine + "No available music.");
                Console.ReadKey();
            }
            else
            {
                int max = musicRepository.PrintList();
                musicRepository.RemoveMedia(MediaLists.Music[ValidateInput.Integer(1, max, "Nr: ") - 1]);
                UI.ConfirmChangesText("Song removed.");
            }
        }

        public void EditSong()
        {
            if (MediaLists.Music.Count < 1)
            {
                Esthetics.TextAndColor.Red(Environment.NewLine + "No available music.");
                Console.ReadKey();
            }
            else
            {
                int max = musicRepository.PrintList();
                TextAndColor.Header("Select song to edit");
                var song = MediaLists.Music[ValidateInput.Integer(1, max, Environment.NewLine + "Nr: ") - 1];
                int option;

                do
                {
                    Console.Clear();
                    TextAndColor.Header("Selected song: " + song.PrintAttributes());
                    Console.WriteLine(UI.EditSongOptions());
                    option = ValidateInput.Integer(Environment.NewLine + "Change: ");
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            TextAndColor.White("Artist" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, song.Creator);
                            TextAndColor.Green("New value: ");
                            song.Creator = Console.ReadLine();
                            break;
                        case 2:
                            TextAndColor.White("Song" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, song.Title);
                            TextAndColor.Green("New value: ");
                            song.Title = Console.ReadLine();
                            break;
                        case 3:
                            TextAndColor.White("Length" + Environment.NewLine);
                            Console.Write("Old value: {0}" + Environment.NewLine, song.Length);
                            song.Length = ValidateInput.Integer("New value: ");
                            break;
                        case 4:
                            TextAndColor.White("Genre" + Environment.NewLine);
                            Console.WriteLine("Old value: {0}" + Environment.NewLine, song.Genre);
                            UI.DisplaySongGenres();
                            song.Genre = (Music.GenreType)ValidateInput.Integer(1, Enum.GetNames(typeof(Music.GenreType)).Length, "New value: ");
                            break;
                        case 5:
                            break;
                    }

                } while (option != 5);
            }
        }
    }
}
