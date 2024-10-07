namespace DesafioFundamentos.Models;

public class Estacionamento
{
    public decimal PrecoInicial { get; set; }
    public decimal PrecoPorHora { get; set; }
    public List<string> Veiculos { get; }
    
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        PrecoInicial = precoInicial;
        PrecoPorHora = precoPorHora;
        Veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        var placa = Console.ReadLine();
        if (placa != null) Veiculos.Add(placa.ToUpper());
    }
    
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        var placa = Console.ReadLine();

        if (Veiculos.Any(x => placa != null && x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

            if (placa != null)
            {
                Veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal.ToString("0.00")}");
            }
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (Veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var placa in Veiculos)
            {
                Console.WriteLine($"> Veículo estacionado com placa {placa}");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}