using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data;


namespace Bsoft.Controls
{

    public class GanttChart : Control
    {
        // Fields
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private bool _allowEditBarWithMouse;
        private DateTime _mouseOverColumnValue;
        private string _mouseOverRowText;
        private object _mouseOverRowValue;
        [AccessedThroughProperty("ToolTip")]
        private ToolTip _ToolTip;
        private List<string> _toolTipText;
        private string _toolTipTextTitle;
        private int barHeight;
        private int barIsChanging;
        private List<ChartBarDate> bars;
        private int barSpace;
        private int barStartLeft;
        private int barStartRight;
        private int barStartTop;
        private int barsViewable;
        private Rectangle BottomPart;
        private Font dateTextFont;
        private DateTime headerFromDate;
        private int headerTimeStartTop;
        private DateTime headerToDate;
        private int lastLineStop;
        private Pen lineColor;
        private int mouseHoverBarIndex;
        private MouseOverPart mouseHoverPart;
        private bool mouseOverBottomPart;
        private bool mouseOverScrollBar;
        private bool mouseOverScrollBarArea;
        private bool mouseOverTopPart;
        private Point MyPoint;
        private Bitmap objBmp;
        private Graphics objGraphics;
        private Font rowTextFont;
        private Rectangle scroll;
        private Rectangle scrollBarArea;
        private int scrollPosition;
        private List<Header> shownHeaderList;
        private Font timeTextFont;
        private Rectangle topPart;
        private int widthPerItem;

        // Events
        public event BarChangedEventHandler BarChanged;

        public event MouseDraggedEventHandler MouseDragged;

