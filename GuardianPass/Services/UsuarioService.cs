using GuardianPass.Data;
using GuardianPass.Model;

namespace GuardianPass.Services
{
    public class UsuarioService
    {
        private readonly AppDbContext _db;
        private readonly LogErroService _logErroService;
        public UsuarioService(AppDbContext db)
        {
            _db = db;
        }

        private void MensagemErro(string Erro)
        {
            MessageBox.Show(Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Login(string usuario, string senha)
        {
            try
            {
                return _db.Usuario.Any(x => x.Usuario == usuario && x.Senha == senha);
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Efetuar o login", ex.Message, ex.ToString());
                return false;
            }
        }

        public bool CriarUsuario(UsuariosModel usuariosModel)
        {
            try
            {
                if (usuariosModel == null)
                    return false;

                if (_db.Usuario.Any(x => x.Usuario == usuariosModel.Usuario))
                    return false;

                _db.Usuario.Add(usuariosModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Criar usuário", ex.Message, ex.ToString());
                return false;
            }
        }

        public int ObterIdUsuario(string usuario, string senha)
        {
            try
            {
                int id = _db.Usuario.Where(x => x.Usuario == usuario && x.Senha == senha).Select(x => x.Id).FirstOrDefault();
                return id;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Obter Id do usuário", ex.Message, ex.ToString());
                return 0;
            }
        }

        public bool AtualizarSenha(int id, string senhaNova)
        {
            try
            {
                if (_db.Usuario.Any(x => x.Id == id))
                {
                    var usuario = _db.Usuario.First(x => x.Id == id);
                    usuario.Senha = senhaNova;
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Atualizar senha", ex.Message, ex.ToString());
                return false;
            }
        }

        public UsuariosModel VerificarExigirSenha(int id)
        {
            try
            {
                return _db.Usuario.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Exigir senha", ex.Message, ex.ToString());
                return null;
            }
        }

        public void AtualizarExigirSenha(int id, bool exigirSenha)
        {
            try
            {
                if (_db.Usuario.Any(x => x.Id == id))
                {
                    var usuario = _db.Usuario.First(x => x.Id == id);
                    usuario.ExigirSenha = exigirSenha;

                    _db.Usuario.Update(usuario);
                    _db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Atualizar Exigir Senha", ex.Message, ex.ToString());
            }
        }
    }
}
