using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZSavior.Helpers
{
    static public class UiHelper
    {
        //    private UI.WaitModal WaitModal;
        //    private Task WaitModalTask;

        //    public UI.WaitModal ShowWaitmodal(string title, string task, int job_count)
        //    {
        //        WaitModal = new UI.WaitModal();
        //        WaitModal.Init(title, task, job_count);

        //        // Show the modal on the UI thread
        //        Task.Run(() =>
        //        {
        //            WaitModal.Invoke(new Action(() =>
        //            {
        //                WaitModal.ShowDialog();
        //            }));
        //        });

        //        return WaitModal;
        //    }

        //    public void CloseModal()
        //    {
        //        if (WaitModal.IsDisposed)
        //            return;

        //        if (WaitModal != null && WaitModal.InvokeRequired)
        //        {
        //            WaitModal.Invoke(new Action(() =>
        //            {
        //                WaitModal.Close();
        //            }));
        //        }
        //        else
        //        {
        //            WaitModal?.Close();
        //        }
        //    }
        //}

    }
}