        // Methods
        public GanttChart()
        {
            base.MouseLeave += new EventHandler(this.GanttChart_MouseLeave);
            this.MouseDragged += new MouseDraggedEventHandler(this.GanttChart_MouseDragged);
            base.MouseClick += new MouseEventHandler(this.GanttChart_Click);
            base.MouseWheel += new MouseEventHandler(this.GanttChart_MouseWheel);
            base.MouseMove += new MouseEventHandler(this.GanttChart_MouseMove);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.mouseHoverPart = MouseOverPart.Empty;
            this.mouseHoverBarIndex = -1;
            this.bars = new List<ChartBarDate>();
            this.headerFromDate = new DateTime();
            this.headerToDate = new DateTime();
            this.barIsChanging = -1;
            this.barStartRight = 20;
            this.barStartLeft = 100;
            this.headerTimeStartTop = 30;
            this.barStartTop = 50;
            this.barHeight = 9;
            this.barSpace = 5;
            this._mouseOverColumnValue = new DateTime();
            this._mouseOverRowText = "";
            this._mouseOverRowValue = null;
            this.lineColor = Pens.Bisque;
            this.dateTextFont = new Font("VERDANA", 8f, FontStyle.Regular, GraphicsUnit.Point);
            this.timeTextFont = new Font("VERDANA", 8f, FontStyle.Regular, GraphicsUnit.Point);
            this.rowTextFont = new Font("VERDANA", 8f, FontStyle.Regular, GraphicsUnit.Point);
            this.ToolTip = new ToolTip();
            this._allowEditBarWithMouse = false;
            this.lastLineStop = 0;
            this._toolTipText = new List<string>();
            this._toolTipTextTitle = "";
            this.MyPoint = new Point(0, 0);
            this.barsViewable = -1;
            this.scrollPosition = 0;
            this.topPart = new Rectangle();
            this.BottomPart = new Rectangle();
            this.scroll = new Rectangle();
            this.scrollBarArea = new Rectangle();
            this.mouseOverTopPart = false;
            this.mouseOverBottomPart = false;
            this.mouseOverScrollBar = false;
            this.mouseOverScrollBarArea = false;
            this.ToolTip.AutoPopDelay = 0x3a98;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.OwnerDraw = true;
            this.objBmp = new Bitmap(0x500, 0x400, PixelFormat.Format24bppRgb);
            this.objGraphics = Graphics.FromImage(this.objBmp);
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        public void AddChartBar(string rowText, object barValue, DateTime fromTime, DateTime toTime, Color color, Color hoverColor, int rowIndex)
        {
            ChartBarDate item = new ChartBarDate
            {
                Text = rowText,
                Value = RuntimeHelpers.GetObjectValue(barValue),
                StartValue = fromTime,
                EndValue = toTime,
                Color = color,
                HoverColor = hoverColor,
                RowIndex = rowIndex
            };
            this.bars.Add(item);
            this.SetBarStartLeft(rowText);
        }

        public void AddChartBar(string rowText, object barValue, DateTime fromTime, DateTime toTime, Color color, Color hoverColor, int rowIndex, bool hideFromMouseMove)
        {
            ChartBarDate item = new ChartBarDate
            {
                Text = rowText,
                Value = RuntimeHelpers.GetObjectValue(barValue),
                StartValue = fromTime,
                EndValue = toTime,
                Color = color,
                HoverColor = hoverColor,
                RowIndex = rowIndex,
                HideFromMouseMove = hideFromMouseMove
            };
            this.bars.Add(item);
            this.SetBarStartLeft(rowText);
        }

        private void DrawBars(Graphics grfx, [Optional, DefaultParameterValue(false)] bool ignoreScrollAndMousePosition)
        {
            if ((this.shownHeaderList != null) && (this.shownHeaderList.Count > 1))
            {
                int rowIndex = 0;
                TimeSpan span = (TimeSpan)(this.shownHeaderList[1].Time - this.shownHeaderList[0].Time);
                int num2 = (int)Math.Round(span.TotalMinutes);
                int num4 = this.shownHeaderList[1].StartLocation - this.shownHeaderList[0].StartLocation;
                decimal num3 = new decimal(((double)num4) / ((double)num2));
                foreach (ChartBarDate date in this.bars)
                {
                    Color hoverColor;
                    rowIndex = date.RowIndex;
                    int scrollPosition = 0;
                    if (!ignoreScrollAndMousePosition)
                    {
                        scrollPosition = this.scrollPosition;
                    }
                    TimeSpan span3 = (TimeSpan)(date.StartValue - this.FromDate);
                    int num12 = ((span3.Days * 0x5a0) + (span3.Hours * 60)) + span3.Minutes;
                    int num11 = Convert.ToInt32(decimal.Multiply(num3, new decimal(num12)));
                    DateTime endValue = date.EndValue;
                    if (DateTime.Compare(endValue, DateTime.MinValue) == 0)
                    {
                        endValue = DateTime.Now;
                    }
                    TimeSpan span2 = (TimeSpan)(endValue - date.StartValue);
                    int num9 = ((span2.Days * 0x5a0) + (span2.Hours * 60)) + span2.Minutes;
                    int num13 = Convert.ToInt32(decimal.Multiply(num3, new decimal(num9)));
                    int x = this.barStartLeft + num11;
                    int y = ((this.barStartTop + (this.barHeight * (rowIndex - scrollPosition))) + (this.barSpace * (rowIndex - scrollPosition))) + 2;
                    int width = num13;
                    int barHeight = this.barHeight;
                    if (width == 0)
                    {
                        width = 1;
                    }
                    if ((x - this.barStartLeft) < 0)
                    {
                        x = this.barStartLeft;
                    }
                    if (((this.MouseOverRowText == date.Text) & (DateTime.Compare(date.StartValue, this._mouseOverColumnValue) <= 0)) & (DateTime.Compare(date.EndValue, this._mouseOverColumnValue) >= 0))
                    {
                        hoverColor = date.HoverColor;
                    }
                    else
                    {
                        hoverColor = date.Color;
                    }
                    Point point = new Point(x, y);
                    date.TopLocation.Left = point;
                    point = new Point(x + width, y);
                    date.TopLocation.Right = point;
                    point = new Point(x, y + barHeight);
                    date.BottomLocation.Left = point;
                    point = new Point(x, y + barHeight);
                    date.BottomLocation.Right = point;
                    Rectangle rect = new Rectangle(x, y, width, barHeight);
                    if (((DateTime.Compare(date.StartValue, DateTime.MinValue) != 0) & (DateTime.Compare(endValue, DateTime.MinValue) != 0)) && (((rowIndex >= scrollPosition) & (rowIndex < (this.barsViewable + scrollPosition))) | ignoreScrollAndMousePosition))
                    {
                        LinearGradientBrush brush = new LinearGradientBrush(rect, hoverColor, Color.Gray, LinearGradientMode.Vertical);
                        grfx.DrawRectangle(Pens.Black, rect);
                        grfx.FillRectangle(brush, rect);
                        grfx.DrawString(date.Text, this.rowTextFont, Brushes.Black, 0f, (float)((this.barStartTop + (this.barHeight * (rowIndex - scrollPosition))) + (this.barSpace * (rowIndex - scrollPosition))));
                        brush = null;
                        rect = new Rectangle();
                        brush = null;
                    }
                    hoverColor = new Color();
                }
            }
        }

        private void DrawHeader(Graphics gfx, List<Header> headerList)
        {
            if (headerList == null)
            {
                headerList = this.GetFullHeaderList();
            }
            if (headerList.Count != 0)
            {
                int num = ((this.Width - 10) - this.barStartLeft) - this.barStartRight;
                this.widthPerItem = (int)Math.Round((double)(((double)num) / ((double)headerList.Count)));
                if (this.widthPerItem < 40)
                {
                    List<Header> list = new List<Header>();
                    bool flag = true;
                    foreach (Header header2 in headerList)
                    {
                        if (flag)
                        {
                            list.Add(header2);
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    this.DrawHeader(gfx, list);
                }
                else
                {
                    int num3 = 0;
                    Header header = null;
                    foreach (Header header3 in headerList)
                    {
                        int num4 = this.barStartLeft + (num3 * this.widthPerItem);
                        bool flag2 = false;
                        header3.StartLocation = num4;
                        if (header == null)
                        {
                            flag2 = true;
                        }
                        else if (header3.Time.Hour < header.Time.Hour)
                        {
                            flag2 = true;
                        }
                        else if (header3.Time.Minute == header.Time.Minute)
                        {
                            flag2 = true;
                        }
                        if (flag2)
                        {
                            string s = "";
                            if (header3.HeaderTextInsteadOfTime.Length > 0)
                            {
                                s = header3.HeaderTextInsteadOfTime;
                            }
                            else
                            {
                                s = header3.Time.ToString("d-MMM");
                            }
                            gfx.DrawString(s, this.dateTextFont, Brushes.Black, (float)num4, 0f);
                        }
                        gfx.DrawString(header3.HeaderText, this.timeTextFont, Brushes.Black, (float)num4, (float)this.headerTimeStartTop);
                        num3++;
                        header = header3;
                    }
                    this.shownHeaderList = headerList;
                    this.widthPerItem = (int)Math.Round((double)(((double)(((this.Width - 10) - this.barStartLeft) - this.barStartRight)) / ((double)this.shownHeaderList.Count)));
                }
            }
        }

        public void DrawNetHorizontal(Graphics grfx)
        {
            if ((this.shownHeaderList != null) && (this.shownHeaderList.Count != 0))
            {
                int num = 0;
                int num2 = (this.widthPerItem * this.shownHeaderList.Count) + this.barStartLeft;
                int indexChartBar = this.GetIndexChartBar("QQQQQQ");
                num = 0;
                while (num <= indexChartBar)
                {
                    foreach (ChartBarDate date in this.bars)
                    {
                        grfx.DrawLine(this.lineColor, 0, (this.barStartTop + (this.barHeight * num)) + (this.barSpace * num), num2, (this.barStartTop + (this.barHeight * num)) + (this.barSpace * num));
                    }
                    num++;
                }
                this.lastLineStop = (this.barStartTop + (this.barHeight * (num - 1))) + (this.barSpace * (num - 1));
            }
        }

        public void DrawNetVertical(Graphics grfx)
        {
            if ((this.shownHeaderList != null) && (this.shownHeaderList.Count != 0))
            {
                int num2 = 0;
                int num = ((this.Width - 10) - this.barStartLeft) - this.barStartRight;
                Header header = null;
                foreach (Header header2 in this.shownHeaderList)
                {
                    int headerTimeStartTop = 0;
                    if (header == null)
                    {
                        headerTimeStartTop = 0;
                    }
                    else if (header2.Time.Hour < header.Time.Hour)
                    {
                        headerTimeStartTop = 0;
                    }
                    else
                    {
                        headerTimeStartTop = this.headerTimeStartTop;
                    }
                    grfx.DrawLine(Pens.Bisque, this.barStartLeft + (num2 * this.widthPerItem), headerTimeStartTop, this.barStartLeft + (num2 * this.widthPerItem), this.lastLineStop);
                    num2++;
                    header = header2;
                }
                grfx.DrawLine(this.lineColor, this.barStartLeft + (num2 * this.widthPerItem), this.headerTimeStartTop, this.barStartLeft + (num2 * this.widthPerItem), this.lastLineStop);
            }
        }

        private void DrawScrollBar(Graphics grfx)
        {
            this.barsViewable = (int)Math.Round((double)(((double)(this.Height - this.barStartTop)) / ((double)(this.barHeight + this.barSpace))));
            int indexChartBar = this.GetIndexChartBar("QQQWWW");
            if (indexChartBar != 0)
            {
                int num2 = this.Height - 30;
                decimal num3 = new decimal((((double)num2) / ((double)indexChartBar)) * this.barsViewable);
                if (decimal.Compare(num3, new decimal(num2)) < 0)
                {
                    Brush gray;
                    Brush brush2;
                    Brush black;
                    decimal num4 = decimal.Divide(decimal.Subtract(new decimal(num2), num3), new decimal(indexChartBar - this.barsViewable));
                    this.scrollBarArea = new Rectangle(this.Width - 20, 0x13, 12, num2);
                    this.scroll = new Rectangle(this.Width - 20, Convert.ToInt32(decimal.Add(19M, decimal.Multiply(new decimal(this.scrollPosition), num4))), 12, Convert.ToInt32(num3));
                    this.topPart = new Rectangle(this.Width - 20, 10, 12, 8);
                    this.BottomPart = new Rectangle(this.Width - 20, this.Height - 10, 12, 8);
                    if (this.mouseOverTopPart)
                    {
                        black = Brushes.Black;
                    }
                    else
                    {
                        black = Brushes.Gray;
                    }
                    if (this.mouseOverBottomPart)
                    {
                        gray = Brushes.Black;
                    }
                    else
                    {
                        gray = Brushes.Gray;
                    }
                    if (this.mouseOverScrollBar)
                    {
                        brush2 = new LinearGradientBrush(this.scroll, Color.Bisque, Color.Gray, LinearGradientMode.Horizontal);
                    }
                    else
                    {
                        brush2 = new LinearGradientBrush(this.scroll, Color.White, Color.Gray, LinearGradientMode.Horizontal);
                    }
                    grfx.DrawRectangle(Pens.Black, this.topPart);
                    grfx.FillRectangle(Brushes.LightGray, this.topPart);
                    grfx.DrawRectangle(Pens.Black, this.BottomPart);
                    grfx.FillRectangle(Brushes.LightGray, this.BottomPart);
                    PointF[] points = new PointF[] { new PointF((float)this.topPart.Left, (float)(this.topPart.Bottom - 1)), new PointF((float)this.topPart.Right, (float)(this.topPart.Bottom - 1)), new PointF((float)(((double)(this.topPart.Left + this.topPart.Right)) / 2.0), (float)(this.topPart.Top + 1)) };
                    grfx.FillPolygon(black, points);
                    points[0] = new PointF((float)this.BottomPart.Left, (float)(this.BottomPart.Top + 1));
                    points[1] = new PointF((float)this.BottomPart.Right, (float)(this.BottomPart.Top + 1));
                    points[2] = new PointF((float)(((double)(this.BottomPart.Left + this.BottomPart.Right)) / 2.0), (float)(this.BottomPart.Bottom - 1));
                    grfx.FillPolygon(gray, points);
                    grfx.DrawRectangle(Pens.Black, this.scrollBarArea);
                    grfx.FillRectangle(Brushes.DarkGray, this.scrollBarArea);
                    grfx.DrawRectangle(Pens.Black, this.scroll);
                    grfx.FillRectangle(brush2, this.scroll);
                }
            }
        }

        private void GanttChart_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.mouseOverBottomPart)
                {
                    this.ScrollOneDown();
                }
                else if (this.mouseOverTopPart)
                {
                    this.ScrollOneup();
                }
            }
        }

