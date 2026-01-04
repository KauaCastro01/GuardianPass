namespace GuardianPass.Model
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool ExigirSenha { get; set; } = true;
    }
}
