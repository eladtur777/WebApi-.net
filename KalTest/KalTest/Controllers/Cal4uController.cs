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
    public class Cal4uController : ApiController
    {

		[HttpGet]
		public string GetClients()
		{
			if (MyData.Cal4U.Count > 0)
			{
				var json = new JavaScriptSerializer().Serialize(MyData.Cal4U);
				return json;
			}
			else
			{
				IList<Cal4U> clients = new List<Cal4U>
			{
				new Cal4U
				{
				   id = 1,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new Cal4U
				{
				   id = 2,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new Cal4U
				{
					id = 3,
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