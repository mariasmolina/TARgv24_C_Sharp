using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace TARgv24_C_Sharp.Madu
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;


        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "music.mp3";
            player.settings.volume = 30; // громкость
            player.controls.play();  // воспроизведение
            player.settings.setMode("loop", true); // зацикливание
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";  // путь к файлу
            player.controls.play();
        }


        public void PlayEat()
        {
            player.URL = pathToMedia + "food.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}
