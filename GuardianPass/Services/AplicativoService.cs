using GuardianPass.Data;
using GuardianPass.Model;

namespace GuardianPass.Services
{
    public class AplicativoService
    {
        private readonly AppDbContext _db;
        private readonly LogErroService _logErroService;
        public AplicativoService(AppDbContext db)
        {
            _db = db;
        }
        
        private void MensagemErro(string Erro)
        {
            MessageBox.Show(Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool InserirAplicativo(AplicativosModel aplicativosModel)
        {
            try
            {
                if (aplicativosModel == null)
                    return false;

                _db.Aplicativo.Add(aplicativosModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            { 
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Inserir Aplicativo", ex.Message, ex.ToString());
                return false; 
            }
        }

        public bool AtualizarAplicativo(AplicativosModel aplicativosModel)
        {
            try
            {
                if (aplicativosModel == null)
                    return false;

                var app = _db.Aplicativo.FirstOrDefault(x => x.Id == aplicativosModel.Id);

                if (app == null)
                    return false;

                app.Usuario = aplicativosModel.Usuario;                
                app.Senha = aplicativosModel.Senha;
                app.Aplicativo = aplicativosModel.Aplicativo;

                _db.Aplicativo.Update(app);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Atualizar Aplicativo", ex.Message, ex.ToString());
                return false;
            }
        }

        public bool ExcluirAplicativo(AplicativosModel aplicativosModel)
        {
            try
            {
                if (aplicativosModel == null)
                    return false;

                _db.Aplicativo.Remove(aplicativosModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Excluir Aplicativo", ex.Message, ex.ToString());
                return false;
            }
        }

        public List<AplicativosModel> ObterTodosAplicativos()
        {
            try
            {
                var id = Properties.Settings.Default.ID;
                return _db.Aplicativo.Where(x => x.UsuarioId == id).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Listar Todos Aplicativo", ex.Message, ex.ToString());
                return null;
            }
        }

        public List<AplicativosModel> Pesquisar(string termo, int usuarioId)
        {
            try
            {
                return _db.Aplicativo.Where(x => x.Aplicativo.Contains(termo) && x.UsuarioId == usuarioId).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.ToString());
                _logErroService.Registrar("", "Pesquisar Por Aplicativo", ex.Message, ex.ToString());
                return null;
            }
        }
    }
}