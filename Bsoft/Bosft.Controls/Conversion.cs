using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Bsoft.Controls
{
    public class DragForm1
    {
        public DragForm1(Form frm)
        {}
        public DragForm1(Form frm, Control[] formDragControls) { }
        bool _Draggable;
        public bool Draggable { get { return _Draggable; } set { _Draggable = value; } }
    }

    public static class MsgBox
    {
        public static DialogResult Show( string message ) { return DialogResult.No; }
        public static DialogResult Show(string message, MessageBoxButtons msgButtons) { return DialogResult.No; }
        public static DialogResult Show(Form owner, string message, MessageBoxButtons msgButtons) { return DialogResult.No; }
    }

  

}
