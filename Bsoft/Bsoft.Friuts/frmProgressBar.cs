using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Friuts
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProgressBar : Friuts.FormBase 
    {
        private delegate void ProgressHandler();
        ProgressHandler updateHandler = null;

       // int _iProgress = 0;

        public frmProgressBar()
        {
            InitializeComponent();
            
            updateHandler = new ProgressHandler(UpdateData);
        }

        void UpdateData()
        {
            progressBar1.PerformStep();
        }


        #region Progressbar Show.
        public bool ShowBar(int MaxValue)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Refresh();

            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            if (MaxValue > 0)
            {
                progressBar1.Maximum = MaxValue;
            }
            else
            {
                progressBar1.Maximum = 1;
            }
            return true;
        }

        public void ProgressbarSetValue()
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            progressBar1.Refresh();

            txtCompleated.Text = Convert.ToString(progressBar1.Value * 100 / progressBar1.Maximum) + " Ü tYofªs b]vfpg] k'<f eof] ===".ToString();
            txtCompleated.Refresh();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                txtCompleated.Text = "100 Ü tYofªs b]vfpg] k'<f eof] ===";
                progressBar1.Visible = false;
                progressBar1.Refresh();
            }
        }

        
        //public void ProgressbarSetValue()
        //{
        //    while (_iProgress < progressBar1.Maximum)
        //    {
        //        _iProgress++;
                
        //        Invoke(updateHandler);
                
        //        Thread.Sleep(100);
                
        //        progressBar1.Refresh();
        //        txtCompleated.Text = Convert.ToString(progressBar1.Value * 100 / progressBar1.Maximum) + " % Completed...".ToString();
        //        txtCompleated.Refresh();
        //    }
        //    //if (progressBar1.Value == progressBar1.Maximum)
        //    //{
        //    //    txtCompleated.Text = "100 % Completed...";
        //    //    progressBar1.Visible = false;
        //    //    progressBar1.Refresh();
        //    //}
        //}


        #endregion
    }
}

