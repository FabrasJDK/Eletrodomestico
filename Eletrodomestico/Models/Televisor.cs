namespace Eletrodomestico.Models
{
    public class Televisor : Eletrodosmetico
    {
        public int TamanhoTela { get; set; }
        public bool Smart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca {marca}, Modelo {modelo}, Consumo é {ConsumoEnergetico}, Tamanho da Tela {TamanhoTela}. é smart? {(Smart ? "Sim" : "Não")}";
        }
    }
}
