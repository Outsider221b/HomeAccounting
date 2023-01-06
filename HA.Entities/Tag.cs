using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Entities
{
    /// <summary>
    /// [COMPLETED]
    /// (RU) Сущность "тег".
    /// </summary>
    [Table("tag")]
    public class Tag
    {
        /// <summary>
        /// (RU) Идентификатор, первичный ключ.
        /// </summary>
        [Key]
        [Required]
		public int TagId { get; set; }

		/// <summary>
		/// (RU) Содержание тега.
		/// </summary>
		[Required]
		[MaxLength(20)]
		public string? Content { get; set; }

        //Navigation

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Транзакция". Отношение Many(Tag) To Many(Transaction).
        /// </summary>
        public List<Transaction> Transactions { get; set; } = null!;

        /// <summary>
        /// (RU) Навигационное свойство для связанной сущности "Обязательство". Отношение Many(Tag) To Many(Obligation).
        /// </summary>
        public List<Obligation> Obligations { get; set;} = null!;
    }
}
