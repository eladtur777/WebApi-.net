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
    public class VersionUpdateController : ApiController
    {
        /// <summary>
        /// first, create some client list to store
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetClientsLatestVersion()
        {
            if (MyData.ClientsLatestV.Count > 0)
            {

                var json = new JavaScriptSerializer().Serialize(MyData.ClientsLatestV);
                return json;
            }
            else
            {
          

                MyData.ClientsLatestV.Add(new ClientsLatestVersion
                {
                    id = 1,
                    TZ = "123456789",
                    AccountNumber = "125954",
                    IsShowBtnLatest = true,
                    IsLatest = false
                });

                var json = new JavaScriptSerializer().Serialize(MyData.ClientsLatestV);
                return json;
            }
        }


        /// <summary>
        /// לאחר שהלקוח לוחץ על כפתור קבלת עדכון, נדרש לעדכן בבסיס נתונים  שהוא רוצה את הגרסה החדשה
        /// </summary>
        /// <param name="ClientsLatestVer"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult SetCLientVersion([FromBody]ClientsLatestVersion ClientsLatestVer)
        {
            if (ClientsLatestVer != null)
            {
                foreach (var p in MyData.ClientsLatestV)
                {
                    if (p.id == ClientsLatestVer.id)
                    {
                        p.IsShowBtnLatest = ClientsLatestVer.IsShowBtnLatest;
                        p.IsLatest = ClientsLatestVer.IsLatest;
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
