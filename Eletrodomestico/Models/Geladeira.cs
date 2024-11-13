namespace Eletrodomestico.Models
{
    public class Geladeira : Eletrodosmetico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca {marca}, Modelo {modelo}, Capacidade {CapacidadeLitros}, Possui Freezer? {TemFreezer}";
        }
    }
}
