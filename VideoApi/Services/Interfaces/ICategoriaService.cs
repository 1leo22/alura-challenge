using Model;
using System.Collections.Generic;

namespace Services.Interfaces
{
	public interface ICategoriaService
	{
		public List<Categoria> GetAllCategorias();

		public Categoria GetCategoriaById(int id);

		public void AddCategoria(Categoria categoria);

		public void DeleteCategoria(Categoria categoria);

		public void UpdateCategoria(Categoria categoria);
	}
}
