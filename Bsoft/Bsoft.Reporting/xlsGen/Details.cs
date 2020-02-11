using System;
using System.Collections.Generic;
 
using System.Text;
 

namespace Bsoft.Reporting.xls
{

   
    public enum border_style
    {
        none,
        dashed,
        dotted,
        doubl,
        groove,
        hidden,
        inset,
        outset,
        ridge,
        solid
    }

    public enum border_width
    {
        vlaue,
        medium,
        thick,
        thin

    }
    /// <summary>
    /// actualy true false but they are type so used yes no 
    /// </summary>
    public enum white_space_collapse
    {
        no,
        yes,
    }

    public enum display_align
    {
        none,
        left,
        center,
        right
    }
    public enum table_layout
    {
        auto,
        fixxed
    }
    public enum text_align
    {
        none,
        left,
        center,
        right,
        justify
    }

    public enum wrap_option
    {
        nowrap,
        wrap

    }
    public enum font_style
    {
        normal,
        italic
    }
    public enum font_weight
    {
        normal,
        bold,
        bolder,
        lighter

    }
    public enum text_decoration
    {
        none,
        underline,
        overline,
        line_through
    }

    public static class utililty
    {

        public static string getQuoted(string str)
        {
            return "\"" + str + "\"";
        }

        public static string getQuoted(string str, string unit)
        {
            return "\"" + str + unit + "\"";

        }

        public static string getQuoted(double str)
        {
            return getQuoted(str.ToString());
        }

        public static string getQuoted(double str, string unit)
        {
            return getQuoted(str.ToString(), unit);
        }


        /// <summary>
        /// Removes control characters and other non-UTF-8 characters
        /// </summary>
        /// <param name="inString">The string to process</param>
        /// <returns>A string with no control characters or entities above 0x00FD</returns>
        public static string RemoveTroublesomeCharacters(string inString)
        {
            if (inString == null) return null;

            StringBuilder newString = new StringBuilder();
            char ch;

            for (int i = 0; i < inString.Length; i++)
            {

                ch = inString[i];
                // remove any characters outside the valid UTF-8 range as well as all control characters
                // except tabs and new lines
                if ((ch < 0x00FD && ch > 0x001F) || ch == '\t' || ch == '\n' || ch == '\r')
                {
                    newString.Append(ch);
                }
            }
            return newString.ToString();

        }


    }

    public class node
    {
        string node_;
        public node(string node)
        {
            node_ = node;
        }
        public override string ToString()
        {
            return " <xsl:value-of select=\"" + node_ + "\"/>";
        }
    }

    public class borderDesign
    {
        public border_style borderStyle { get; set; }
        public border_width borderWidth { get; set; }
        public System.Drawing.Color color { get; set; }
        public double width { get; set; }
        public borderDesign(border_width borderwidth, border_style borderstyle, System.Drawing.Color color)
        {
            this.borderWidth = borderwidth;
            this.borderStyle = borderstyle;
            this.color = color;
        }
        public borderDesign(double borderwidth, border_style borderstyle, System.Drawing.Color color)
        {
            this.width = borderwidth;
            this.borderStyle = borderstyle;
            this.color = color;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (width != 0)
            {
                sb.Append(width.ToString() + "pt");
            }
            else
            {
                switch (borderWidth)
                {
                    case border_width.medium:
                        sb.Append("medium");
                        break;
                    case border_width.thick:
                        sb.Append("thick");
                        break;
                    case border_width.thin:
                        sb.Append("thin");
                        break;
                    case border_width.vlaue:
                        break;
                    default:
                        break;
                }
            }
            switch (borderStyle)
            {
                case border_style.none:
                    break;
                case border_style.dashed:
                    sb.Append(" dashed ");
                    break;
                case border_style.dotted:
                    sb.Append(" dotted ");
                    break;
                case border_style.doubl:
                    sb.Append(" double ");
                    break;
                case border_style.groove:
                    sb.Append(" groove ");
                    break;
                case border_style.hidden:
                    sb.Append(" hidden ");
                    break;
                case border_style.inset:
                    sb.Append(" inset ");
                    break;
                case border_style.outset:
                    sb.Append(" outset ");
                    break;
                case border_style.ridge:
                    sb.Append(" ridge ");
                    break;
                case border_style.solid:
                    sb.Append(" solid ");
                    break;
                default:
                    break;
            }

            if (color != null & !color.IsEmpty)
            {
                string CLRVAL = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
                sb.Append(CLRVAL);
            }

            return sb.ToString();
        }

    }
    public class border
    {
        public borderDesign all { get; set; }
        public borderDesign left { get; set; }
        public borderDesign right { get; set; }
        public borderDesign top { get; set; }
        public borderDesign bottom { get; set; }

