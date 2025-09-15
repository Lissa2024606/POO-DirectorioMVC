namespace Directorio_MVC.Models
{
    public class Cargo
    {
        private int NumeroCargo { get; set; }
        private string Titulo { get; set; }
        private DateTime FechaInicio { get; set; }
        private DateTime FechaFinal { get; set; }
        private bool EmpleoActual { get; set; }
        private string Empresa { get; set; }
        private decimal Salario { get; set; }
        private string Detalles { get; set; }

        public Cargo()
        {
        }

        public Cargo(int numeroCargo, string titulo, DateTime fechaInicio, DateTime fechaFinal, bool empleoActual, string empresa, decimal salario, string detalles)
        {
            this.NumeroCargo = numeroCargo;
            this.Titulo = titulo;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.EmpleoActual = empleoActual;
            this.Empresa = empresa;
            this.Salario = salario;
            this.Detalles = detalles;
        }


        public void Imprimir()
        {
            string esActual = this.EmpleoActual ? "si" : "no";
            Console.WriteLine("Cargo: " + this.Titulo);
            Console.WriteLine("Empresa: " + this.Empresa);
            Console.WriteLine($"Salario: L {this.Salario:N2}");
            Console.WriteLine($"¿Actual?: {esActual}");

        }




    }
}
