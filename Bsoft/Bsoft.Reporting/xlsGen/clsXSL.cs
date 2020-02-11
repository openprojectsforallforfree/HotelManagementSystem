using System;
using System.Collections.Generic;
 
using System.Text;
using Bsoft.Reporting.xls;
 
using System.Drawing;
namespace Bsoft.Reporting.xls
{

    //root  has> Layoutmasterset and pagesequence
    //          Layoutmasterset has > Page masters
    //          pagesequence has > header , footer ,body
    //                  Page master uses >dimensions
    public class xslRoot
    {
        layoutMasterSet lms_; PageSequenceSet ps_;
        
        public xslRoot(layoutMasterSet lms, PageSequenceSet ps)
        {
            lms_ = lms;
            ps_ = ps;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<xsl:stylesheet version=\"1.0\" xml:space=\"default\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\" xmlns:fo=\"http://www.w3.org/1999/XSL/Format\" xmlns:fox=\"http://xml.apache.org/fop/extensions\" xmlns:xi=\"http://www.w3.org/2001/Xinclude\">");
            sb.Append("<xsl:preserve-space elements=\"text\"/>");
            sb.Append("<xsl:output method=\"xml\" encoding=\"UTF-8\" indent=\"yes\"/>");
            sb.Append("<xsl:template match=\"/\">");
            sb.Append("<fo:root xmlns:fo=\"http://www.w3.org/1999/XSL/Format\">");

