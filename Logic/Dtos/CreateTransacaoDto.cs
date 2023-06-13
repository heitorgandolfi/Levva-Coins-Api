using LevvaCoins.Domain.Enums;

namespace LevvaCoins.Logic.Dtos
{
    public class CreateTransacaoDto
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TipoTransacaoEnum Type { get; set; }
        public int CategoryId { get; set; }
    }
}
