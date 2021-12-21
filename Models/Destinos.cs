namespace Agencia.Models
{
    public class Destinos
    {

        public int Id { get; set; }

        public string Figcaption { get; set; }

        public string Valor { get; set; }

        public Destinos(int Id, string Figcaption, string valor)
        {
            this.Id = Id;
            this.Figcaption = Figcaption;
            this.Valor = Valor;
        }


    }
}
