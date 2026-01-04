using GuardianPass.Data;
using GuardianPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass.Services
{
    public class LogErroService
    {
        private readonly AppDbContext _db;

        public LogErroService(AppDbContext db)
        {
            _db = db;
        }

        public void Registrar(string? usuario, string funcionalidade, string mensagem, string detalhes)
        {
            var log = new LogErroModel()
            {
                Usuario = usuario,
                Funcionalidade = funcionalidade,
                Mensagem = mensagem,
                DetalhesTecnicos = detalhes
            };

            _db.LogErro.Add(log);
            _db.SaveChanges();
        }
    }
}
