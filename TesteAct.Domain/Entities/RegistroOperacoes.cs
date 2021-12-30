using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAct.Domain
{
    public class RegistroOperacoes
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CodigoAcao { get; set; }
        public string TipoOperacao { get; set; }
        public DateTime DataOperacao { get; set; } = DateTime.Now;
        public decimal Quantidade { get; set; }
        public decimal ValorAcao { get; set; }
        public decimal ValorTotal { get; set; }
        public virtual Acoes Acoes { get; set; }
    }
}
