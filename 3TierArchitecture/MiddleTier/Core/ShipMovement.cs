using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.Core
{
    internal class ShipMovement
    {
        int shipId;
        public ShipMovement(int _shipId)
        {
            shipId = _shipId;
        }

        
        public Boolean move( byte _direction, int _userId, int _duration)
        {

            //fetch data from sql, out the data in classes corresponding to the tables : MiddleTier.Core.Data
            Data.Ship ship = MiddleTier.DataConnectors.SqlConnector.getShip(shipId);

            // make calculations


            //write data using transaction and a timestamp field which is validated during update (thread safe data handling)
            //MiddleTier.DataConnectors.SqlConnector.setShip(ship);
                      
            return true;
        }
    }
}
