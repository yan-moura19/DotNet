// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int opcao;
do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Cadastro de pacientes.");
    Console.WriteLine("2 - Pesquisar por paciente.");
    Console.WriteLine("3 - Cadastro de procedimentos.");
    Console.WriteLine("4 - Realizar um atendimento.");
    Console.WriteLine("0 - Sair.");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro de pacientes selecionado.");
            break;
        case 2:
            Console.WriteLine("Pesquisar por paciente selecionado.");
            break;
        case 3:
            Console.WriteLine("Cadastro de procedimentos selecionado.");
            break;
        case 4:
            Console.WriteLine("Realizar um atendimento selecionado.");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (opcao != 0);
    }