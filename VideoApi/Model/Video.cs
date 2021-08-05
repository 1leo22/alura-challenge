using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
	[Table("video")]
	public class Video
	{
		[Key]
		[Required]
		[Column("id")]
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo título é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		[Column("titulo")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = "O campo descrição é obrigatório")]
		[StringLength(255, ErrorMessage = "O campo título não pode ultrapassar 255 caracteres")]
		[Column("descricao")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "O campo url é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		[Column("url")]
		public string Url { get; set; }
	}
}
