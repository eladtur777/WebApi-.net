using CalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace KalTest.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class ValuesController : ApiController
    {

        [HttpGet]
        public string GetStatus()
        {
			
			if (MyData.State.Count > 0)
			{
				var json = new JavaScriptSerializer().Serialize(MyData.State);
				return json;
			}
			else
			{

				//IsSorryOn ==> set the tables styles, true = on, false = off
		    IList<State> states = new List<State>
			{
				new State
				{
					IsSorryOn  = true,
					SystemCode = 1//CardHolders
               },
				new State
				{
					IsSorryOn  = true,
					SystemCode = 2//Cal4U
                }
			};
				MyData.State = states;
				var json = new JavaScriptSerializer().Serialize(states);
				return json;
			}
        }


        [HttpPost]
        public IHttpActionResult SetState([FromBody]State state)
        {
            if (state != null)
            {
                foreach (var p in MyData.State)
                {
                    if (p.SystemCode == state.SystemCode)
                    {
                        p.IsSorryOn = state.IsSorryOn;
                    }
                }
                return Ok("ok");
            }
            else
            {
                return BadRequest("object is null");
            }

        }
      
    }
}
