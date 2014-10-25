using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MiddleTier.BC
{
    public partial class BusinessConnector
    {
      
        public static bool Serialize<T>(T value, ref string serializeXml, bool _OmitXmlDeclaration = false)
        {
            if (value == null)
            {
                return false;
            }
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(T));
                StringWriter stringWriter = new StringWriter();
                XmlWriterSettings setup = new XmlWriterSettings();
                setup.Indent = true;
                setup.OmitXmlDeclaration = _OmitXmlDeclaration;

                XmlWriter writer = XmlWriter.Create(stringWriter, setup);

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                xmlserializer.Serialize(writer, value, ns);

                serializeXml = stringWriter.ToString();

                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception source: {0}", e.Source);
                return false;
            }
        }

        public BusinessConnector()
        {
        }

        public string shipMove(int _userId, int _shipId, byte _direction, int _duration = 1)
        {
            return (new Ship(_userId, _shipId).moveShip(_direction, _duration));
        }


        public string shipSelfDestruct(int _userId, int _shipId)
        {
            return (new Ship(_userId, _shipId).selfDestruct());
        }

        public string transfer(int _userID, string _transferXml)
        {
            return (new Transfer(_userID, _transferXml)).transferStuff();
        }

        public string colonize(int _shipId, int _userId, string _newname)
        {
            //call specialized business connector class...
            //return (new Colonize(_shipId, _userId, _newname)).colonize();
            return "done...";
        }

    }

    public class ScanResult
    {
        public struct ScanData
        {
            [XmlElement(ElementName = "ship")]
            public List<MiddleTier.Core.Data.Ship> ship;

            [XmlElement(ElementName = "colony")]
            public List<MiddleTier.Core.Data.Colony> colony;
        }

        public ScanResult()
        {
        }

        public byte result;
        public ScanData scanData;    
        
    }
}
