using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Sounds отвечает за воспроизведение музыки и звуковых эффектов
     с помощью библиотеки Windows Media Player */
    public class Sounds
    {
        // два объекта: чтобы можно было одновременно воспроизводить и фоновую музыку, и короткие эффекты
        WindowsMediaPlayer backgroundPlayer = new WindowsMediaPlayer();  // для фоновой музыки
        WindowsMediaPlayer effectPlayer = new WindowsMediaPlayer();  // для звуковых эффектов
        private string pathToMedia;


        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            backgroundPlayer.URL = pathToMedia + "music.mp3";
            backgroundPlayer.settings.volume = 10; // громкость
            backgroundPlayer.controls.play();  // воспроизведение
            backgroundPlayer.settings.setMode("loop", true); // зацикливание
        }

        public void Stop(string songName)
        {
            backgroundPlayer.URL = pathToMedia + songName + ".mp3";
            backgroundPlayer.controls.stop();
        }

        public void Play(string songName)
        {
            effectPlayer.URL = pathToMedia + songName + ".mp3";  // путь к файлу
            effectPlayer.settings.setMode("loop", false);
            effectPlayer.controls.play();
        }

        public void PlayEat()
        {
            effectPlayer.URL = pathToMedia + "food.mp3";
            effectPlayer.settings.setMode("loop", false);
            effectPlayer.settings.volume = 100;
            effectPlayer.controls.play();
        }
    }
}
