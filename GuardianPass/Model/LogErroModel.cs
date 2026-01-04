using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass.Model
{
    public class LogErroModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string? Usuario { get; set; }
        public string Funcionalidade { get; set; } = "";
        public string Mensagem { get; set; } = "";
        public string DetalhesTecnicos { get; set; } = "";
    }
}
