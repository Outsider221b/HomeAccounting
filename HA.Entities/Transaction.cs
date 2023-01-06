using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Сущность "Денежная операция/транзакция".
    /// </summary>
    [Table("transaction")]
    public class Transaction
    {
		/// <summary>
		/// (RU) Идентификатор, первичный ключ.
		/// </summary>
		[Key]
		[Required]
		public int TransactionId { get; set; }

		/// <summary>
		/// (RU) Определяет направление транзакции. Если true, транзакция входящая (доход), если false - исходящая (расход).
		/// </summary>
		public bool IsIncoming { get; set; }

		/// <summary>
		/// (RU) Сумма транзакции.
		/// </summary>
		public double MoneyCount { get; set; }

		/// <summary>
		/// (RU) Баланс на связанном счёте до транзакции.
		/// </summary>
		public double BalanceBefore { get; set; }

        /// <summary>
        /// (RU) Комментарий или описание (необязателен).
        /// </summary>
        [MaxLength(200)]
		public string? Description { get; set; }

		/// <summary>
		/// (RU) Дата создания транзакции.
		/// </summary>
		public DateTime Creation { get; set; }

		/// <summary>
		/// (RU) Дата последнего редактирования информации о транзакции.
		/// </summary>
		public DateTime LastUpdate { get; set; }

        // Navigation

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Счёт". Отношение Many(Transaction) To One(Source).
        /// </summary>
        public Source Source { get; set; } = null!;

		/// <summary>
		/// (RU) Навигационное свойство для связанной сущности "Обязательство". Отношение Many(Transaction) To Many(Obligation).
		/// </summary>
		public List<Obligation> Obligations { get; set; } = null!;

		/// <summary>
		/// (RU) Навигационное свойство для связанной сущности "Обязательство". Отношение Many(Transaction) To Many(Tag).
		/// </summary>
		public List<Tag> Tags { get; set; } = null!;
	}
}
