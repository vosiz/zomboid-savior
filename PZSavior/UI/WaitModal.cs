using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZSavior.UI
{
    public partial class WaitModal : Form
    {
        private int Jobs;
        private int Done;

        public WaitModal()
        {
            InitializeComponent();
            Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ShowOnTop();
        }

        public void ShowOnTop() {

            TopMost = true;
            Show();
            BringToFront();
            //Activate();
        }


        public void Init(string title, string task, int jobs_to_done = 1)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Init(title, task, jobs_to_done)));
                return;
            }

            LblTitle.Text = title;
            LblTask.Text = task;
            Jobs = jobs_to_done;
            Done = 0;
        }

        public void JobDone()
        {
            Done++;
            UpdateStatus((int)(100f * Done / Jobs));
        }

        public void UpdateStatus(int progress, string task = "")
        {
            progress = Math.Clamp(progress, PbarProgress.Minimum, PbarProgress.Maximum);

            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateStatus(progress, task)));
            }
            else
            {
                if (task != "")
                    LblTask.Text = task;

                LblProgress.Text = $"{progress} %";
                PbarProgress.Value = progress;
            }
        }


        public void CloseDialog()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseDialog));
                return;
            }

            this.Close();
        }
    }


}
