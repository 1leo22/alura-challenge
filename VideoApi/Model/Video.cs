using System.ComponentModel.DataAnnotations;

namespace Model
{
	public class Video
	{
		[Key]
		[Required]
		public int Id { get; private set; }

		[Required(ErrorMessage = "O campo título é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		public string Titulo { get; private set; }

		[Required(ErrorMessage = "O campo descrição é obrigatório")]
		[StringLength(255, ErrorMessage = "O campo título não pode ultrapassar 255 caracteres")]
		public string Descricao { get; private set; }

		[Required(ErrorMessage = "O campo url é obrigatório")]
		[StringLength(128, ErrorMessage = "O campo título não pode ultrapassar 128 caracteres")]
		public string Url { get; private set; }

		public Video(int id, string titulo, string descricao, string url)
		{
			Id = id;
			Titulo = titulo;
			Descricao = descricao;
			Url = url;
		}
	}
}
