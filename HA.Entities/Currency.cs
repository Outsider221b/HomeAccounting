using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Сущность "Валюта".
    /// </summary>
    [Table("currency")]
    public class Currency
    {
		/// <summary>
		/// (RU) Идентификатор, первичный ключ, порядковый номер. 
		/// </summary>
		[Key]
		[Required]
		public int CurrencyId { get; set; }

		/// <summary>
		/// (RU) Полное название валюты, например, "Рубль".
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string? Title { get; set; }

		/// <summary>
		/// (RU) Сокращенное название валюты, например, "USD".
		/// </summary>
		[Required]
		[MaxLength(5)]
		public string? ShortTitle { get; set; }

		/// <summary>
		/// (RU) Комментарий (необязателен).
		/// </summary>
		[MaxLength(200)]
		public string? Description { get; set; }

		//Navigation

		/// <summary>
		/// (RU) Навигационное свойство для связанной сущности "Счёт". Связь One(Currency) To Many(Source).
		/// </summary>
		public List<Source> Sources { get; set; } = null!;
	}
}
