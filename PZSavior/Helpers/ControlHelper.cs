using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vosiz.Commons;
using Vosiz.Utils.Extends;

namespace PZSavior.Helpers
{
    public static class ControlHelper
    {
        public static void FillWithEnums<T>(ComboBox control, bool clear = true) where T : Enum  {

            try
            {
                Assert.OnNull(control);
                Assert.OnType(control, typeof(ComboBox));

                if (clear)
                    control.Items.Clear();

                foreach (T e in Enum.GetValues(typeof(T))) {

                    var desc = e.GetDescription();
                    control.Items.Add(desc);
                }

            }
            catch (Exception exc) {

                throw exc;
            }
        }
    }
}
