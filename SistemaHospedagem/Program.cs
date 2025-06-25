
using System.Net.Security;
using static Reserva;

Reserva reserva1 = new Reserva();
Pessoa bruno = new Pessoa();
Pessoa allan = new Pessoa();
Pessoa lia = new Pessoa();
Pessoa janete = new Pessoa();

bruno.Nome = "Bruno";
bruno.Sobrenome = "Carvalho";

allan.Nome = "Allan";
allan.Sobrenome = "Carvalho";

lia.Nome = "Maria Lia";
lia.Sobrenome = "Carvalho";

janete.Nome = "Janete";
janete.Sobrenome = "Carvalho";

//-------------------------------

Suite suite2camas = new Suite();
suite2camas.Capacidade = 2;
suite2camas.TipoSuite = "Suíte com 2 camas";
suite2camas.ValorDiaria = 100;

//-------------------------------

Suite suite6camas = new Suite();
suite6camas.Capacidade = 6;
suite6camas.TipoSuite = "Suíte com 6 camas";
suite6camas.ValorDiaria = 500;

//-------------------------------


reserva1.CadastrarHospedes(new List<Pessoa> { bruno, allan, lia, janete });
reserva1.CadastrarSuite(suite6camas);
reserva1.DiasReservados = 4;

//reserva1.CadastrarSuite(new Suite suite2camas); //Dá exceção

//Console.WriteLine(reserva1.ObterQuantidadeHospedes()); //retorna 4

//Forma correta de chamar métodos static, você passa o molde (Reserva) o nome do método e o objeto real "reserva1"
Reserva.RevisarReserva(reserva1);