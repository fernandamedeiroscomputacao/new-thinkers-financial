using Financial.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financial.Models
{
    public class Conta : IConta
    {
        #region Propriedades
        #region DadosIndividuais
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Endereco { get; set; }
        #endregion DadosIndividuais

        #region DadosConta        
        public string PacoteServico { get; set; }
        public TipoConta TipoConta { get; set; }
        #endregion DadosConta
        #endregion Propriedade

        #region Métodos
        public decimal VisualizarSaldo()
        {
            throw new NotImplementedException();
        }

        public decimal GerarSaldo(decimal valor)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
