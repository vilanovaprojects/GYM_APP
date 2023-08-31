using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Domain.Clases
{
    public class XML
    {
        static private string appPwdUnique = "UYtiv76VRrvo/&X64ex%$e23&7Nn89N?9hH9h";

        public void SavetoXML(string dbcnString)
        {
            AES aes = new AES();

            XmlDocument doc = new XmlDocument();
            //doc.Load(Properties.Resources.connection);
            doc.Load("XMLconnection/connection.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = aes.Encrypt(dbcnString, appPwdUnique, int.Parse("256"));
            //XmlTextWriter writer = new XmlTextWriter(Properties.Resources.connection, null);
            XmlTextWriter writer = new XmlTextWriter("XMLconnection/connection.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        public string ReadfromXML()
        {
            string dbcnString;

            try
            {
                AES aes = new AES();

                XmlDocument doc = new XmlDocument();
                //doc.Load(Properties.Resources.connection);
                doc.Load("XMLconnection/connection.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;

                return aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256"));
            }
            catch
            {
                return null;
            }
        }
    }
}
