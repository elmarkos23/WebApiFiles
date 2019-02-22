using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFiles.Controllers
{
    public class cancionController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(Models.cancion objcancion)
        {
            if (objcancion != null)
            {
                //archivo de musica que quieres enviar a la web api
                var bytes = File.ReadAllBytes("d://yanki.mp3");

                Models.cancion obj = new Models.cancion() {id=1,archivo=bytes,nombre="super cancion" };

                //ya en el objeto lo puedes grabar en el servidor, este ejemplo lo hice en el mismo computador o lo podrias ahcer desde el movil o algo asi
                File.WriteAllBytes("c://"+obj.nombre+".mp3", obj.archivo);


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, objcancion);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
