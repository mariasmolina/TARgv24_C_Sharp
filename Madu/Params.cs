using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Params отвечает за получение пути к ресурсам игры (музыка, картинки и т.д.) */
    public class Params
    {
        private string resourcesFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal);  // Получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                    .ToString();  // путь до указанной в индексе папки

            resourcesFolder = binFolder + "Madu\\resources\\";
        }

        public string GetResourceFolder()
        {
            return resourcesFolder;
        }
    }
}
