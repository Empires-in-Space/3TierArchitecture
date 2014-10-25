using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.BC
{
    class Ship
    {
        int shipId;       
        int userId;

        public Ship(int _userId, int _shipId )
        {
            userId = _userId;
            shipId = _shipId;                                 
        }

        public string moveShip(byte _direction, int _duration = 1)
        {
            // Pre calculation tasks
            // check parameters if needed 
            // e.g. if the values are in the range of possible values. Data integrity has to be checked during calculation

            //Call the class which does the calculations
            MiddleTier.Core.ShipMovement move = new MiddleTier.Core.ShipMovement(shipId);
            move.move(_direction, userId, _duration);

            //format the output data, this example creates xml, replace it with whatever you want)
            ScanResult scan = new ScanResult();
            scan.scanData.ship = new List<Core.Data.Ship>();
            scan.scanData.ship.Add(new Core.Data.Ship(1));
            scan.result = 42;            
            string ret = "";            
            BusinessConnector.Serialize<ScanResult>(scan, ref ret);
           
            return ret;
        }

        public string selfDestruct()
        {
            // Pre calculation tasks
            // check parameters if needed 
            // e.g. if the values are in the range of possible values. Data integrity has to be checked during calculation

            //Call the class which does the calculations
            MiddleTier.Core.ShipSelfDestruct sd = new MiddleTier.Core.ShipSelfDestruct(shipId);
            sd.selfDestruct();

            //format the output data, this example creates xml, replace it with whatever you want)
            ScanResult scan = new ScanResult();
            scan.result = 42;
            string ret = "";
            BusinessConnector.Serialize<ScanResult>(scan, ref ret);

            return ret;
        }

    }
}
