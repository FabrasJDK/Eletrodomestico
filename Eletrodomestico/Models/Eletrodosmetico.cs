namespace Eletrodomestico.Models
{
    public abstract class Eletrodosmetico  
    {
        public string marca {  get; set; }
        public string modelo { get; set; }
        public double ConsumoEnergetico { get; set; }

        public abstract string ExibirDetalhes();
        
       
        
    }
}
