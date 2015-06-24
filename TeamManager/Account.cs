using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TeamManager
{
    [Serializable]
    public class Account
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Pass { get; set; }
        public List<Realm> Realms { get; set; }
    }

    [Serializable]
    public class Realm
    {
        [XmlAttribute]
        public string Name { get; set; }
        public List<Toon> Toons { get; set; }
    }
}
