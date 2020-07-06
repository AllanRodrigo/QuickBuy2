namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId.Equals(0))
                AdicionarCritica("Não foi identificado qual a referência para o produto");

            if (Quantidade.Equals(0))
                AdicionarCritica("Quantidade não foi informada");
        }
    }
}
