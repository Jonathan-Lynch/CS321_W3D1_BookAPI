using CS321_W3D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Services
{
	public interface IAuthorService
	{
		// Get All
		IEnumerable<Author> GetAll();

		// Get book by id
		Author Get(int id);

		// Add book
		Author Add(Author newAuthor);

		// Update book
		Author Update(Author updatedAuthor);

		// Delete book
		void Delete(Author author);
	}
}
