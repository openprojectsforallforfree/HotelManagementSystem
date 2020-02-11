using System;
using System.Collections.Generic;
 
using System.Text;
using System.Xml;
namespace Bsoft.XML
{
    public   class XMLhelper
    {
       
      public   XmlTextWriter xmlWriter;

      public XMLhelper(string filename)
        {
            xmlWriter = new XmlTextWriter(filename, null);
            // Opens the document
            xmlWriter.WriteStartDocument();
            // Write comments
         
        }
        public void close()
        {
            xmlWriter.WriteEndDocument();
            // close writer
            xmlWriter.Close();
        }
        public void writeComment(string comment)
        {
            xmlWriter.WriteComment(comment );
        }
        public void Node(string node, string value)
        {
            xmlWriter.WriteStartElement(node); xmlWriter.WriteString(value); xmlWriter.WriteEndElement();
        }
        public void startNode(string node)
        {
            xmlWriter.WriteStartElement(node);
        }
        public void endNode()
        {
            xmlWriter.WriteEndElement();
        }
    }
}










////Different ways of creating xml file in .net 
////xlinq way
//           XElement contacts =
//   new XElement("contacts",
//       new XElement("contact",
//           new XElement("name", "Patrick Hines"),
//           new XElement("phone", "206-555-0144",
//               new XAttribute("type", "home")),
//           new XElement("phone", "425-555-0145",
//               new XAttribute("type", "work")),
//           new XElement("address",
//               new XElement("street1", "123 Main St"),
//               new XElement("city", "Mercer Island"),
//               new XElement("state", "WA"),
//               new XElement("postal", "68042")
//           )
//       )
//   );

////xmldocumuent way
//           XmlDocument doc = new XmlDocument();
//           XmlElement theory = doc.CreateElement("th");
//           theory.InnerText = "3";
//           XmlElement practical = doc.CreateElement("pr");
//           practical.InnerText = "4";
//           XmlElement physics = doc.CreateElement("Physiscs");
//           physics.AppendChild(theory);
//           physics.AppendChild(practical);
//           XmlElement chemistry = doc.CreateElement("chemistry");
//           chemistry.AppendChild(theory);
//           chemistry.AppendChild(practical);
//           XmlElement marks = doc.CreateElement("contact");
//           marks.AppendChild(physics);
//           marks.AppendChild(chemistry);
//           doc.AppendChild(marks);
//           doc.Save(@"C:\Users\dhirajb\Desktop\ExcelDesk\abc.xml");




//public void getXML(string filename)
//      {
//          XmlTextWriter xmlWriter = new XmlTextWriter(filename, null);
//          // Opens the document
//          xmlWriter.WriteStartDocument();
//          // Write comments
//          xmlWriter.WriteComment("Mark sheet example   ");
//          // Write first element
//          xmlWriter.WriteStartElement("Student");
//          xmlWriter.WriteStartElement("Marks");
//          // Write next element
//          xmlWriter.WriteStartElement("Physics");
//          xmlWriter.WriteStartElement("Th");
//          xmlWriter.WriteString("3");
//          xmlWriter.WriteEndElement();
//          xmlWriter.WriteStartElement("pr");
//          xmlWriter.WriteString("4");
//          xmlWriter.WriteEndElement();
//          xmlWriter.WriteEndElement();
//          // Write next element
//          xmlWriter.WriteStartElement("Chemistry");
//          xmlWriter.WriteStartElement("Th");
//          xmlWriter.WriteString("3");
//          xmlWriter.WriteEndElement();
//          xmlWriter.WriteStartElement("pr");
//          xmlWriter.WriteString("4");
//          xmlWriter.WriteEndElement();
//          xmlWriter.WriteEndElement();
//          // Write one more element
//          xmlWriter.WriteEndElement();
//          xmlWriter.WriteEndElement();
//          // Ends the document.
//          xmlWriter.WriteEndDocument();
//          // close writer
//          xmlWriter.Close();

//      }