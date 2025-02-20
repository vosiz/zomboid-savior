using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace PZSavior
{

    public static class Enums {

        public enum CompatibilityVersion {

            [Description("ver. 41.78.16")]
            V41_78_16,
        }

        public enum GameType
        {
            [Description("Builder")]
            Builder,
            [Description("Survivor")]
            Survivor,
            [Description("Sandbox")]
            CustomSandbox,
            [Description("Apocalypse")]
            Apocalypse
        }

    }
}
