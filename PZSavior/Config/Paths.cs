using PZSavior.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vosiz.Helpers;

namespace PZSavior.Config
{
    internal class Paths
    {
        readonly public static string DEFAULT_SAVE_PATH_DIR =
            PathHelper.UserProfile("Zomboid\\Saves");

        readonly public static string DEFAULT_STORAGE_PATH_DIR =
            PathHelper.Appdata(PathHelper.Combine(App.APP_NAME, "All"));

        public static string SaveLocation { get; set; } = string.Empty;

        public static string GetSaveDirPath(Enums.GameType type, string name) {

            return PathHelper.Combine();
        }
    }
}
