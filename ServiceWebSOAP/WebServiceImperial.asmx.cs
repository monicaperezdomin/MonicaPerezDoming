using Applicatio;

using System.Web.Services;


namespace ServiceWebSOAP
{
    /// <summary>
    /// Descripción breve de WebServiceImperial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceImperial : WebService
    {
        private IOperatorRebeld TestExist = new OperatorRebeld();
     

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]

        public string TestConnection()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public string Find(string total)
        {
            string[] dateSplit = total.Split(' ');

            var name = dateSplit[0];
            var planet= dateSplit[1];
            var result = TestExist.FindRebelds(name, planet);
            bool saveRebeld = TestExist.WriteFileRebel(name,planet);
            
            if (result)
            {
                return "Encontrado";
            }
            else
            {
                return "false";
            }
           
        }
    }
}
