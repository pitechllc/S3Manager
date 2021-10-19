using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PiBox
{
	public class Setconfig
	{
        /// <summary>
        ///     ''' UpdateAppSettings: It will update the app.Config file AppConfig key values
        ///     ''' </summary>
        ///     ''' <param name="KeyName">AppConfigs KeyName</param>
        ///     ''' <param name="KeyValue">AppConfigs KeyValue</param>
        ///     ''' <remarks></remarks>
        public static void UpdateAppSettings(string KeyName, string KeyValue)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "appSettings")
                {
                    foreach (XmlNode xNode in xElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value == KeyName)
                            xNode.Attributes[1].Value = KeyValue;
                    }
                }
            }
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
