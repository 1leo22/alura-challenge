using Dao.Interfaces;
using Model;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
	public class CategoriaService : ICategoriaService
	{
		private readonly IAbstractDao<Categoria> _categoriaDao;

		public CategoriaService(IAbstractDao<Categoria> categoriaDao)
		{
			_categoriaDao = categoriaDao;
		}

		public List<Categoria> GetAllCategorias()
		{
			List<Categoria> videoList = _categoriaDao.GetAll().ToList();

			return videoList;
		}

		public Categoria GetCategoriaById(int id)
		{
			Categoria categoria = _categoriaDao.Get(id);

			return categoria;
		}

		public void AddCategoria(Categoria categoria)
		{
			_categoriaDao.Add(categoria);
		}

		public void DeleteCategoria(Categoria categoria)
		{
			_categoriaDao.Remove(categoria);
		}

		public void UpdateCategoria(Categoria categoria)
		{
			_categoriaDao.Update(categoria);
		}
	}
}
