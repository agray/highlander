﻿using System;
using System.IO;
using System.Xml;

namespace pheonix.util {
    class PrettyPrintFormatter {
        [STAThread]
        public static string format(string s) {
            StringWriter stringWriter = new StringWriter();
            
            XmlDocument doc = new XmlDocument();
            
            //get your document
            doc.LoadXml(s);
            
            //create reader and writer
            XmlNodeReader xmlReader = new XmlNodeReader(doc);
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            
            //set formatting options
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 2;
            xmlWriter.IndentChar = ' ';
            
            //write the document formatted
            xmlWriter.WriteNode(xmlReader, true);

            return stringWriter.ToString();
        }
    }
}