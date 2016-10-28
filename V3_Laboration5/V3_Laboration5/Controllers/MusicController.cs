using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.DataStores.Repositories;
using V3_Laboration5.DataStores;
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
            newSong.UniqueID = String.Format("M{0}", (MediaLists.Music.Count + 1).ToString());
            musicRepository.AddMedia(newSong);
            UI.ChangesValidation("Song " + newSong.UniqueID + " added.");
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
                UI.ChangesValidation("Song removed.");
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
                            Console.WriteLine("Old value: {0}" + Environment.NewLine, song.Title);
                            TextAndColor.Green("New value: ");
                            song.Title = Console.ReadLine();
                            break;
                        case 3:
                            TextAndColor.White("Length" + Environment.NewLine);
                            Console.WriteLine("Old value: {0}" + Environment.NewLine, song.Length);
                            song.Length = ValidateInput.Integer("Length: ");
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }

                } while (option != 5);
            }
        }


    }
}
