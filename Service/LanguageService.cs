using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;
using System.Xml;
using System.Reflection;
using System.IO;

namespace MVVM.Service
{
    public class LanguageService : ILanguageService
    {
        public List<Language> LeggiListaLinguaggi()
        {
            XmlDocument doc = new XmlDocument();
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<Language> result = new List<Language>();
            using (Stream stream = assembly.GetManifestResourceStream("MVVM.Resources.lingue.xml"))
            using (StreamReader reader = new StreamReader(stream))
            {
                string xmlString = reader.ReadToEnd();
                doc.LoadXml(xmlString);
                XmlNodeList lingue = doc.GetElementsByTagName("Lingua");
                foreach (XmlNode lingua in lingue)
                {
                    Language l = new Language(lingua.Attributes["Name"].Value, lingua.Attributes["Value"].Value);
                    result.Add(l);
                }

            }
            return result;
        }
    }


}

