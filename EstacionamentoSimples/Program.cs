List<string> estacionamento = new List<string>();

while (true)
{
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine($"Opção 1: Inserir Carro \nOpção 2: Remover Carro \nOpção 3: Ver Lista de Carros \nOpção 4: Fechar Estacionamento");

    string opcao = Convert.ToString(Console.ReadLine());
    string? placa;

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
    {
        Console.WriteLine("Opção Inválida");
    }
    else
    {
        int opcao_int = Convert.ToInt32(opcao);
        if (opcao_int == 1)
        {
            Console.WriteLine("Insira a placa do veículo: ");
            placa = Convert.ToString(Console.ReadLine());

            if (!string.IsNullOrEmpty(placa))
            {
                estacionamento.Add($"{placa}");
                Console.WriteLine("Placa adicionada com sucesso!");
                Console.Clear();
            }

        }
        else if (opcao_int == 2)
        {
            Console.WriteLine("Insira a placa do carro que quer remover: ");
            placa = Console.ReadLine();
            if (estacionamento.Contains(placa))
            {
                Console.WriteLine("Insira a quantidade de minutos usados: ");
                int tempoEstacionado = Convert.ToInt32(Console.ReadLine());

                estacionamento.Remove(placa);
                Console.Clear();
                Console.WriteLine("Carro removido com sucesso.");
                Console.WriteLine($"Valor devido: R${10 + (2 * tempoEstacionado)}.");
            }
            else
            {
                Console.WriteLine("Carro não encontrado tente novamente caso for um erro!");
            }
        }
            else if (opcao_int == 3)
            {
                Console.Clear();
                foreach (string item in estacionamento)
                {
                    Console.WriteLine(item);
                }

            }
            else if (opcao_int == 4)
            {
                estacionamento.Clear();
                
                break;
            }

    }

}