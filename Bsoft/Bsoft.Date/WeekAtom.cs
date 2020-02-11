using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Date
{

    public partial class WeekAtom : UserControl
    {
        public WeekAtom()
        {
            InitializeComponent();
            weekBackColor = Color.Beige;
            EnglishForeColor = Color.Magenta;
            NepaliForeColor = Color.DarkBlue;

            autoSizeFont = false;
            EnglishFontHeight = 12;
            NepaliFontHeight = 14;
        }


        #region "Properties"
        public static  Color weekBackColor
        { get; set; }

        private static Color EnglishForeColor_;
        private static Color NepaliForeColor_;
        public static Color EnglishForeColor
        {
            get { return EnglishForeColor_; }
            set
            {
                EnglishForeColor_ = value;
                blueBrush = new SolidBrush(value);

            }
        }
        public static Color NepaliForeColor
        {
            get { return NepaliForeColor_; }
            set
            {

                NepaliForeColor_ = value;
                blackBrush = new SolidBrush(value);
            }
        }
        public static float NepaliFontHeight
        {
            get { return nepfontheight; }
            set { nepfontheight = value; }
        }
        public static float EnglishFontHeight
        {
            get { return enfontheight; }
            set { enfontheight = value; }
        }
        public static bool autoSizeFont
        {
            get;
            set;
        }
        #endregion
        public string PrintString = "Hi";
        PointF nptop = new PointF(1, 1);
        SizeF ent = new SizeF(1, 1);
        Font nepfont;
        Font enFont;
        static float nepfontheight = 1;
        static float enfontheight = 1;

        private StringFormat stringformat = new StringFormat();
        public WeekNameFormat weekNameFormat = WeekNameFormat.Short;

        public StringAlignment stringalignment
        {
            get { return stringformat.Alignment; }
            set
            {
                stringformat.Alignment = value;
                resize();
            }
        }

        double _ratio = 0.99;
        public double ratio
        {
            get { return _ratio; }
            set { _ratio = value; resize(); }

        }


        private void WeekAtom_Load(object sender, EventArgs e)
        {
            nptop = new Point(1, 1);
            nepfont = new Font("Times New Roman", nepfontheight, FontStyle.Bold, GraphicsUnit.Pixel);
            enFont = new Font("Courier", enfontheight, FontStyle.Bold, GraphicsUnit.Pixel);
            stringformat.Alignment = StringAlignment.Center;
            stringformat.LineAlignment = StringAlignment.Center;

        }

        private void resize()
        {
            ent.Height = Height / 2;
            ent.Width = Width / 2;
            ent.Height -= 2;
            ent.Width -= 2;
            if (Height < Width)
            {
                nepfontheight = (float)(Convert.ToDecimal(Height * ratio));
            }
            else
            {
                nepfontheight = (float)(Convert.ToDecimal(Width * ratio));
            }
            enfontheight = (float)(Convert.ToDecimal(nepfontheight * 0.75));
            nepfont = new Font("Times New Roman", nepfontheight, FontStyle.Bold, GraphicsUnit.Pixel);
            enFont = new Font("Courier", enfontheight, FontStyle.Italic, GraphicsUnit.Pixel);
            Refresh();
        }
        private void WeekAtom_Resize(object sender, EventArgs e)
        {
            resize();
        }
      static  Brush  blackBrush = Brushes.DarkMagenta;
    static    Brush  blueBrush = Brushes.DarkOrange;
        private void WeekAtom_Paint(object sender, PaintEventArgs e)
        {

            Graphics dc = e.Graphics;

            BackColor = weekBackColor;
            //  dc.DrawString(PrintString , nepfont, blueBrush, nptop);
            // PrintString = ratio.ToString();

            if (stringformat.Alignment == StringAlignment.Center)
            {

            }
            if (stringformat.Alignment == StringAlignment.Near)
            {
                ent.Width = 0;
            }
            if (stringformat.Alignment == StringAlignment.Far)
            {
                ent.Width = Width;
            }

            dc.DrawString(PrintString, enFont, blackBrush, ent.Width, ent.Height, stringformat);
        }
    }
}
