using System.Collections.Generic;
namespace Agencia.Models
{
    public class DestinosService
    {
       public List<Destinos> GetDestinos() 
       {
            var listaDestinos = new List<Destinos>();
            var destino01 = new Destinos(1, "São Paulo", "10000");
            var destino02 = new Destinos(2, "Rio", "5000");
            return listaDestinos;
       }
    }
}
