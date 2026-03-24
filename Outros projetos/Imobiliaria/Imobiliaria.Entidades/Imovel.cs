namespace Imobiliaria.Entidades
{
    public class Imovel
    {
        public int Id { get; set; }
        public required string Endereco { get; set; }
        public required double Preco { get; set; }
        public required string TipoNegocio { get; set; } // Venda ou Aluguel
    }
}