            sb.Append(lms_.ToString());
            sb.Append(ps_.ToString());
            sb.Append("  </fo:root>");
            sb.Append(" </xsl:template>");
            sb.Append("</xsl:stylesheet>");
            return utililty.RemoveTroublesomeCharacters(sb.ToString());
        }
    }
    //          Layoutmasterset has > Page masters

    public class general
    {
        public StringBuilder sb = new StringBuilder();

    }
    public class forloop : general
    {
        node content;

        public forloop(node Content)
        {
            this.content = Content;
        }
        public override string ToString()
        {
            sb.Append("<xsl:for-each select=");
            sb.Append(utililty.getQuoted(content.ToString()));
            sb.Append(">");
            return sb.ToString();
        }
    }

    public class pdf
    {

        //public cell c;
        //public cells cls;
        //public borderDesign bd;
        //public border bdr;
        //public row rw;
        //public column col;
        //public columns cols;
        //public table_body tbdy;
        //public table tbl;
        //public block blkt;
        //public font fnt;
        //public block blk;
        public Header header;
        public Footer footer;
        public Body body;
        public PageSequence pagesequence;
        public PageSequenceSet pageseqSet;
        public pageDimension pagedimension;
        public pageMaster pagemaster;
        public layoutMasterSet lms;
        private xslRoot r;

        public pdf()
        {
            //Default Page Dimension
            pagedimension = new pageDimension(pageSize.A4, pageOrientation.Landscape, 0.5, 0.5, 0.5, 0.5, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1);

            header = new Header();
            footer = new Footer();
            body = new Body();
        }
        public pdf(pageDimension pagedimension)
        {
            header = new Header();
            footer = new Footer();
            body = new Body();

            this.pagedimension = pagedimension;
        }
        public override string ToString()
        {
            //public font fnt = new font("courier", 15, font_weight.bold, font_style.italic);
            //public block blk = new block("Hello World!");
            return singlePage();
        }
        public string singlePage()
        {
            pagesequence = new PageSequence("Project", header, footer, body);
            pageseqSet = new PageSequenceSet(pagesequence);
            pagemaster = new pageMaster("Project", pagedimension);
            lms = new layoutMasterSet(pagemaster);
            r = new xslRoot(lms, pageseqSet);
            return r.ToString();
        }
        public string singlePage(Header header, Footer footer, Body body)
        {
            //public cell c = new cell("Hi");
            //public cells cls = new cells();
            //public borderDesign bd = new borderDesign(border_width.medium, border_style.dotted, Color.Bisque);
            //public border bdr = new border();
            //public row rw = new row(cls, bdr);
            //public column col = new column("5%", bdr);
            //public columns cols = new columns();
            //public table_body tbdy = new table_body(rw);
            //public table tbl = new table(cols, tbdy);
            //public block blkt = new block(tbl.ToString());
            //public font fnt = new font("courier", 15, font_weight.bold, font_style.italic);
            //public block blk = new block("Hello World!");
            //public Header header = new Header(blk.ToString());
            //public Footer footer = new Footer(blk.ToString());
            //public Body body = new Body(blk.ToString() + blkt.ToString());
            pagesequence = new PageSequence("Project", header, footer, body);
            pageseqSet = new PageSequenceSet(pagesequence);
            pagemaster = new pageMaster("Project", pagedimension);
            lms = new layoutMasterSet(pagemaster);
            r = new xslRoot(lms, pageseqSet);
            return r.ToString();
        }
        public string generate()
        {
            return r.ToString();
        }
    }

    #region "Layoutmasterset"

    public class layoutMasterSet
    {
        string pagemasterstring = "";
        public layoutMasterSet()
        {

        }
        public layoutMasterSet(pageMaster pm)
        {
            pagemasterstring = pagemasterstring + pm.ToString();
        }
        public void add(pageMaster pm)
        {
            pagemasterstring = pagemasterstring + pm.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  <fo:layout-master-set>");
            sb.Append(pagemasterstring);
            sb.Append("  </fo:layout-master-set>");
            return sb.ToString();
        }

    }

    public class pageMaster
    {

        public pageMaster(string sequencename_, pageDimension pageDimension_)
        {
            pageDimension = pageDimension_;
            sequencename = sequencename_;
        }
        public pageDimension pageDimension
        {
            get;
            set;
        }
        public string sequencename
        { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:simple-page-master master-name=\"" + sequencename + "\" page-height =\"" + pageDimension.pageheight + "in\"  page-width =\"" + pageDimension.pagewidth + "in\" " +
                " margin-top=\"" + pageDimension.margintop + "in\" margin-left=\"" + pageDimension.marginLeft + "in\" margin-right=\"" + pageDimension.marginRight + "in\" margin-bottom=\"" + pageDimension.marginbottom + "in\">");
            sb.Append("<fo:region-body margin-top=" + utililty.getQuoted(pageDimension.BodymarginTop + "in") + "/>");
            sb.Append("<fo:region-before extent=" + utililty.getQuoted(pageDimension.ExtentTop + "in") + " />");

            sb.Append(" <fo:region-after/>");
            sb.Append(" <fo:region-start/>");
            sb.Append(" <fo:region-end/>");
            sb.Append("</fo:simple-page-master>");
            return sb.ToString();
        }
    }

    public enum pageSize
    {
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        A7,
        A8,
        A9,
        A10

    }


    public enum pageOrientation
    {
        Portrait,
        Landscape
    }


    public class font
    {
        public double Size { get; set; }
        public font_style style { get; set; }
        public text_decoration decoration { get; set; }
        public font_weight weight { get; set; }
        public wrap_option wrap_option { get; set; }
        public text_align text_align { get; set; }
        public display_align display_align { get; set; }
        public string fontfamily { get; set; }
        public white_space_collapse white_space_collapse { get; set; }
        public System.Drawing.Color font_Color { get; set; }
        public System.Drawing.Color background_Color { get; set; }

        public font()
        {
        }
        public font(double fontsize, font_weight fontweight)
        {
            Size = fontsize;
            weight = fontweight;
        }
        public font(string fontface, double fontsize, font_weight fontweight, font_style fontstyle)
        {
            Size = fontsize;
            weight = fontweight;
            style = fontstyle;

            fontfamily = fontface;
        }
        public font(string fontface, double fontsize, font_weight fontweight, font_style fontstyle, text_decoration fontdecoration,
            wrap_option wrap, text_align horizontalalign, display_align verticalaligh, white_space_collapse whitespacecollapse
            , System.Drawing.Color fontcolor, System.Drawing.Color backgroundcolor)
        {

            Size = fontsize;
            weight = fontweight;
            style = fontstyle;
            decoration = fontdecoration;
            wrap_option = wrap;
            text_align = horizontalalign;
            display_align = verticalaligh;
            white_space_collapse = whitespacecollapse;
            fontfamily = fontface;
            background_Color = backgroundcolor;
            font_Color = fontcolor;

        }





        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            if (Size != 0)
            {
                sb.Append(" font-size= " + utililty.getQuoted(10, "pt"));
            }
            switch (weight)
            {
                case font_weight.normal:

                    break;
                case font_weight.bold:
                    sb.Append(" font-weight= " + utililty.getQuoted("bold"));
                    break;
                case font_weight.bolder:
                    sb.Append(" font-weight= " + utililty.getQuoted("bolder"));
                    break;
                case font_weight.lighter:
                    sb.Append(" font-weight= " + utililty.getQuoted("lighter"));
                    break;
                default:
                    break;
            }

            switch (style)
            {
                case font_style.normal:

                    break;
                case font_style.italic:
                    sb.Append(" font-style= " + utililty.getQuoted("italic"));
                    break;
                default:
                    break;
            }

            switch (decoration)
            {
                case text_decoration.none:
                    break;
                case text_decoration.underline:
                    sb.Append(" font-decoration= " + utililty.getQuoted("underline"));
                    break;
                case text_decoration.overline:
                    sb.Append(" font-decoration= " + utililty.getQuoted("overline"));
                    break;
                case text_decoration.line_through:
                    sb.Append(" font-decoration= " + utililty.getQuoted("line_through"));
                    break;
                default:
                    break;
            }

            switch (wrap_option)
            {
                case wrap_option.wrap:
                    sb.Append(" wrap-option= " + utililty.getQuoted("wrap"));
                    break;
                case wrap_option.nowrap:
                    break;
                default:
                    break;
            }

            switch (text_align)
            {
                case text_align.none:
                    break;
                case text_align.left:
                    sb.Append(" text-align= " + utililty.getQuoted("left"));
                    break;
                case text_align.center:
                    sb.Append(" text-align= " + utililty.getQuoted("center"));
                    break;
                case text_align.right:
                    sb.Append(" text-align= " + utililty.getQuoted("right"));
                    break;
                case text_align.justify:
                    sb.Append(" text-align= " + utililty.getQuoted("justify"));
                    break;
                default:
                    break;
            }
            switch (display_align)
            {
                case display_align.none:
                    break;
                case display_align.left:
                    sb.Append(" displa-align= " + utililty.getQuoted("left"));
                    break;
                case display_align.center:
                    sb.Append(" displa-align= " + utililty.getQuoted("center"));
                    break;
                case display_align.right:
                    sb.Append(" displa-align= " + utililty.getQuoted("right"));
                    break;
                default:
                    break;
            }

            switch (white_space_collapse)
            {
                case white_space_collapse.yes:
                    sb.Append(" white-space-collapse= " + utililty.getQuoted("true"));
                    break;
                case white_space_collapse.no:
                    break;
                default:
                    break;
            }
            if (fontfamily != "" & fontfamily != null)
            {
                sb.Append(" font-family= " + utililty.getQuoted(fontfamily));
            }

            if (font_Color != null & !font_Color.IsEmpty)
            {
                string CLRVAL = String.Format("#{0:X2}{1:X2}{2:X2}", font_Color.R, font_Color.G, font_Color.B);
                sb.Append(" color= " + utililty.getQuoted(CLRVAL));
            }
            if (background_Color != null & !background_Color.IsEmpty)
            {
                string CLRVAL = String.Format("#{0:X2}{1:X2}{2:X2}", background_Color.R, background_Color.G, background_Color.B);
                sb.Append(" backgournd-color= " + utililty.getQuoted(CLRVAL));
            }
            //String.Format("#{0:X2}{1:X2}{2:X2}", colorValue.R, colorValue.G, colorValue.B);
            //System.Drawing.Color c = System.Drawing.ColorTranslator.FromHtml("#F5F7F8");
            //String strHtmlColor = System.Drawing.ColorTranslator.ToHtml(c);
            //background-color="{concat('#',$bodyitemremark-tbb)}" 
            //color="{concat('#',$bodyitemremark-tc)}" 



            return sb.ToString();
        }
    }

    /// <summary>
    /// Useful for both margin and padding 
    /// hence the name
    /// </summary>
    public class gaping
    {
        public double all { get; set; }
        public double left { get; set; }
        public double right { get; set; }
        public double top { get; set; }
        public double bottom { get; set; }

    }

    public class margin : gaping
    {


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (top != 0)
            {
                sb.Append(" margin-top = " + utililty.getQuoted(top.ToString() + "in"));
            }
            if (bottom != 0)
            {
                sb.Append(" margin-bottom = " + utililty.getQuoted(bottom.ToString() + "in"));
            }
            if (left != 0)
            {
                sb.Append(" margin-left = " + utililty.getQuoted(left.ToString() + "in"));
            }
            if (right != 0)
            {
                sb.Append(" margin-right = " + utililty.getQuoted(right.ToString() + "in"));
            }
            if (all != 0)
            {
                sb.Append(" margin = " + utililty.getQuoted(all.ToString() + "in"));
            }

            return sb.ToString();
        }
    }

    public class padding : gaping
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (top != 0)
            {
                sb.Append(" padding-top = " + utililty.getQuoted(top.ToString() + "in"));
            }
            if (bottom != 0)
            {
                sb.Append(" padding-bottom = " + utililty.getQuoted(bottom.ToString() + "in"));
            }
            if (left != 0)
            {
                sb.Append(" padding-left = " + utililty.getQuoted(left.ToString() + "in"));
            }
            if (right != 0)
            {
                sb.Append(" padding-right = " + utililty.getQuoted(right.ToString() + "in"));
            }
            if (all != 0)
            {
                sb.Append(" padding = " + utililty.getQuoted(all.ToString() + "in"));
            }

            return sb.ToString();
        }
    }
    public class pageDimension
    {

        public pageDimension(double pageheight_, double pagewidth_,
            double margintop_, double marginbottom_, double marginLeft_, double marginRight_,
            double BodymarginTop_, double BodymarginBottom_, double BodymarginLeft_, double BodymarginRight_,
            double ExtentTop_, double ExtentBottom_
            )
        {
            pageheight = pageheight_;
            pagewidth = pagewidth_;
            margintop = margintop_;
            marginbottom = marginbottom_;
            marginLeft = marginLeft_;
            marginRight = marginRight_;

            BodymarginLeft = BodymarginLeft_;
            BodymarginRight = BodymarginRight_;
            BodymarginBottom = BodymarginBottom_;
            BodymarginTop = BodymarginTop_;

            ExtentTop = ExtentTop_;
            ExtentBottom = ExtentBottom_;
        }

        public pageDimension(pageSize pagesize_, pageOrientation pageOrientation_,
                    double margintop_, double marginbottom_, double marginLeft_, double marginRight_,
                    double BodymarginTop_, double BodymarginBottom_, double BodymarginLeft_, double BodymarginRight_,
                    double ExtentTop_, double ExtentBottom_
                    )
        {

            //for portrait


            switch (pagesize_)
            {
                case pageSize.A0:
                    pagewidth = 33.1; pageheight = 46.8;
                    break;
                case pageSize.A1:
                    pagewidth = 23.4; pageheight = 33.1;
                    break;
                case pageSize.A2:
                    pagewidth = 16.5; pageheight = 23.4;
                    break;
                case pageSize.A3:
                    pagewidth = 11.7; pageheight = 16.5;
                    break;
                case pageSize.A4:
                    pagewidth = 8.3; pageheight = 11.7;
                    break;
                case pageSize.A5:
                    pagewidth = 5.8; pageheight = 8.3;
                    break;
                case pageSize.A6:
                    pagewidth = 4.1; pageheight = 5.8;
                    break;
                case pageSize.A7:
                    pagewidth = 2.9; pageheight = 4.1;
                    break;
                case pageSize.A8:
                    pagewidth = 2; pageheight = 2.9;
                    break;
                case pageSize.A9:
                    pagewidth = 1.5; pageheight = 2;
                    break;
                case pageSize.A10:
                    pagewidth = 1; pageheight = 1.5;
                    break;
            }


            //swap for landscape
            if (pageOrientation_ == pageOrientation.Landscape)
            {
                double temp = 0;
                temp = pageheight;
                pageheight = pagewidth;
                pagewidth = temp;
            }
            margintop = margintop_;
            marginbottom = marginbottom_;
            marginLeft = marginLeft_;
            marginRight = marginRight_;

            BodymarginLeft = BodymarginLeft_;
            BodymarginRight = BodymarginRight_;
            BodymarginBottom = BodymarginBottom_;
            BodymarginTop = BodymarginTop_;

            ExtentTop = ExtentTop_;
            ExtentBottom = ExtentBottom_;
        }


        public margin pageMargin
        {
            get { return new margin(); }
            set
            {
                margintop = value.top;
                marginLeft = value.left;
                marginbottom = value.bottom;
                marginRight = value.right;
            }
        }
        public pageDimension(pageSize pagesize_, pageOrientation pageOrientation_,
                  margin pageMargin_,
                  margin bodyMargin,
                  double ExtentTop_, double ExtentBottom_
                  )
        {

            //for portrait


            switch (pagesize_)
            {
                case pageSize.A0:
                    pageheight = 33.1; pagewidth = 46.8;
                    break;
                case pageSize.A1:
                    pageheight = 23.4; pagewidth = 33.1;
                    break;
                case pageSize.A2:
                    pageheight = 16.5; pagewidth = 23.4;
                    break;
                case pageSize.A3:
                    pageheight = 11.7; pagewidth = 16.5;
                    break;
                case pageSize.A4:
                    pageheight = 8.3; pagewidth = 11.7;
                    break;
                case pageSize.A5:
                    pageheight = 5.8; pagewidth = 8.3;
                    break;
                case pageSize.A6:
                    pageheight = 4.1; pagewidth = 5.8;
                    break;
                case pageSize.A7:
                    pageheight = 2.9; pagewidth = 4.1;
                    break;
                case pageSize.A8:
                    pageheight = 2; pagewidth = 2.9;
                    break;
                case pageSize.A9:
                    pageheight = 1.5; pagewidth = 2;
                    break;
                case pageSize.A10:
                    pageheight = 1; pagewidth = 1.5;
                    break;
            }


            //swap for landscape
            if (pageOrientation_ == pageOrientation.Landscape)
            {
                double temp = 0;
                temp = pageheight;
                pageheight = pagewidth;
                pagewidth = temp;
            }

            margintop = pageMargin_.top;
            marginbottom = pageMargin_.bottom;
            marginLeft = pageMargin_.left;
            marginRight = pageMargin_.right;

            BodymarginLeft = bodyMargin.left;
            BodymarginRight = bodyMargin.right;
            BodymarginBottom = bodyMargin.bottom;
            BodymarginTop = bodyMargin.top;

            ExtentTop = ExtentTop_;
            ExtentBottom = ExtentBottom_;
        }



        public double pageheight { get; set; }
        public double pagewidth { get; set; }
        public double margintop { get; set; }
        public double marginbottom { get; set; }
        public double marginLeft { get; set; }
        public double marginRight { get; set; }

        public double BodymarginLeft { get; set; }
        public double BodymarginRight { get; set; }
        public double BodymarginBottom { get; set; }
        public double BodymarginTop { get; set; }


        public double ExtentTop { get; set; }
        public double ExtentBottom { get; set; }



    }
    #endregion

    #region PageSequence

    //dummy class to o wieht pagemasterset.
    public class PageSequenceSet
    {
        string pageSequenceString = "";
        public PageSequenceSet()
        {

        }
        public PageSequenceSet(PageSequence ps)
        {
            pageSequenceString = pageSequenceString + "\n" + ps.ToString();
        }
        public void add(PageSequence ps)
        {
            pageSequenceString = pageSequenceString + "\n" + ps.ToString();
        }
        public override string ToString()
        {
            return pageSequenceString;
        }

    }
    public class PageSequence
    {
        Header h_; Footer f_; Body b_;
        Header h
        {
            get
            {
                return h_;
            }
            set
            {
                h_ = value;
                headerText = h.ToString();
            }
        }
        Footer f
        {
            get
            {
                return f_;
            }
            set
            {
                f_ = value;
                footerText = f.ToString();
            }
        }
        Body b
        {
            get
            {
                return b_;
            }
            set
            {
                b_ = value;
                bodyText = b.ToString();
            }
        }

        string sequencename { get; set; }

        private string headerText;
        private string footerText;
        private string bodyText;

        public PageSequence(string sequencename_, Header h_, Footer f_, Body b_)
        {
            h = h_;
            f = f_;
            b = b_;
            sequencename = sequencename_;
        }
        public PageSequence(string sequencename_, string headerText_, string footerText_, string bodyText_)
        {
            headerText = headerText_;
            footerText = footerText_;
            bodyText = bodyText_;
            sequencename = sequencename_;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:page-sequence master-reference=\"" + sequencename + "\" >");
            sb.Append(headerText);
            sb.Append(footerText);
            sb.Append(bodyText);
            sb.Append("  </fo:page-sequence>");
            return sb.ToString();
        }

    }


    /// <summary>
    /// for overloading purpose only 
    /// </summary>
    public class Hfb
    {
        public StringBuilder sbcontent = new StringBuilder();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
        public void add(string content)
        {
            sbcontent.Append(content);
        }
        public void add(block content)
        {
            sbcontent.Append(content.ToString());
        }
        public void add(block_container content)
        {
            sbcontent.Append(content.ToString());
        }
    }

    public class Header : Hfb
    {
        public Header()
        { }
        public Header(string content)
        {
            sbcontent.Append(content);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:static-content flow-name=\"xsl-region-before\">");
            sb.Append(sbcontent.ToString());
            sb.Append(" </fo:static-content>");
            return sb.ToString();
        }

    }

    public class Footer : Hfb
    {
        public Footer() { }
        public Footer(string content)
        {
            sbcontent.Append(content);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:static-content flow-name=\"xsl-region-after\">");
            sb.Append(sbcontent.ToString());
            sb.Append(" </fo:static-content>");
            return sb.ToString();
        }

    }

    public class Body : Hfb
    {
        public Body() { }

        public Body(string content)
        {
            sbcontent.Append(content);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<fo:flow flow-name=\"xsl-region-body\" >");
            sb.Append(sbcontent.ToString());
            sb.Append("</fo:flow>");
            return sb.ToString();
        }

    }


    #endregion

    public class xslGenTemplate
    {
        string st;
        public void startXLS(string templatfile)
        {
            st = System.IO.File.ReadAllText(templatfile);
            st = st.Replace("_HeadingXMLNODE_", "Dheba");
            st = st.Replace("_SubHeadingLeft_Lable", "Dheba");
            st = st.Replace("_SubHeadingLeft_Value", "Dheba");
            st = st.Replace("_SubHeadingMid_Lable", "Dheba");
            st = st.Replace("_SubHeadingMid_Value", "Dheba");
            st = st.Replace("_SubHeadingRight_Lable", "Dheba");
            st = st.Replace("_SubHeadingRight_Value", "Dheba");
        }
        public void addContent(string content)
        {
            st = st.Replace("<!--_TableCode_-->", content);
        }
        public void closeXLS(string xlsOutFile)
        {
            System.IO.File.WriteAllText(xlsOutFile, st);

        }

    }




}

