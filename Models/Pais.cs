namespace AgenciaDeToursFinal.Models
{
    public class Pais
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Destino> Destinos { get; set; }
    }
}
