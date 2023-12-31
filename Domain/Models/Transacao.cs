﻿using LevvaCoins.Domain.Enums;
using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Domain.Models
{
    public class Transacao 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TipoTransacaoEnum Type { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public virtual Categoria Category { get; set; }
        public virtual Usuario User { get; set; }

    }
}
