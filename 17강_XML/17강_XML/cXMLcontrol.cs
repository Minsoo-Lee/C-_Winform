using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _17강_XML
{
    class cXMLcontrol
    {
        public static string TextData = "TEXT_DATA";
        public static string cboxData = "CBOX_DATA";
        public static string nData = "NUMBER_DATA";

        public Dictionary<string, string> fXML_Reader(string strXMLpath)
        {
            Dictionary<string, string> dXMLconfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLpath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd[ "ID"];
                            rd.Read();

                            string strTEXT = rd.ReadElementContentAsString(TextData, "");
                            dXMLconfig.Add(TextData, strTEXT);
                            string strCbox = rd.ReadElementContentAsString(cboxData, "");
                            dXMLconfig.Add(cboxData, strCbox);
                            string strNum = rd.ReadElementContentAsString(nData, "");
                            dXMLconfig.Add(nData, strNum);
                        }
                    }
                }

            }
            return dXMLconfig;
        }

        public void fXML_Writer(string strXMLpath, Dictionary <string, string> dXMLconfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLpath))
            {
                wr.WriteStartDocument();
                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(TextData, dXMLconfig[TextData]);
                wr.WriteElementString(cboxData, dXMLconfig[cboxData]);
                wr.WriteElementString(nData, dXMLconfig[nData]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }
    }
}
