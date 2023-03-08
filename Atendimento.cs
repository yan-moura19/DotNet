using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Dotnet
{
    internal class Atendimento
    {
        public Paciente paciente { get; set; }

        public int cod { get; set; }

        public Procedimento procedimento { get; set; }
    }
}
