using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Dotnet.Services
{
    internal class AtendimentoService
    {
        private readonly Dictionary<int, Atendimento> atendimentos;

        public string Add(Atendimento atendimento)
        {
            string message = "Paciente adicionado com sucesso";

            
                atendimentos.Add(atendimento.cod, atendimento);
            

            return message;
        }


    }
}
