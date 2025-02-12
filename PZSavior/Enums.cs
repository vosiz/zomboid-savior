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

        public static string GetDescription(this Enum value)
        {
            Assert.OnNull(value);

            try
            {
                FieldInfo field = value.GetType().GetField(value.ToString());

                if (field != null)
                {
                    DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

                    if (attribute != null)
                    {
                        return attribute.Description;
                    }
                }

                // default
                return value.ToString();
            }
            catch (Exception exc) {

                throw exc;
            }

        }

        public static IEnumerable<T> GetAll<T>(this T _) where T : Enum
        {
            return (T[])Enum.GetValues(typeof(T));
        }

    }
}
