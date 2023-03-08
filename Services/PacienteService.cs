using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Dotnet.Services
{
    internal class PacienteService
    {
        private readonly Dictionary<string, Paciente> pacientes;

        public string Add(Paciente paciente)
        {
            string message = "Paciente adicionado com sucesso";

            if (pacientes.ContainsKey(paciente.Cpf))
            {
                message = "Paciente já existe na lista.";
            }
            else
            {
                pacientes.Add(paciente.Cpf, paciente);
            }

            return message;
        }
        public Paciente GetByCpf(string key)
        {
            Paciente value ;
            if (!pacientes.TryGetValue(key, out value))
            {
                throw new Exception("Paciente não encontrado");
            }

            return value;
        }
        public Dictionary<string, Paciente> GetAll()
        {
            return pacientes;
        }


    }
}
