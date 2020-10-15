using System;
using System.Collections.Generic;
using System.Text;

namespace Financial.Models
{
    public class Conta : IConta
    {
        #region Propriedades
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string PacoteServico { get; set; }
        #endregion

        #region Construtores
        public Conta()
        {
        }
        #endregion

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
