using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.Core
{
    internal class ShipSelfDestruct
    {
        int shipId;
        public ShipSelfDestruct(int _shipId)
        {
            shipId = _shipId;
        }

        public Boolean selfDestruct()
        {

            //fetch data from sql, out the data in classes corresponding to the tables : MiddleTier.Core.Data


            // make calculations


            //write data using transaction and a timestamp field which is validated during update (thread safe data handling)


            return true;
        }
    }
}
