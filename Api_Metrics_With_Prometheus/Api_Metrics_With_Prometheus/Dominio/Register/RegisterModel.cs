namespace Api_Metrics_With_Prometheus.Dominio.Register
{
    public class RegisterModel
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
    }
}
