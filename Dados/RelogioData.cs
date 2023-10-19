using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RelogioDigital.Dados
{
    class RelogioData
    {
        public Relogio Relogio { get; set; }
        public Data Data { get; set; }

        public RelogioData() 
        {
            Relogio = new Relogio();
            Data = new Data();
        }
    }
}
