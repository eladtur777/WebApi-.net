using CalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace CalTest.Controllers
{
    public class CardHoldersController : ApiController
    {

        [HttpGet]
        public string GetClients()
        {
			if (MyData.CardHolder.Count > 0)
			{
				var json = new JavaScriptSerializer().Serialize(MyData.CardHolder);
				return json;
			}
			else
			{
				IList<CardHolder> clients = new List<CardHolder>
			{
				new CardHolder
				{
				   id = 1,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
				   id = 2,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
					id = 3,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
				   id = 4,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				}

			};

				var json = new JavaScriptSerializer().Serialize(clients);
				return json;
			}
        }

    }
}