        public void GanttChart_MouseDragged(object sender, MouseEventArgs e)
        {
            if (this.mouseOverScrollBarArea)
            {
                this.ScrollPositionY = e.Location.Y;
            }
            if (this.AllowManualEditBar && (this.mouseHoverBarIndex > -1))
            {
                if (this.mouseHoverPart == MouseOverPart.BarLeftSide)
                {
                    this.barIsChanging = this.mouseHoverBarIndex;
                    this.bars[this.mouseHoverBarIndex].StartValue = this._mouseOverColumnValue;
                    this.PaintChart();
                }
                else if (this.mouseHoverPart == MouseOverPart.BarRightSide)
                {
                    this.barIsChanging = this.mouseHoverBarIndex;
                    this.bars[this.mouseHoverBarIndex].EndValue = this._mouseOverColumnValue;
                    this.PaintChart();
                }
            }
        }

        private void GanttChart_MouseLeave(object sender, EventArgs e)
        {
            this._mouseOverRowText = null;
            this._mouseOverRowValue = null;
            this.mouseHoverPart = MouseOverPart.Empty;
            this.PaintChart();
        }

        private void GanttChart_MouseMove(object sender, MouseEventArgs e)
        {
            if ((this.shownHeaderList != null) && (this.shownHeaderList.Count > 1))
            {
                if (e.Button != MouseButtons.Left)
                {
                    this.mouseHoverPart = MouseOverPart.Empty;
                    if (this.AllowManualEditBar && (this.barIsChanging >= 0))
                    {
                        BarChangedEventHandler barChangedEvent = this.BarChanged;
                        if (barChangedEvent != null)
                        {
                            ChartBarDate date2 = this.bars[this.barIsChanging];
                            object objectValue = RuntimeHelpers.GetObjectValue(date2.Value);
                            barChangedEvent(this, ref objectValue);
                            date2.Value = RuntimeHelpers.GetObjectValue(objectValue);
                        }
                        this.barIsChanging = -1;
                    }
                }
                this.mouseHoverBarIndex = -1;
                Point point = this.PointToClient(Cursor.Position);
                TimeSpan span = (TimeSpan)(this.shownHeaderList[1].Time - this.shownHeaderList[0].Time);
                int num3 = ((span.Days * 0x5a0) + (span.Hours * 60)) + span.Minutes;
                int num5 = this.shownHeaderList[1].StartLocation - this.shownHeaderList[0].StartLocation;
                decimal num4 = new decimal(((double)num5) / ((double)num3));
                int num2 = 0;
                if (point.X > this.barStartLeft)
                {
                    num2 = Convert.ToInt32(decimal.Divide(new decimal(point.X - this.barStartLeft), num4));
                    this._mouseOverColumnValue = this.FromDate.AddMinutes((double)num2);
                }
                else
                {
                    this._mouseOverColumnValue = new DateTime();
                }
                string text = "";
                object obj2 = null;
                bool flag = false;
                if ((((point.X > this.BottomPart.Left) & (point.Y < this.BottomPart.Right)) & (point.Y < this.BottomPart.Bottom)) & (point.Y > this.BottomPart.Top))
                {
                    if (!this.mouseOverBottomPart)
                    {
                        flag = true;
                    }
                    this.mouseOverBottomPart = true;
                }
                else
                {
                    if (!this.mouseOverBottomPart)
                    {
                        flag = true;
                    }
                    this.mouseOverBottomPart = false;
                }
                if ((((point.X > this.topPart.Left) & (point.Y < this.topPart.Right)) & (point.Y < this.topPart.Bottom)) & (point.Y > this.topPart.Top))
                {
                    if (!this.mouseOverTopPart)
                    {
                        flag = true;
                    }
                    this.mouseOverTopPart = true;
                }
                else
                {
                    if (!this.mouseOverTopPart)
                    {
                        flag = true;
                    }
                    this.mouseOverTopPart = false;
                }
                if ((((point.X > this.scroll.Left) & (point.Y < this.scroll.Right)) & (point.Y < this.scroll.Bottom)) & (point.Y > this.scroll.Top))
                {
                    if (!this.mouseOverScrollBar)
                    {
                        flag = true;
                    }
                    this.mouseOverScrollBar = true;
                    this.mouseOverScrollBarArea = true;
                }
                else
                {
                    if (!this.mouseOverScrollBar)
                    {
                        flag = true;
                    }
                    this.mouseOverScrollBar = false;
                    this.mouseOverScrollBarArea = false;
                }
                if (!this.mouseOverScrollBarArea && ((((point.X > this.scrollBarArea.Left) & (point.Y < this.scrollBarArea.Right)) & (point.Y < this.scrollBarArea.Bottom)) & (point.Y > this.scrollBarArea.Top)))
                {
                    this.mouseOverScrollBarArea = true;
                }
                int num = 0;
                foreach (ChartBarDate date in this.bars)
                {
                    if (!date.HideFromMouseMove)
                    {
                        if (DateTime.Compare(date.EndValue, DateTime.MinValue) == 0)
                        {
                            date.EndValue = DateTime.Now;
                        }
                        if ((point.Y > date.TopLocation.Left.Y) & (point.Y < date.BottomLocation.Left.Y))
                        {
                            if ((point.X > date.TopLocation.Left.X) & (point.X < date.TopLocation.Right.X))
                            {
                                text = date.Text;
                                obj2 = RuntimeHelpers.GetObjectValue(date.Value);
                                this.mouseHoverBarIndex = num;
                                if ((this.mouseHoverPart != MouseOverPart.BarLeftSide) & (this.mouseHoverPart != MouseOverPart.BarRightSide))
                                {
                                    this.mouseHoverPart = MouseOverPart.Bar;
                                }
                            }
                            if (this.AllowManualEditBar)
                            {
                                int num6 = 5;
                                if (e.Button == MouseButtons.Left)
                                {
                                    num6 = 50;
                                }
                                if (((point.X > (date.TopLocation.Left.X - num6)) & (point.X < (date.TopLocation.Left.X + num6))) & (this.mouseHoverPart != MouseOverPart.BarRightSide))
                                {
                                    this.Cursor = Cursors.VSplit;
                                    this.mouseHoverPart = MouseOverPart.BarLeftSide;
                                    this.mouseHoverBarIndex = num;
                                }
                                else if (((point.X > (date.TopLocation.Right.X - num6)) & (point.X < (date.TopLocation.Right.X + num6))) & (this.mouseHoverPart != MouseOverPart.BarLeftSide))
                                {
                                    this.Cursor = Cursors.VSplit;
                                    this.mouseHoverPart = MouseOverPart.BarRightSide;
                                    this.mouseHoverBarIndex = num;
                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                }
                            }
                        }
                    }
                    num++;
                }
                this._mouseOverRowText = text;
                this._mouseOverRowValue = RuntimeHelpers.GetObjectValue(obj2);
                if (e.Button == MouseButtons.Left)
                {
                    MouseDraggedEventHandler mouseDraggedEvent = this.MouseDragged;
                    if (mouseDraggedEvent != null)
                    {
                        mouseDraggedEvent(RuntimeHelpers.GetObjectValue(sender), e);
                    }
                }
                else if ((((this._mouseOverRowValue == null) & (obj2 != null)) | ((this._mouseOverRowValue != null) & (obj2 == null))) | flag)
                {
                    this.PaintChart();
                }
            }
        }

