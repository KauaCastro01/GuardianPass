namespace GuardianPass.Model
{
    public class AplicativosModel
    {
        public int Id{ get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Aplicativo { get; set; }
    }
}