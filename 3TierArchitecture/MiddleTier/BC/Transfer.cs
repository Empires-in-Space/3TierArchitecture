using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.BC
{
    internal class Transfer
    {
       
        int userID;
        string transferXml;

        MiddleTier.Core.Data.Ship sender;
        MiddleTier.Core.Data.Ship receiver;

        public Transfer(int _userID, string _transferXml)
        {
            userID = _userID;
            transferXml = _transferXml;

            //get sender/ receiver from transferXml

        }

        public string transferStuff()
        {
            // Pre calculation tasks
            // check parameters if needed 
            // e.g. if the values are in the range of possible values. Data integrity has to be checked during calculation

            //Call the class which does the calculations
            //MiddleTier.Core.Transfer transfer = new MiddleTier.Core.Transfer();
            //transfer.doSomething();

            //format the output data, this example creates xml, replace it with whatever you want)
            ScanResult scan = new ScanResult();
            scan.result = 42;
            string ret = "";
            BusinessConnector.Serialize<ScanResult>(scan, ref ret);

            return ret;
        }
    }
}
