using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Сущность "Субъект обязательства". Выступает в роли кредитора или должника, может быть человеком, группой людей, организацией и т.п.
    /// </summary>
    [Table("obligation_subject")]
    public class ObligationSubject
    {
        /// <summary>
        /// (RU) Идентификатор, первичный ключ.
        /// </summary>
        [Key]
        [Required]
		public int ObligationSubjectId { get; set; }

		/// <summary>
		/// (RU) Название субъекта. Может быть имя человека, название организации и т.п.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string? Title { get; set; }

		/// <summary>
		/// (RU) Комментарий или описание (необязателен).
		/// </summary>
		[MaxLength(200)]
		public string? Description { get; set; }

        /// <summary>
        /// (RU) Дата создания субъекта.
        /// </summary>
        [Required]
		public DateTime Creation { get; set; }

        /// <summary>
        /// (RU) Дата последнего редактирования информации о субъекте.
        /// </summary>
        [Required]
        public DateTime LastUpdate { get; set; }

        // Navigation

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Обязательство". Отношение One(ObligationSubject) To Many(Obligation).
        /// </summary>
        public List<Obligation>? Obligations { get; set; }
	}
}
