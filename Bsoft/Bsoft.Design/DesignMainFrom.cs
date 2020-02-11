using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Bsoft;
using Bsoft.Controls;
using System.Runtime.InteropServices;

namespace Bsoft.Design
{
    public class MainFormDesginBase : Form
    {
        //constant
        private   int TopPix = 20;
        //#region Dragable form
        //const int WM_NCHITTEST = 0x84;
        //const int HTCAPTION = 2;
        //const int HTCLIENT = 1;
        //protected override void WndProc(ref System.Windows.Forms.Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST && m.Result.ToInt32() == HTCLIENT)
        //    {
        //        m.Result = new IntPtr(HTCAPTION);
        //    }
        //}
        //#endregion

        //for move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Maximize
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Y < TopPix)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
        //move
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Y < TopPix)//Is the pixel size at top
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ReleaseCapture();
                        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    }
                }
            }
        }

        public new FormWindowState WindowState
        {
            get
            {
                return base.WindowState;
            }
            set
            {
                if (value == FormWindowState.Maximized)
                {
                    this.MaximizedBounds =
                       SystemInformation.WorkingArea;
                    this.MaximumSize = SystemInformation.WorkingArea.Size;
                }
                base.WindowState = value;
            }
        }

        public MainFormDesginBase()
        {
            InitializeButtons();
            SetDefaultValues();//DhirajFx
            //move maximize
            this.MouseDoubleClick += Form1_MouseDoubleClick;
            this.MouseMove += Form1_MouseMove;
        }
        private void InitializeButtons()
        {
            // 
            // _closeButton
            // 
            this._closeButton.BackColor = System.Drawing.Color.Transparent;
            this._closeButton.ButtonImage = global::Bsoft.Design.Properties.Resources.closeButton;
            this._closeButton.ButtonDisabledImage = null;
            this._closeButton.ButtonHoverImage = global::Bsoft.Design.Properties.Resources.closeButtonHover;
            this._closeButton.ButtonPressedImage = global::Bsoft.Design.Properties.Resources.closeButtonPressed;
            this._closeButton.DisableForeColor = System.Drawing.Color.DimGray;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.HeightEllipse = 0;
            this._closeButton.Size = new System.Drawing.Size(32, 32);
            this._closeButton.Location = new Point(this.Width - _closeButton.Width, 0);
            this._closeButton.Margin = new System.Windows.Forms.Padding(0);
            this._closeButton.Name = "_closeButton";
            this._closeButton.TabIndex = 0;
            this._closeButton.TabStop = false;
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.WidthEllipse = 0;
            this.Controls.Add(_closeButton);
            this.CancelButton = _closeButton;
        }

        public static Font myFont = new Font("Mangal", 10);
        //private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteOffice2010Blue;
        private void SetDefaultValues()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen ;
            this.KeyPreview = true;
            Font = myFont;
            ShowIcon = false;
            ForeColor = Color.Black;
            ShowInTaskbar = true ;
            // TabAccrossFirst ();
            EnableDoubleBuffering();
        }

        private void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true.
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }


        #region BackGroundDesgin Section
        protected bool _isFormLoaded = false;
        private bool _isPerformingPaint = false;
        //private DragForm1 _dragFrom = null;
        private HorizontalAlignment _titleFontAlignment = HorizontalAlignment.Left ;
        private SizeF _titleBarSize = new Size();
        //added to change the form title properties
        private Font _titleFont = new Font("Verdana", 15);
        private Color _titleForeColor = Color.Wheat;
        
        Color _Original = Color.Transparent;
        Color _Focuscolor = Color.LightGoldenrodYellow;
        Color _OriginalButtonTheme = Color.RoyalBlue;
        Color _FocusButoonTheme = Color.Yellow;

        private  RoundRectButton _closeButton = new RoundRectButton();

        public HorizontalAlignment TitleFontAlignment
        {
            get { return _titleFontAlignment; }
            set
            {
                _titleFontAlignment = value;
                DrawFormBackGround();
            }
        }

        protected override void OnLoad(EventArgs e)
        {

            //_isFormLoaded = true;

            //DrawFormBackGround();
            //AddEvents((Control)this);
            //base.OnLoad(e);
            // _isFormLoaded = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //    this.BackgroundImage = Properties.Resources.body;
          
            DrawFormBackGround();
            base.OnLoad(e);
            SetDefaultValues();//DhirajFx
            _isFormLoaded = true;
            DrawFormBackGround();
            //ADD EVENT TO CLOSE 
            _closeButton.Click += new EventHandler(_closeButton_Click);
        }

        void _closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            //Graphics g = e.Graphics;

            //   DrawFormBackGround(e.Graphics);

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //  set the close button location.
            // SetButtonsLocation();
            DrawFormBackGround();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DesignMode)
            {
                if (!_isPerformingPaint)
                {
                    _isPerformingPaint = true;
                    try
                    {
                        DrawFormBackGround();
                        //DrawFormBackGroundPaint();
                    }
                    catch
                    {
                        _isPerformingPaint = false;
                    }
                    finally
                    {
                        _isPerformingPaint = false;
                    }
                }
            }
        }

     
        private void SetButtonsLocation()
        {

            //_closeButton.Location = new Point(this.Width - _closeButton.Width - 4,
            //    Convert.ToInt32(Math.Truncate((_titleBarSize.Height - _closeButton.Height) / 2)));
            _closeButton.Location = new Point(this.Width - _closeButton.Width - 2, 2);
            //Convert.ToInt32(Math.Truncate((_titleBarSize.Height - _closeButton.Height) / 2)));
            // _closeButton.FlatStyle = FlatStyle.Popup;
        }



        private void DrawFormBackGround()
        {
            //DhirajFx
            //don't draw the Form background until the form is loaded successfully
            if (!_isFormLoaded)
                return;


            if (DesignMode)
            {
                BackColor = Color.FromArgb(128, 255, 255);
                //     GetBackGroundImage2(Properties.Resources.body, Size);
            }
            else
            {
            //    BackgroundImage = Properties.Resources.MainFormbody ;
                BackgroundImage = GetBackGroundImage(BackgroundImage);
            }
            SetButtonsLocation();
        }

        static Bitmap topBar = Properties.Resources.headerTop;
        static Bitmap rightBar = Properties.Resources.BorderVertical;
        static Bitmap bottomBar = Properties.Resources.BorderHorizontall;
        static Bitmap leftBar = Properties.Resources.BorderVertical;
     //  public  static Bitmap bodybmp = Properties.Resources.MainFormbody;
        private Image GetBackGroundImage(Image image)
        {
            TopPix = topBar.Height;
            #region DrawBackGround Image of Form
            //resize image
            string tmp = Text.Length == 0 ? "T" : Text;
            Bitmap bmp = new Bitmap(image, Size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                //get the max of text height and title height
                _titleBarSize = g.MeasureString(this.Text, this._titleFont);
                _titleBarSize.Height = _titleBarSize.Height < topBar.Height ? topBar.Height : _titleBarSize.Height;
                //g.DrawImage(bodybmp, new Rectangle(new Point(0, 0), Size));
                g.DrawImage(topBar, 0, 0, Size.Width, _titleBarSize.Height);
                g.DrawImage(bottomBar, 0, Size.Height - bottomBar.Height, Size.Width, bottomBar.Height);
                g.DrawImage(rightBar, Size.Width - rightBar.Width, 0, rightBar.Width, Size.Height);
                g.DrawImage(leftBar, 0, 0, leftBar.Width, Size.Height);
                DrawTitleBar(g);
            }
            #endregion
            return bmp;
        }


        private void DrawFormBackGroundPaint(Graphics g)
        {

            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            _titleBarSize = g.MeasureString(this.Text, this._titleFont);
            _titleBarSize.Height = _titleBarSize.Height < topBar.Height ? topBar.Height : _titleBarSize.Height;
            //draw all image
           // g.DrawImage(bodybmp, new Rectangle(new Point(0, 0), Size));
            g.DrawImage(topBar, 0, 0, Size.Width, _titleBarSize.Height + 3);
            g.DrawImage(rightBar, Size.Width - rightBar.Width, _titleBarSize.Height, rightBar.Width, Size.Height - _titleBarSize.Height);
            g.DrawImage(bottomBar, 0, Size.Height - bottomBar.Height, Size.Width, bottomBar.Height);
            g.DrawImage(leftBar, 0, _titleBarSize.Height, leftBar.Width, Size.Height - _titleBarSize.Height);
            DrawTitleBar(g);
        }


        
        private void DrawTitleBar(Graphics g)
        {
            if (!this.Text.Length.Equals(0))
            {
                //titleBarSize = e.Graphics.MeasureString(this.Text, this._titleFont);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags = StringFormatFlags.NoWrap;
                    sf.LineAlignment = StringAlignment.Center;

                    switch (TitleFontAlignment)
                    {
                        case HorizontalAlignment.Center:
                            sf.Alignment = StringAlignment.Center;
                            break;
                        case HorizontalAlignment.Left:
                            sf.Alignment = StringAlignment.Near;
                            break;
                        case HorizontalAlignment.Right:
                            sf.Alignment = StringAlignment.Far;
                            //sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                            break;
                    }
                    base.Padding = Padding;
                    Rectangle textRect = new Rectangle(Icon.Size.Width, 2, Size.Width - 30, Convert.ToInt32(Math.Truncate(_titleBarSize.Height)));
                    g.DrawString(this.Text, this._titleFont, new SolidBrush(this._titleForeColor),
                        textRect, sf);
                }

            }
        }

        #endregion

        private void InitializeComponent()
        {
            // 
            // MainFormDesginBase
            // 
            this.ClientSize = new System.Drawing.Size(694, 336);
            this.Name = "MainFormDesginBase";
            this.Padding = new System.Windows.Forms.Padding(1, 40, 1, 1);
           
        }

    }
}
