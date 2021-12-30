using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteAct.Domain
{
    public class Acoes
    {
        public string CodigoAcao { get; set; }
        public string RazaoSocial { get; set; }

        [NotMapped]
        public virtual ICollection<RegistroOperacoes> RegistroOperacoes { get; set; } = new List<RegistroOperacoes>();

    }
}
