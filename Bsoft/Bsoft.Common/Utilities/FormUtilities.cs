using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Common
{
   public static  class FormUtility
    {
        /// <summary>
        /// To adjust the height of form based on content
        /// </summary>
        /// <param name="CotainerflPanel">Must be flowlayout,with autosize , grow and shrink,nowrap,topbottomflow </param>
        /// <param name="OnoffControl">The control in container that is on/off</param>
       public static void adjustHt(Form ContainerForm, FlowLayoutPanel CotainerPanel, Control OnoffControl)
        {
            adjustHt(ContainerForm, CotainerPanel, OnoffControl, !OnoffControl.Visible);
        }

       public static void adjustHt(Form ContainerForm, FlowLayoutPanel CotainerPanel, Control OnoffControl,bool visible)
       {
           CotainerPanel.AutoSize = true;
           CotainerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
           int spaceBelowFl = ContainerForm.Height - CotainerPanel.Bottom;
               OnoffControl.Visible = visible;
               CotainerPanel.Refresh();
           ContainerForm.Height = CotainerPanel.Height + CotainerPanel.Top + spaceBelowFl;
           ContainerForm.Top = (Screen.PrimaryScreen.WorkingArea.Height - ContainerForm.Height )/2;
       }

       public static void ShowForm<T>(this Form owner, ref T frm) where T : Form, new()
       {
           if (frm == null || frm.IsDisposed)
           {
               frm = new T();
               frm.Owner = owner ;
               //frm.MdiParent = this;//for mdi child way
           }
           frm.ShowInTaskbar = true;
           frm.Show();
           frm.Activate();
       }

    }
}
