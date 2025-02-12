using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PZSavior.Helpers;
using PZSavior.KeyHook;
using PZSavior.FileManagement;

namespace PZSavior
{
    public partial class MainForm : Form
    {

        //string SAVEPATH = "Zomboid\\Saves\\Builder\\Rosewood-save-test";
        //string SAFEPATH = "S:\\_TEMP\\Zomboid_saves_test";



        SaveManager Sman;
        GlobalKeyHook KeyHook;
        //UiHelper UiHelper;

        //UI.WaitModal WaitModal;


        public MainForm()
        {
            InitializeComponent();

            ControlHelper.FillWithEnums<Enums.CompatibilityVersion>(CboxVersion);
            CboxVersion.SelectedIndex = 0;

            KeyHook = new GlobalKeyHook(SaveInvoked);
            //UiHelper = new UiHelper();
            Sman = new SaveManager();
        }

        #region Overrides
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            KeyHook.Dispose();
            base.OnFormClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BtnSavesDefault_Click(null, null);
            BtnLoadsDefault_Click(null, null);
        }
        #endregion

        #region Overrides
        private void BtnSavesDefault_Click(object sender, EventArgs e)
        {
            TboxSave.Text = Config.Paths.DEFAULT_SAVE_PATH_DIR;
            ShowInfo("Default path for saves filled");
        }

        private async void BtnLoadSaves_Click(object sender, EventArgs e)
        {
            try
            {
                ShowInfo("Start loading...");
                BtnLoadSaves.Enabled = false;
                var copymachine = Sman.PrepareToCopy(
                    PathHelper.UserProfile(TboxStorage.Text), TboxSave.Text);

                var wm = new UI.WaitModal();
                wm.Init("Loading files", "Copying...", copymachine.FilesCount);
                wm.ShowOnTop();
                //Task.Run(() => wm.ShowDialog());

                await Task.Run(() => CopySaves(wm, copymachine));

                ShowInfo("... loaded at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                wm.CloseDialog();
                BtnLoadSaves.Enabled = true;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void BtnLoadsDefault_Click(object sender, EventArgs e)
        {
            TboxStorage.Text = Config.Paths.DEFAULT_STORAGE_PATH_DIR;
            ShowInfo("Default path for storage filled");
        }
        #endregion

        #region Tasks - private
        private async void SaveInvoked()
        {
            try
            {
                ShowInfo("Start saving...");
                var copymachine = Sman.PrepareToCopy(
                    PathHelper.UserProfile(TboxSave.Text), TboxStorage.Text);

                var wm = new UI.WaitModal();
                wm.Init("Saving files", "Copying...", copymachine.FilesCount);
                wm.ShowOnTop();
                //Task.Run(() => wm.ShowDialog());

                await Task.Run(() => CopySaves(wm, copymachine));

                ShowInfo("... saved at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                wm.CloseDialog();

            }
            catch (Exception exc)
            {
                throw exc;
            }

        }

        private async Task CopySaves(UI.WaitModal wm, CopyTask copy)
        {

            var progress = new Progress<int>(percent =>
            {
                Console.WriteLine($"Progress: {percent}%");
                wm.UpdateStatus(percent);
            });

            KeyHook.Enabled = false;
            await copy.Execute(progress);
            await Task.Delay(1000);
            KeyHook.Enabled = true;
        }
        #endregion

        #region Privates
        private void ShowInfo(string format, params string[] pars)
        {

            LblInfo.Text = string.Format(format, pars);
        }
        #endregion


    }
}
