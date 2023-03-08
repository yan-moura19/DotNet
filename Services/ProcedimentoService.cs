using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Dotnet.Services
{
    internal class ProcedimentoService
    {
        private readonly Dictionary<int, Procedimento> procedimentos;

        public ProcedimentoService()
        {
            procedimentos = new Dictionary<int, Procedimento> {
            { 1, new Procedimento { Nome = "Clareamento dental" } },
            { 2, new Procedimento { Nome = "Tratamento ortodôntico" } },
            { 3, new Procedimento { Nome = "Implante" } },
            { 4, new Procedimento { Nome = "Extração" } },
            { 5, new Procedimento { Nome = "Enxerto gengival" } },
            { 6, new Procedimento { Nome = "Restauração" } },
            { 7, new Procedimento { Nome = "Canal" } }
        };

        }

        public string Add(Procedimento procedimento)
        {
            string message = "Procedimento adicionado com sucesso";

            if (procedimentos.ContainsKey(procedimento.Id))
            {
                message = "Procedimento já existe na lista.";
            }
            else
            {
                procedimentos.Add(procedimento.Id, procedimento);
            }

            return message;
        }
        public Procedimento GetByCpf(int key)
        {
            Procedimento value;
            if (!procedimentos.TryGetValue(key, out value))
            {
                throw new Exception("Procedimento não encontrado");
            }

            return value;
        }
        public Dictionary<int, Procedimento> GetAll()
        {
            return procedimentos;
        }
    }
}