        string borderValue_ = "";
        string borderValue
        {
            get { return borderValue_; }
            set { borderValue_ = value; }
        }
        /// <summary>
        /// Gives a default border with medium . solid , black
        /// All individuals can how ever be changed.
        /// </summary>
        public border()
        {
            all = new borderDesign ( border_width .thin  ,border_style .solid ,System .Drawing .Color .Black );
        }
        /// <summary>
        /// For all sides
        /// </summary>
        /// <param name="allSides"></param>
        public border(borderDesign allSides)
        {
            all = allSides;
        }

        /// <summary>
        /// For allsides
        /// </summary>
        /// <param name="borderwidth"></param>
        /// <param name="borderstyle"></param>
        /// <param name="color"></param>
        public border(border_width borderwidth, border_style borderstyle, System.Drawing.Color color)
        {
            all.borderWidth = borderwidth;
            all.borderStyle = borderstyle;
            all.color = color;
        }
        /// <summary>
        /// Directly give value
        /// </summary>
        /// <param name="value">eg "0.1pt solid black"</param>
        public border(string value)
        {
            borderValue = value;
        }
        //border-bottom="0.5pt solid black

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (borderValue.Trim ()!="")
            {
            sb.Append(" border = " + utililty.getQuoted(borderValue) );
            }
            if (all != null)
            {
                sb.Append(" border = " + utililty.getQuoted(all.ToString()));
            }

            if (top != null)
            {
                sb.Append(" border-top = " + utililty.getQuoted(top.ToString()));
            }
            if (bottom != null)
            {
                sb.Append(" border-bottom = " + utililty.getQuoted(bottom.ToString()));
            }
            if (left != null)
            {
                sb.Append(" border-left = " + utililty.getQuoted(left.ToString()));
            }
            if (right != null)
            {
                sb.Append(" border-right = " + utililty.getQuoted(right.ToString()));
            }