        private void GanttChart_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.ScrollOneup();
            }
            else
            {
                this.ScrollOneDown();
            }
        }

        private List<Header> GetFullHeaderList()
        {
            List<Header> list2 = new List<Header>();
            DateTime fromDate = this.FromDate;
            DateTime time = new DateTime(this.FromDate.Year, this.FromDate.Month, fromDate.Day);
            TimeSpan span = (TimeSpan)(this.ToDate - this.FromDate);
            if (span.TotalDays < 1.0)
            {
                fromDate = this.FromDate;
                time = time.AddHours((double)fromDate.Hour);
                if ((this.headerFromDate.Minute < 0x3b) & (this.headerFromDate.Minute > 0x1d))
                {
                    time = time.AddMinutes(30.0);
                }
                else
                {
                    time = time.AddMinutes(0.0);
                }
                while (DateTime.Compare(time, this.ToDate) <= 0)
                {
                    string str = time.Hour.ToString() + ":";
                    if (time.Minute < 10)
                    {
                        str = str + "0" + time.Minute.ToString();
                    }
                    else
                    {
                        str = str + "" + time.Minute.ToString();
                    }
                    Header item = new Header
                    {
                        HeaderText = str,
                        HeaderTextInsteadOfTime = ""
                    };
                    fromDate = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, 0);
                    item.Time = fromDate;
                    list2.Add(item);
                    time = time.AddMinutes(5.0);
                }
                return list2;
            }
            if (span.TotalDays >= 60.0)
            {
                while (DateTime.Compare(time, this.ToDate) <= 0)
                {
                    Header header3 = new Header
                    {
                        HeaderText = ""
                    };
                    fromDate = new DateTime(time.Year, time.Month, time.Day, 0, 0, 0);
                    header3.Time = fromDate;
                    header3.HeaderTextInsteadOfTime = time.ToString("MMM");
                    list2.Add(header3);
                    time = time.AddMonths(1);
                }
                return list2;
            }
            while (DateTime.Compare(time, this.ToDate) <= 0)
            {
                Header header2 = new Header
                {
                    HeaderText = "",
                    HeaderTextInsteadOfTime = ""
                };
                fromDate = new DateTime(time.Year, time.Month, time.Day, 0, 0, 0);
                header2.Time = fromDate;
                list2.Add(header2);
                time = time.AddDays(1.0);
            }
            return list2;
        }

        public int GetIndexChartBar(string rowText)
        {
            int rowIndex = -1;
            foreach (ChartBarDate date in this.bars)
            {
                if (date.Text.Equals(rowText))
                {
                    return date.RowIndex;
                }
                if (date.RowIndex > rowIndex)
                {
                    rowIndex = date.RowIndex;
                }
            }
            return (rowIndex + 1);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.PaintChart(pe.Graphics);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.scrollPosition = 0;
            if (this.lastLineStop > 0)
            {
                this.objBmp = new Bitmap(this.Width - this.barStartRight, this.lastLineStop, PixelFormat.Format24bppRgb);
                this.objGraphics = Graphics.FromImage(this.objBmp);
            }
            this.PaintChart();
        }

        public void PaintChart()
        {
            this.Invalidate();
        }

        private void PaintChart(Graphics gfx)
        {
            gfx.Clear(this.BackColor);
            if (!((DateTime.Compare(this.headerFromDate, DateTime.MinValue) == 0) | (DateTime.Compare(this.headerToDate, DateTime.MinValue) == 0)))
            {
                this.DrawScrollBar(gfx);
                this.DrawHeader(gfx, null);
                this.DrawNetHorizontal(gfx);
                this.DrawNetVertical(gfx);
                this.DrawBars(gfx, false);
                this.objBmp = new Bitmap(this.Width - this.barStartRight, this.lastLineStop, PixelFormat.Format24bppRgb);
                this.objGraphics = Graphics.FromImage(this.objBmp);
            }
        }


        public void RemoveBars()
        {
            this.bars = new List<ChartBarDate>();
            this.barStartLeft = 100;
        }

        public void SaveImage(string filePath)
        {
            this.objGraphics.SmoothingMode = SmoothingMode.HighSpeed;
            this.objGraphics.Clear(this.BackColor);
            if (!((DateTime.Compare(this.headerFromDate, DateTime.MinValue) == 0) | (DateTime.Compare(this.headerToDate, DateTime.MinValue) == 0)))
            {
                this.DrawHeader(this.objGraphics, null);
                this.DrawNetHorizontal(this.objGraphics);
                this.DrawNetVertical(this.objGraphics);
                this.DrawBars(this.objGraphics, true);
                this.objBmp.Save(filePath);
            }
        }

        public void ScrollOneDown()
        {
            if ((this.scrollPosition + this.barsViewable) < this.GetIndexChartBar("QQQWWW"))
            {
                this.scrollPosition++;
                this.PaintChart();
            }
        }

        public void ScrollOneup()
        {
            if (this.scrollPosition != 0)
            {
                this.scrollPosition--;
                this.PaintChart();
            }
        }

        private void SetBarStartLeft(string rowText)
        {
            int num = (int)Math.Round((double)this.CreateGraphics().MeasureString(rowText, this.rowTextFont, 500).Width);
            if (num > this.barStartLeft)
            {
                this.barStartLeft = num;
            }
        }

        private void ToolTipText_Draw(System.Object sender, System.Windows.Forms.DrawToolTipEventArgs e)
        {
            if (ToolTipText == null)
            {
                ToolTipText = new List<string>();
                return;
            }

            if (ToolTipText.Count == 0)
            {
                return;
            }
            else if (ToolTipText[0].Length == 0)
            {
                return;
            }

            int x = 0;
            int y = 0;

            e.Graphics.FillRectangle(Brushes.AntiqueWhite, e.Bounds);
            e.DrawBorder();

            int titleHeight = 14;
            int fontHeight = 12;

            // Draws the line just below the title

            e.Graphics.DrawLine(Pens.Black, 0, titleHeight, e.Bounds.Width, titleHeight);

            int lines = 1;
            string text = ToolTipTextTitle;

            // Draws the title

            using (Font font = new Font(e.Font, FontStyle.Bold))
            {
                x = Convert.ToInt32((e.Bounds.Width - e.Graphics.MeasureString(text, font).Width) / 2);
                y = Convert.ToInt32((titleHeight - e.Graphics.MeasureString(text, font).Height) / 2);
                e.Graphics.DrawString(text, font, Brushes.Black, x, y);
            }

            // Draws the lines
            for (int i = 0; i < ToolTipText.Count; i++)
            {
                Font font = new Font(e.Font, FontStyle.Regular);

                if (ToolTipText[i].Contains("[b]"))
                {
                    font = new Font(font.FontFamily, font.Size, FontStyle.Bold, font.Unit);
                    ToolTipText[i] = ToolTipText[i].Replace("[b]", "");
                }

                using (font)
                {
                    x = 5;
                    y = Convert.ToInt32((titleHeight - fontHeight - e.Graphics.MeasureString(ToolTipText[i], font).Height) / 2 + 10 + (lines * 14));
                    e.Graphics.DrawString(ToolTipText[i], font, Brushes.Black, x, y);
                }

                lines += 1;
            }
            //foreach (string str in ToolTipText)
            //{
            //    Font font = new Font(e.Font, FontStyle.Regular);

            //    if (str.Contains("[b]"))
            //    {
            //        font = new Font(font.FontFamily, font.Size, FontStyle.Bold, font.Unit);
            //        str = str.Replace("[b]", "");
            //    }

            //    using (font)
            //    {
            //        x = 5;
            //        y = Convert.ToInt32((titleHeight - fontHeight - e.Graphics.MeasureString(str, font).Height) / 2 + 10 + (lines * 14));
            //        e.Graphics.DrawString(str, font, Brushes.Black, x, y);
            //    }

            //    lines += 1;
            //}
        }


        private void ToolTipText_Popup(object sender, PopupEventArgs e)
        {
            Size size;
            if (this.ToolTipText == null)
            {
                this.ToolTipText = new List<string>();
            }
            if (this.ToolTipText.Count == 0)
            {
                size = new Size(0, 0);
                e.ToolTipSize = size;
            }
            else if (this.ToolTipText[0].Length == 0)
            {
                size = new Size(0, 0);
                e.ToolTipSize = size;
            }
            else
            {
                int height = 0x12 + (this.ToolTipText.Count * 15);
                size = new Size(200, height);
                e.ToolTipSize = size;
            }
        }

        // Properties
        public bool AllowManualEditBar
        {
            get
            {
                return this._allowEditBarWithMouse;
            }
            set
            {
                this._allowEditBarWithMouse = value;
            }
        }

        public Font DateFont
        {
            get
            {
                return this.dateTextFont;
            }
            set
            {
                this.dateTextFont = value;
            }
        }

        public DateTime FromDate
        {
            get
            {
                return this.headerFromDate;
            }
            set
            {
                this.headerFromDate = value;
            }
        }

        public Pen GridColor
        {
            get
            {
                return this.lineColor;
            }
            set
            {
                this.lineColor = value;
            }
        }

        public DateTime MouseOverColumnDate
        {
            get
            {
                return this._mouseOverColumnValue;
            }
        }

        public string MouseOverRowText
        {
            get
            {
                return this._mouseOverRowText;
            }
        }

        public object MouseOverRowValue
        {
            get
            {
                return this._mouseOverRowValue;
            }
        }

        public Font RowFont
        {
            get
            {
                return this.rowTextFont;
            }
            set
            {
                this.rowTextFont = value;
            }
        }

        private int ScrollPositionY
        {
            get
            {
                
                if (this.scroll == null)
                {
                    return -1;
                }
                return (int)Math.Round((double)(((((double)this.scroll.Height) / 2.0) + this.scroll.Location.Y) + 19.0));
            }
            set
            {
                int indexChartBar = this.GetIndexChartBar("QQQWWW");
                int num4 = this.Height - 30;
                decimal num5 = new decimal((((double)num4) / ((double)indexChartBar)) * this.barsViewable);
                decimal num6 = decimal.Divide(decimal.Subtract(new decimal(num4), num5), new decimal(indexChartBar - this.barsViewable));
                int num3 = 0;
                int num2 = 0x270f;
                while (num3 < indexChartBar)
                {
                    int num8 = (int)Math.Round((double)(Convert.ToDouble(decimal.Add(decimal.Multiply(new decimal(num3), num6), decimal.Divide(num5, 2M))) + 15.0));
                    int num7 = num8 - value;
                    if (num2 < 0)
                    {
                        if (num7 < num2)
                        {
                            this.scrollPosition = num3 - 1;
                            this.PaintChart();
                            break;
                        }
                    }
                    else if (num7 > num2)
                    {
                        this.scrollPosition = num3 - 1;
                        if ((this.scrollPosition + this.barsViewable) > this.GetIndexChartBar("QQQWWW"))
                        {
                            this.scrollPosition = this.GetIndexChartBar("QQQWWW") - this.barsViewable;
                        }
                        this.PaintChart();
                        break;
                    }
                    num2 = num7;
                    num3++;
                }
            }
        }

        public Font TimeFont
        {
            get
            {
                return this.timeTextFont;
            }
            set
            {
                this.timeTextFont = value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                return this.headerToDate;
            }
            set
            {
                this.headerToDate = value;
            }
        }

        internal virtual ToolTip ToolTip
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolTip;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                PopupEventHandler handler = new PopupEventHandler(this.ToolTipText_Popup);
                DrawToolTipEventHandler handler2 = new DrawToolTipEventHandler(this.ToolTipText_Draw);
                if (this._ToolTip != null)
                {
                    this._ToolTip.Popup -= handler;
                    this._ToolTip.Draw -= handler2;
                }
                this._ToolTip = value;
                if (this._ToolTip != null)
                {
                    this._ToolTip.Popup += handler;
                    this._ToolTip.Draw += handler2;
                }
            }
        }

        public List<string> ToolTipText
        {
            get
            {
                if (this._toolTipText == null)
                {
                    this._toolTipText = new List<string>();
                }
                return this._toolTipText;
            }
            set
            {
                this._toolTipText = value;
                Point point = this.PointToClient(Cursor.Position);
                if (point != this.MyPoint)
                {
                    this.MyPoint = point;
                    this.ToolTip.SetToolTip(this, ".");
                }
            }
        }

        public string ToolTipTextTitle
        {
            get
            {
                return this._toolTipTextTitle;
            }
            set
            {
                this._toolTipTextTitle = value;
            }
        }

        // Nested Types
        public delegate void BarChangedEventHandler(object sender, ref object barValue);

        private class ChartBarDate
        {
            // Fields
            private Location _bottomLocation = new Location();
            private Color _color;
            private DateTime _endValue;
            private bool _hideFromMouseMove = false;
            private Color _hoverColor;
            private int _rowIndex;
            private DateTime _startValue;
            private string _text;
            private Location _topLocation = new Location();
            private object _value;

            // Properties
            internal Location BottomLocation
            {
                get
                {
                    return this._bottomLocation;
                }
                set
                {
                    this._bottomLocation = value;
                }
            }

            public Color Color
            {
                get
                {
                    return this._color;
                }
                set
                {
                    this._color = value;
                }
            }

            public DateTime EndValue
            {
                get
                {
                    return this._endValue;
                }
                set
                {
                    this._endValue = value;
                }
            }

            public bool HideFromMouseMove
            {
                get
                {
                    return this._hideFromMouseMove;
                }
                set
                {
                    this._hideFromMouseMove = value;
                }
            }

            public Color HoverColor
            {
                get
                {
                    return this._hoverColor;
                }
                set
                {
                    this._hoverColor = value;
                }
            }

            public int RowIndex
            {
                get
                {
                    return this._rowIndex;
                }
                set
                {
                    this._rowIndex = value;
                }
            }

            public DateTime StartValue
            {
                get
                {
                    return this._startValue;
                }
                set
                {
                    this._startValue = value;
                }
            }

            public string Text
            {
                get
                {
                    return this._text;
                }
                set
                {
                    this._text = value;
                }
            }

            internal Location TopLocation
            {
                get
                {
                    return this._topLocation;
                }
                set
                {
                    this._topLocation = value;
                }
            }

            public object Value
            {
                get
                {
                    return this._value;
                }
                set
                {
                    this._value = RuntimeHelpers.GetObjectValue(value);
                }
            }

            // Nested Types
            internal class Location
            {
                // Fields
                private Point _left = new Point(0, 0);
                private Point _right = new Point(0, 0);

                // Properties
                public Point Left
                {
                    get
                    {
                        return this._left;
                    }
                    set
                    {
                        this._left = value;
                    }
                }

                public Point Right
                {
                    get
                    {
                        return this._right;
                    }
                    set
                    {
                        this._right = value;
                    }
                }
            }
        }

        private class Header
        {
            // Fields
            private string _headerText;
            private string _headerTextInsteadOfTime = "";
            private int _startLocation;
            private DateTime _time = new DateTime();

            // Properties
            public string HeaderText
            {
                get
                {
                    return this._headerText;
                }
                set
                {
                    this._headerText = value;
                }
            }

            public string HeaderTextInsteadOfTime
            {
                get
                {
                    return this._headerTextInsteadOfTime;
                }
                set
                {
                    this._headerTextInsteadOfTime = value;
                }
            }

            public int StartLocation
            {
                get
                {
                    return this._startLocation;
                }
                set
                {
                    this._startLocation = value;
                }
            }

            public DateTime Time
            {
                get
                {
                    return this._time;
                }
                set
                {
                    this._time = value;
                }
            }
        }

        public delegate void MouseDraggedEventHandler(object sender, MouseEventArgs e);

        private enum MouseOverPart
        {
            Empty,
            Bar,
            BarLeftSide,
            BarRightSide
        }

        public static DataTable GetRankedDatatable(DataTable dt)
        {
            var rankedDt = (from row in dt.AsEnumerable()
                            orderby row.Field<string>("name")
                            select row).CopyToDataTable();
            rankedDt.Columns.Add("rank");
            int rank = 0;
            for (int i = 0; i < rankedDt.Rows.Count - 1; i++)
            {
                rankedDt.Rows[i]["rank"] = rank;
                if (rankedDt.Rows[i]["name"].ToString() != rankedDt.Rows[i + 1]["name"].ToString())
                {
                    rank++;
                }
            }
            rankedDt.Rows[rankedDt.Rows.Count - 1]["rank"] = rank;
            return rankedDt;
        }
        /// <summary>
        /// Max min date will be infered
        /// sets gant chart from datatable
        /// </summary>
        /// <param name="dt">should contain columns  dtFrom,dtTo,name but not id column</param>
        public void DrawGanttChart(DataTable dt)
        { //find min max
            var mindt = (from row in dt.AsEnumerable()
                         select row.Field<string>("dtFrom")).Min();
            var maxdt = (from row in dt.AsEnumerable()
                         select row.Field<string>("dtTo")).Max();
            DateTime maxDt = new DateTime(int.Parse(maxdt.Substring(0, 4)), int.Parse(maxdt.Substring(4, 2)), int.Parse(maxdt.Substring(6, 2)));
            DateTime minDt = new DateTime(int.Parse(mindt.Substring(0, 4)), int.Parse(mindt.Substring(4, 2)), int.Parse(mindt.Substring(6, 2)));

            DrawGanttChart(dt, maxDt, minDt);
        }

        /// <summary>
        /// sets gant chart from datatable
        /// </summary>
        /// <param name="dt">should contain columns  dtFrom,dtTo,name but not id column</param>
        public void DrawGanttChart(DataTable dt, DateTime minDt, DateTime maxDt)
        {
            if (dt.Rows.Count < 1)
            {
                return;
            }
            DataTable dtRanked = GetRankedDatatable(dt);




            this.FromDate = minDt;
            this.ToDate = maxDt;

            foreach (DataRow item in dtRanked.Rows)
            {
                string dtfrom = item["dtFrom"].ToString();
                string dtTo = item["dtTo"].ToString();
                DateTime dFrom = new DateTime(int.Parse(dtfrom.Substring(0, 4)), int.Parse(dtfrom.Substring(4, 2)), int.Parse(dtfrom.Substring(6, 2)));
                DateTime dTo = new DateTime(int.Parse(dtTo.Substring(0, 4)), int.Parse(dtTo.Substring(4, 2)), int.Parse(dtTo.Substring(6, 2)));
                BarInformation bar = new BarInformation(item["name"].ToString(), dFrom, dTo, Color.Aqua, Color.Khaki, int.Parse(item["rank"].ToString()));
                this.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
        }

        public void ClearChart()
        {
            this.Invalidate();
        }
    }



    public class BarInformation
    {
        // Fields
        private Color _color;
        private DateTime _fromTime;
        private Color _hoverColor;
        private int _index;
        private string _rowText;
        private DateTime _toTime;

        // Methods
        public BarInformation(string rowText, DateTime fromTime, DateTime totime, Color color, Color hoverColor, int index)
        {
            this.RowText = rowText;
            this.FromTime = fromTime;
            this.ToTime = totime;
            this.Color = color;
            this.HoverColor = hoverColor;
            this.Index = index;
        }

        // Properties
        public Color Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public DateTime FromTime
        {
            get
            {
                return this._fromTime;
            }
            set
            {
                this._fromTime = value;
            }
        }

        public Color HoverColor
        {
            get
            {
                return this._hoverColor;
            }
            set
            {
                this._hoverColor = value;
            }
        }

        public int Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }

        public string RowText
        {
            get
            {
                return this._rowText;
            }
            set
            {
                this._rowText = value;
            }
        }

        public DateTime ToTime
        {
            get
            {
                return this._toTime;
            }
            set
            {
                this._toTime = value;
            }
        }
    }









}
