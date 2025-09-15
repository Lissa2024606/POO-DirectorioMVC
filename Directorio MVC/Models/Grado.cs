namespace Directorio_MVC.Models
{
    public class Grado
    {

        private int NumeroGrado { get; set; }
        private string NivelEducativo { get; set; }
        private string Institucion { get; set; }
        private string NombreTitulo { get; set; }
        private DateTime FechaInicio { get; set; }
        private DateTime FechaFinal { get; set; }
        private string TipoGrado { get; set; }
        private DateTime FechaExpiracion { get; set; }
        private string Pais { get; set; }

        public Grado()
        {
        }


        public Grado(int numeroGrado, string nivelEducativo, string institucion, string nombreTitulo, DateTime fechaInicio, DateTime fechaFinal, string tipoGrado, DateTime fechaExpiracion, string pais)
        {
            this.NumeroGrado = numeroGrado;
            this.NivelEducativo = nivelEducativo;
            this.Institucion = institucion;
            this.NombreTitulo = nombreTitulo;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.TipoGrado = tipoGrado;
            this.FechaExpiracion = fechaExpiracion;
            this.Pais = pais;

        }


        public void Imprimir()
        {
            Console.WriteLine("Titulo: " + this.NombreTitulo);
            Console.WriteLine("Institucion: " + this.Institucion);
            Console.WriteLine($"  Periodo: {this.FechaInicio.ToString("dd/MM/yyyy")} - {this.FechaFinal.ToString("dd/MM/yyyy")}");
        }




    }
}