            return sb.ToString();
        }
    }

    public class inline
    {
        protected string item = "inline";
        public string content { get; set; }
        public padding padding { get; set; }
        public margin margin { get; set; }
        public font font { get; set; }
        public keep_together keepTogether { get; set; }
        public inline()
        { }
        public inline(string content_)
        {
            content = content_;
            margin = new margin();
            padding = new padding();
            font = new font();
        }
        public inline(node content_)
        {
            content = content_.ToString();
            margin = new margin();
            padding = new padding();
            font = new font();
        }


        /// <summary>
        /// Used to seperate horizontally 
        /// Not cuulative
        /// Can be in percentage
        /// </summary>
        public double start_indent { get; set; }
        public double end_indent { get; set; }
        /// <summary>
        /// Used to seperate vertically
        /// Not cuulative
        /// </summary>
        public double space_before { get; set; }
        public double space_after { get; set; }
        public string border { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            sb.Append("<fo:");
            sb.Append(item);
            if (margin != null)
                sb.Append(margin.ToString());
            if (padding != null)
                sb.Append(padding.ToString());
            if (font != null)
                sb.Append(font.ToString());
            if (keepTogether == keep_together.always)
            {
                sb.Append(" keep-together = " + utililty.getQuoted("always"));
            }
            if (border != "" & border != string.Empty & border != null)
            {
                sb.Append(" border= " + utililty.getQuoted(border));
            }
            sb.Append(">");
            sb.Append(content);
            sb.Append("\n</fo:" + item + ">");
            return sb.ToString();
        }

        public void add(string stringcontent)
        {
            content = content + "\n" + stringcontent;
        }


    }
    public class block : inline
    {
        public block(string content_)
            : base(content_)
        {
            item = "block";
        }
        public void add(block Content)
        {
            content = content + "\n" + Content.ToString();
        }
        public void add(inline Content)
        {
            content = content + "\n" + Content.ToString();
        }
        public void add(block_container Content)
        {
            content = content + "\n" + Content.ToString();
        }
        public void add(table Content)
        {
            content = content + "\n" + Content.ToString();
        }
    }

    public class block_container : block
    {
        public double height { get; set; }
        public double width { get; set; }
        public double top { get; set; }
        public double left { get; set; }
        public string unit { get; set; }
        public block_container(string content_)
            : base(content_)
        {
            item = "block-container";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            sb.Append("<fo:");
            sb.Append(item);
            if (margin != null)
                sb.Append(margin.ToString());
            if (padding != null)
                sb.Append(padding.ToString());
            if (padding != null)
                sb.Append(font.ToString());
            if (keepTogether == keep_together.always)
            {
                sb.Append(" keep-together = " + utililty.getQuoted("always"));
            }
            if (border != "" & border != string.Empty & border != null)
            {
                sb.Append(" border= " + utililty.getQuoted(border));
            }
            if (unit == null | unit.ToString().ToLower() == "")
            {
                unit = "in";
            }
            if (height != 0)
            {
                sb.Append(" height = " + height.ToString() + unit);
            }
            if (width != 0)
            {
                sb.Append(" height = " + width.ToString() + unit);
            }
            if (top != 0)
            {
                sb.Append(" height = " + top.ToString() + unit);
            }
            if (left != 0)
            {
                sb.Append(" height = " + left.ToString() + unit);
            }
            sb.Append(">");
            sb.Append(content);
            sb.Append("\n</fo:" + item + ">");
            return sb.ToString();
        }

    }

   
    public class image : block
    {
        public double height { get; set; }
        public double width { get; set; }
        public double top { get; set; }
        public double left { get; set; }
        public string unit { get; set; }
        public image(string content_)
            : base(content_)
        {
            item = "block-container";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            
            
            
             //<fo:external-graphic content-height="scale-to-fit" height="0.3in" content-width="1.2in" scaling="non-uniform">
             //           <xsl:attribute name ="src">
             //             <xsl:value-of select ="/errorlist/logo"/>
             //           </xsl:attribute>
             //         </fo:external-graphic>

            
            
            sb.Append("");
            sb.Append("<fo:");
            sb.Append(item);
            if (margin != null)
                sb.Append(margin.ToString());
            if (padding != null)
                sb.Append(padding.ToString());
            if (padding != null)
                sb.Append(font.ToString());
            if (keepTogether == keep_together.always)
            {
                sb.Append(" keep-together = " + utililty.getQuoted("always"));
            }
            if (border != "" & border != string.Empty & border != null)
            {
                sb.Append(" border= " + utililty.getQuoted(border));
            }
            if (unit == null | unit.ToString().ToLower() == "")
            {
                unit = "in";
            }
            if (height != 0)
            {
                sb.Append(" height = " + height.ToString() + unit);
            }
            if (width != 0)
            {
                sb.Append(" height = " + width.ToString() + unit);
            }
            if (top != 0)
            {
                sb.Append(" height = " + top.ToString() + unit);
            }
            if (left != 0)
            {
                sb.Append(" height = " + left.ToString() + unit);
            }
            sb.Append(">");
            sb.Append(content);
            sb.Append("\n</fo:" + item + ">");
            return sb.ToString();
        }

    }


    

}