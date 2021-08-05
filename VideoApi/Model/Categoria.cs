using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utilities;

namespace Model
{
	[Table("categoria")]
	public class Categoria
	{

		[Key]
		[Required]
		[Column("id")]
		public int Id { get; set; }

		[Required(ErrorMessage = Constants.ERRO_MSG)]
		[StringLength(128, ErrorMessage = "O campo não pode ultrapassar 128 caracteres")]
		[Column("titulo")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = Constants.ERRO_MSG)]
		[StringLength(32, ErrorMessage = "O campo não pode ultrapassar 32 caracteres")]
		[Column("cor")]
		public string Cor { get; set; }
	}
}
