using System;

public class Reserva
{
	public List<Pessoa> hospedes { get; set; } = new List<Pessoa>();
	public Suite suite { get; set; } = new Suite();
    public int? DiasReservados { get; set; }

	public void CadastrarHospedes(List<Pessoa> hospedesInput)
	{

			foreach (Pessoa pessoa in hospedesInput)
				{
				hospedes.Add(pessoa);
				}
	}

	public void CadastrarSuite(Suite suiteInput)
	{
		if (hospedes.Count > suiteInput.Capacidade)
			{
			throw new Exception("Número de hóspedes maior que a capacidade da suíte!");
			}
		else
			{
			suite = suiteInput;
			Console.WriteLine("Suíte cadastrada com sucesso!");
			}
	}

	public int ObterQuantidadeHospedes()
	{
		return hospedes.Count;
	}

	public decimal CalcularValorDiaria(int dias)
	{
		decimal valor = dias * Convert.ToDecimal(suite.ValorDiaria);

        if (dias > 10)
		{
			return valor - (valor / 100);
		}
		else
		{
			return valor;
		}
	}

	public static void RevisarReserva(Reserva reservaInput) //Método static é sobre a "planta" sem static é sobre o "objeto real"
		{
		Console.WriteLine($"A reserva está confirmada para {reservaInput.hospedes.Count} hospedes na suíte {reservaInput.suite.TipoSuite} com o valor total de R${reservaInput.suite.ValorDiaria * reservaInput.DiasReservados} para uma estadia de {reservaInput.DiasReservados} dia(s).");
		}
}
