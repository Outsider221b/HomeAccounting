using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Cущность "Счёт".
    /// </summary>
    [Table("source")]
    public class Source 
    {
        /// <summary>
        /// (RU) Идентификатор, первичный ключ.
        /// </summary>
        [Key]
        [Required]
		public int SourceId { get; set; }

		/// <summary>
		/// (RU) Название.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string? Title { get; set; }

		/// <summary>
		/// (RU) Начальный баланс.
		/// </summary>
		public double StartBalance { get; set; }

		/// <summary>
		/// (RU) Дата создания.
		/// </summary>
		public DateTime Creation { get; set; }

        /// <summary>
        /// (RU) Дата последнего редактирования информации о счёте.
        /// </summary>
        public DateTime LastUpdate { get; set; }

        // Navigation

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Валюта". Отношение Many(Source) To One(Currency).
        /// </summary>
        public Currency Currency { get; set; } = null!;
	}
}
