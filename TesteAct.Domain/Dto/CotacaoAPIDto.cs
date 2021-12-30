using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAct.Domain.Dto
{
    public class CotacaoAPIDto
    {
        public string id { get; set; }
        public string tp_reg { get; set; }
        public string dt_pregao { get; set; }
        public string cd_bdi { get; set; }
        public string cd_acao { get; set; }
        public string tp_merc { get; set; }
        public string nm_empresa_rdz { get; set; }
        public string especi { get; set; }
        public string prazot { get; set; }
        public string moeda_ref { get; set; }
        public string vl_abertura { get; set; }
        public string vl_maximo { get; set; }
        public string vl_minimo { get; set; }
        public string vl_medio { get; set; }
        public string vl_fechamento { get; set; }
        public string vl_mlh_oft_compra { get; set; }
        public string vl_mlh_oft_venda { get; set; }
        public string vl_ttl_neg { get; set; }
        public string qt_tit_neg { get; set; }
        public string vl_volume { get; set; }
        public string vl_exec_opc { get; set; }
        public string in_opc { get; set; }
        public string dt_vnct_opc { get; set; }
        public string ft_cotacao { get; set; }
        public string vl_exec_moeda_corrente { get; set; }
        public string cd_isin { get; set; }
        public string cd_acao_rdz { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
}


