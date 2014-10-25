using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.Core.Data
{
    //has to be filled yet (see Ship.cs for a short example)
    public class Colony
    {
        private int id;
        private int _userid;
        private string _NAME;
        private int _notSerialized;

        public Colony(int _id)
        {
            id = _id;
        }

        public Colony()
        {            
        }

    }
}
