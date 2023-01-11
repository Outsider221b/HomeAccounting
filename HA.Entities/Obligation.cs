using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Сущность "Долговое обязательство(займ)".
    /// </summary>
    [Table("obligation")]
    public class Obligation
    {
        /// <summary>
        /// (RU) Идентификатор, первичный ключ, порядковый номер. 
        /// </summary>
        [Key]
		[Required]
		public int ObligationId { get; set; }

		/// <summary>
		/// (RU) Название.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string? Title { get; set; }

		/// <summary>
		/// (RU) Комментарий (необязателен).
		/// </summary>
		[MaxLength(200)]
		public string? Description { get; set; }

		/// <summary>
		/// (RU) Сумма займа.
		/// </summary>
		public double MoneyCount { get; set; }

		/// <summary>
		/// (RU) Направление займа. Если true, значит займ входящий (нам дали в долг), если false - займ исходящий (мы дали в долг).
		/// </summary>
		public bool IsIncoming { get; set; }

		/// <summary>
		/// (RU) Актуальность обязательства. Если true, обязательство актуально (долг не погашен), если false - обязательство не актуально (долг погашен).
		/// </summary>
		public bool IsActual { get; set; }

		//Navigation

		/// <summary>
		/// (RU) Навигационное свойство для связанной сущности "Субъект обязательства". Отношение Many(Obligation) To One(ObligationSubject).
		/// </summary>
		[ForeignKey(nameof(ObligationSubjectId))]
        public ObligationSubject? ObligationSubject { get; set; }

		public int? ObligationSubjectId { get; set; }

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Тег". Отношение Many(Obligation) To Many(Tag).
        /// </summary>
        public List<Tag>? Tags { get; set; }

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Транзакция". Отношение Many(Obligation) To Many(Transaction).
        /// </summary>
        public List<Transaction>? Transactions { get; set; }
	}
}
