using System.ComponentModel.DataAnnotations;

namespace Model.Dto
{
	public class UpdateVideoDto
	{
		[Required(ErrorMessage = "O campo título é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = "O campo descrição é obrigatório")]
		[StringLength(255, ErrorMessage = "O campo título não pode ultrapassar 255 caracteres")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "O campo url é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		public string Url { get; set; }
	}
}
