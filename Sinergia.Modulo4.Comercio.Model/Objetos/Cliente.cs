using Sinergia.Modulo4.Comercio.Enumerador;
using Sinergia.Modulo4.Comercio.Model.Dependencias;
using Sinergia.Modulo4.Comercio.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinergia.Modulo4.Comercio.Model
{
   public class Cliente: ModelGenerico
    {

        public bool PessoaFisica { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string RG { get; set; }

        public string InscricaoEstadual { get; set; }

        public string RazaoSocial { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Observação { get; set; }

        public bool CreditoAprovado { get; set; }

        public Endereco Endereco { get; set; }

        public Contato Contato { get; set; }

        public eSituacao Situacao { get; set; }
    }
}
