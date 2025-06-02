namespace CadastroEvento.Models
{
    public class Evento
    {
        public  string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataTermino { get; set; } = DateTime.Today.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }

        public double CustoPorParticipante { get; set; }

        public int Duracao => (DataTermino - DataInicio).Days;

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
