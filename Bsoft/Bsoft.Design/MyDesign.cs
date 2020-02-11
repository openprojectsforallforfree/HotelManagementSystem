using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
//using TPPIMS.AppClass;
//using Bsoft.Controls;
using Bsoft;
using Bsoft.Controls;
//using Bsoft.Common;
//using Bsoft.Data;

namespace Bsoft.Design
{
    public class MyDesign : Form
    {
        public MyDesign()
        {
            InitializeButtons();
            tom = new SMcMaster.TabOrderManager(this);
            SetDefaultValues();//DhirajFx
        }

        #region Dragable form
        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && m.Result.ToInt32() == HTCLIENT)
            {
                m.Result = new IntPtr(HTCAPTION);
            }
        }
        #endregion

        private Control _FirstControl = null;
        public static Font MainFont = new Font("Veranda", 10);
        public static Font DigitFont = new Font("Veranda", 10);

      

        //private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteOffice2010Blue;
        private void SetDefaultValues()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen ;
            this.KeyPreview = true;
            Font = MainFont;
            ShowIcon = false;
            ForeColor = Color.Black;
            // ShowInTaskbar = false;
            //this.kryptonmanager = new ComponentFactory.Krypton.Toolkit.KryptonManager();
            //this.kryptonmanager.GlobalPaletteMode = PaletteModeManager.SparkleBlue; //ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            //StateCommon.Header.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            //StateCommon.Header.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            // this.kryptonPaletteOffice2010Blue = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            // this.kryptonmanager.GlobalPalette = this.kryptonPaletteOffice2010Blue;
            // TabAccrossFirst ();
            EnableDoubleBuffering();
        }
        //set this.Handle

        //public Form ThisForm
        //{
        //    get { return _ThisForm;}
        //    set { _ThisForm = value; }
        //}

        #region Tab and focus color events
        //To manage tab order
        SMcMaster.TabOrderManager tom;
        public void AddEvents(Control container)
        {//By Dhiraj For tab control focus

            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Panel | ctrl is FlowLayoutPanel | ctrl is GroupBox | ctrl is TabControl | ctrl is TableLayoutPanel | ctrl is SplitContainer)
                {
                    AddEvents(ctrl);
                }
                else if (ctrl is ComboBox) { }
                else if (ctrl is ToolBar) { }
                else if (ctrl is ToolStrip) { }
                else if (ctrl is bsoftcontrols.fsButton)
                {
                    ((bsoftcontrols.fsButton)ctrl).ThemeColor = _OriginalButtonTheme;
                    ctrl.Enter += tb_Enter;
                    ctrl.Leave += tb_Leave;
                }
                else if (ctrl is RoundRectButton) { }
                else
                {

                    ctrl.Enter += tb_Enter;
                    ctrl.Leave += tb_Leave;
                }
                if (ctrl is TextBox || ctrl is VtextBox)
                {
                    if (!((TextBox)ctrl).ReadOnly)
                    {
                        if (ctrl.Font.Name.Contains("Mangal"))
                        {
                            Bsoft.Common.Language.LanguageUtility.SetNep(ctrl);
                        }
                        else
                        {
                            Bsoft.Common.Language.LanguageUtility.SetEng(ctrl);
                        }
                    }
                }
                if (ctrl is CrudeFx.NepaliDate.NepaliDatePicker)
                {

                    if (ctrl.Font.Name.Contains("Mangal"))
                    {
                        Bsoft.Common.Language.LanguageUtility.SetNep(ctrl);
                    }
                    else
                    {
                        Bsoft.Common.Language.LanguageUtility.SetEng(ctrl);
                    }

                }
            }
        }



        private void tb_Enter(object sender, EventArgs e)
        {
            if (sender is bsoftcontrols.fsButton)
            {
                bsoftcontrols.fsButton btn = (bsoftcontrols.fsButton)sender;
                btn.ThemeColor = _FocusButoonTheme;
            }
            else
            {
                Control ctr = (Control)sender;
                // _Original = ctr.BackColor;
                ctr.BackColor = _Focuscolor;
            }
            base.OnGotFocus(e);
        }

        private void tb_Leave(object sender, EventArgs e)
        {

            if (sender is bsoftcontrols.fsButton)
            {
                bsoftcontrols.fsButton btn = (bsoftcontrols.fsButton)sender;
                btn.ThemeColor = _OriginalButtonTheme;
            }
            else
            {
                Control ctr = (Control)sender;
                try
                {
                    ctr.BackColor = _Original;
                }
                catch { ctr.BackColor = Color.White; }
            }
            base.OnLostFocus(e);
        }

        public void TabAccrossFirst()
        {
            tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.AcrossFirst);
        }
        public void TabDownFirst()
        {
            tom.SetTabOrder(SMcMaster.TabOrderManager.TabScheme.DownFirst);
        }
        #endregion


        #region BackGroundDesgin Section
        protected bool _isFormLoaded = false;
        private bool _isPerformingPaint = false;
        //private DragForm1 _dragFrom = null;
        private HorizontalAlignment _titleFontAlignment = HorizontalAlignment.Left ;
        private SizeF _titleBarSize = new Size();
        //added to change the form title properties
        private Font _titleFont = new Font("Verdana", 15);
        private Color _titleForeColor = Color.Wheat;
        private bool _isFirstTime = true;

        //public Form _ThisForm = null;
        Color _Original = Color.Transparent;
        Color _Focuscolor = Color.LightGoldenrodYellow;
        Color _OriginalButtonTheme = Color.RoyalBlue;
        Color _FocusButoonTheme = Color.Yellow;

        public RoundRectButton _closeButton = new RoundRectButton();

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
            AddEvents((Control)this);
            DrawFormBackGround();
            base.OnLoad(e);
            SetDefaultValues();//DhirajFx
            _isFormLoaded = true;
            DrawFormBackGround();
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

        private void InitializeButtons()
        {
            // 
            // _closeButton
            // 
            this._closeButton.BackColor = System.Drawing.Color.Transparent;
            this._closeButton.ButtonImage = global::Bsoft.Design.Properties.Resources.closeButton;
            // this._closeButton.ButtonImage = global::Friuts.Properties.Resources.closeButton;
            this._closeButton.ButtonDisabledImage = null;
            this._closeButton.ButtonHoverImage = global::Bsoft.Design.Properties.Resources.closeButtonHover;
            //this._closeButton.ButtonFocusImage = null;
            this._closeButton.ButtonPressedImage = global::Bsoft.Design.Properties.Resources.closeButtonPressed;
            this._closeButton.DisableForeColor = System.Drawing.Color.DimGray;

            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.HeightEllipse = 0;
            //this._closeButton.Location = new System.Drawing.Point(263, 4);
            // this._closeButton.Size = _closeButton.BackgroundImage.Size; 
            this._closeButton.Size = new System.Drawing.Size(32, 32);
            this._closeButton.Location = new Point(this.Width - _closeButton.Width, 0);
            this._closeButton.Margin = new System.Windows.Forms.Padding(0);
            this._closeButton.Name = "_closeButton";

            this._closeButton.TabIndex = 0;
            this._closeButton.TabStop = false;
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.WidthEllipse = 0;
            this._closeButton.Click += new EventHandler(closeButton_Click);
            this.Controls.Add(_closeButton);
            this.CancelButton = _closeButton;
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
                BackgroundImage = Properties.Resources.body;
                BackgroundImage = GetBackGroundImage(BackgroundImage);
            }
            SetButtonsLocation();
        }

        static Bitmap topBar = Properties.Resources.headerTop;
        static Bitmap rightBar = Properties.Resources.BorderVertical;
        static Bitmap bottomBar = Properties.Resources.BorderHorizontall;
        static Bitmap leftBar = Properties.Resources.BorderVertical;
        static Bitmap bodybmp = Properties.Resources.body;
        private Image GetBackGroundImage(Image image)
        {
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
                //draw all image


                // g.DrawImage(bodybmp, new Rectangle(new Point(0, (int)_titleBarSize.Height - 3), new Size(Size.Width, Size.Height - (int)_titleBarSize.Height + 6)));

                // g.DrawImage(topBar, 0, 0, Size.Width, _titleBarSize.Height + 3);
                //g.DrawImage(bottomBar, 0, Size.Height - bottomBar.Height, Size.Width, bottomBar.Height); 

                // g.DrawImage(rightBar, Size.Width - rightBar.Width, _titleBarSize.Height, rightBar.Width, Size.Height - _titleBarSize.Height);
                //g.DrawImage(leftBar, 0, _titleBarSize.Height, leftBar.Width, Size.Height - _titleBarSize.Height);

                g.DrawImage(bodybmp, new Rectangle(new Point(0, 0), Size));

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
            g.DrawImage(bodybmp, new Rectangle(new Point(0, 0), Size));
            g.DrawImage(topBar, 0, 0, Size.Width, _titleBarSize.Height + 3);
            g.DrawImage(rightBar, Size.Width - rightBar.Width, _titleBarSize.Height, rightBar.Width, Size.Height - _titleBarSize.Height);
            g.DrawImage(bottomBar, 0, Size.Height - bottomBar.Height, Size.Width, bottomBar.Height);
            g.DrawImage(leftBar, 0, _titleBarSize.Height, leftBar.Width, Size.Height - _titleBarSize.Height);
            DrawTitleBar(g);
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
                    //base.TextAlign = TextAlign;
                    //e.Graphics.DrawString(this.Text, this._titleFont, new SolidBrush(this._titleForeColor),
                    //((this.ClientSize.Width - titleBarSize.Width) / 2), ((this.ClientSize.Height - titleBarSize.Height) / 2));
                    g.DrawString(this.Text, this._titleFont, new SolidBrush(this._titleForeColor),
                        textRect, sf);
                }

            }
        }

        //private void DrawFormBackGround2(Graphics g)
        //{
        //    #region DrawBackGround Image of Form
        //      g.DrawImage(bmp, new Rectangle(new Point(0, 0), this.Size));
        //    #endregion
        //}
        #endregion



        public bool IsFirstTime
        {
            get { return _isFirstTime; }
            set { _isFirstTime = value; }
        }

        protected override void OnActivated(EventArgs e)
        {
            _isFirstTime = false;
            base.OnActivated(e);
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);

            Invalidate();
        }

        void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //DrawFormBackGround();
        }
        /// <summary>
        /// Entry Form When user Press Ctrl + S then Focus move the first controls
        /// </summary>
        public Control FirstControl
        {
            get
            {
                return _FirstControl;
            }
            set
            {

                _FirstControl = value;
                if (_FirstControl is bsoftcontrols.fsButton)
                {
                    ((bsoftcontrols.fsButton)_FirstControl).ThemeColor = _FocusButoonTheme;
                }
                this.BackColor = _Focuscolor;
                this.FirstControl.Focus();
                this.FirstControl.Select();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormDesginBase
            // 
            this.BackgroundImage = global::Bsoft.Design.Properties.Resources.BorderVertical;
            this.ClientSize = new System.Drawing.Size(694, 336);
            this.Name = "FormDesginBase";
            this.Padding = new System.Windows.Forms.Padding(1, 40, 1, 1);
            this.ResumeLayout(false);

        }

    }
}
