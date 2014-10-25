using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiddleTier.Core.Data
{
    public  class Ship
    {
        private int _id;
        private int _userid;
        private string _NAME;
        private int _notSerialized;            

        public Ship(int _id)
        {
            id = _id;
        }

        // the  constructor without parameters is only needed for the xmlSerialization
        public Ship()
        {            
        }


        [XmlElement(ElementName = "shipId")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this._id = value;
                }
            }
        }

       
        public int userid
        {
            get
            {
                return this._userid;
            }
            set
            {
                if ((this._userid != value))
                {
                    this._userid = value;
                }
            }
        }

        [XmlElement(ElementName = "name")]
        public string name
        {
            get
            {
                return this._NAME;
            }
            set
            {
                if ((this._NAME != value))
                {
                    this._NAME = value;
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int notSerialized
        {
            get
            {
                return this._notSerialized;
            }
            set
            {
                if ((this._notSerialized != value))
                {
                    this._notSerialized = value;
                }
            }
        }

    }
}
