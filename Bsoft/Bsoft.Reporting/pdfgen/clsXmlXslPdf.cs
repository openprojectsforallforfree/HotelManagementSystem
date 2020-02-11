using System;
using System.Collections.Generic;
 
using System.Text;

using System.IO;
using ibex4;
namespace Bsoft.Reporting.ibex
{
   public  class ibexpPDF
    {
      public  string error = "";
      public ibexpPDF(string xml, string xsl, string pdf)
        {
            error = "";
            string key = "0002012080634DB268788BD5A63862C1BRNIKQOAUO0A0PALEJXUYW==";
            ibex4.licensing.Generator.setRuntimeKey(key);
            FileStream xml_stream = null;
            FileStream xsl_stream = null;
            FileStream pdf_stream = null;
         
            try
            {
                /*
                 * call Ibex with three parameters, the xml and xsl files and the PDF file
                 * to be created
                 */

                xml_stream = new FileStream(xml, FileMode.Open);
                xsl_stream = new FileStream(xsl, FileMode.Open);
                pdf_stream = new FileStream(pdf, FileMode.Create);
                FODocument doc = new FODocument();
              
                /*
                 * when creating a PDF to a file, we want to close that file, if
                 * we were creating to a MemoryStream we would want to leave it open
                 */

                bool close_pdf_stream = true;

                doc.generate(xml_stream, xsl_stream, pdf_stream, close_pdf_stream);

                // Console.Write("Generated PDF with " + System.Convert.ToString(doc.getPageCount()) + " page(s)");
            }
            catch (Exception ex)
            {
                String error_message = ex.Message;
                //Shows details 
                Exception ptr = ex.InnerException;

                while (ptr != null)
                {
                    error_message += ptr.Message;
                    ptr = ptr.InnerException;
                }
                error = error_message;
                Console.Write(error_message);
            }

            if (xml_stream != null)
            {
                xml_stream.Close();
            }
            if (pdf_stream != null)
            {
                pdf_stream.Close();
            }
            if (xsl_stream != null)
            {
                xsl_stream.Close();
            }

        }


    }
}
