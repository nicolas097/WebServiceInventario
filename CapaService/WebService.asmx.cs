using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaClases;
using CapaNegocio;


namespace CapaService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]

        public bool insertarService(SalidaProducto sa)
        {
            NegocioSalidaProducto auxServicio = new NegocioSalidaProducto();
            return auxServicio.Insertar(sa);

        }

        [WebMethod]

        public int traerStock(string sku)
        {
            NegocioSalidaProducto auxServicio = new NegocioSalidaProducto();
            return auxServicio.traerStock(sku);
        }

        [WebMethod]

        public int serviceActualizaC(string sku, int cantidad)
        {
            NegocioSalidaProducto auxServicio = new NegocioSalidaProducto();
            return auxServicio.actualizarStock(sku, cantidad);
        }
    }
}
