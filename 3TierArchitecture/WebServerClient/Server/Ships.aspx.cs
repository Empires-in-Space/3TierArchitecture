using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerClient.Server
{
    public partial class Ships : System.Web.UI.Page
    {
        string userId;
        string resp;

        protected void Page_Load(object sender, EventArgs e)
        {
            string shipId = Request.QueryString["shipId"];
                        
            if (Request.Params["action"] == null)
                return;
            string action = Request.Params["action"];

            //check if a user object was saved in the session - array (this would have been done during login)
            /*
            if (Session["user"] == null)
            {
                string redirectPath = System.Web.Configuration.WebConfigurationManager.AppSettings["index"].ToString();
                Response.Redirect(redirectPath);
                return;
            }
            currentUser = (Users)Session["user"];
            userId = currentUser.id.ToString();
            */

            resp = "<?xml version='1.0' encoding='utf-8' ?>";
         
            switch (action)
            {
                case "move":
                    moveShip(shipId);
                    return;
                case "colonize":
                    //shipColonize(shipId);
                    return;
                case "selfDestruct":
                    //selfDestruct();
                    return;
                default:
                    return;
            }
        }

        protected void moveShip(string shipId)
        {
            string direction = Request.QueryString["direction"];

            
            MiddleTier.BC.BusinessConnector bc = (MiddleTier.BC.BusinessConnector)Application["bs"];

            int shipInt = 0;
            Int32.TryParse(shipId, out shipInt);
            byte directionInt = 0;
            byte.TryParse(direction, out directionInt);

            //you should get the userid from the saved session cookie
            int userid = 1;

            resp = bc.shipMove(userid, shipInt, directionInt, 1);
               
            //return the result (Response)
            Response.Clear();
            Response.Expires = -1;
            Response.ContentType = "text/xml";
            Response.Write(resp);
        } // end of move()

    }
}