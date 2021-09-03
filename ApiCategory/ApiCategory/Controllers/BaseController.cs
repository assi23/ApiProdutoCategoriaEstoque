using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaseController<R, M> : ControllerBase where R : BaseRepository<M> where M : BaseModel
	{
		R repository = Activator.CreateInstance<R>();
		[HttpGet]
		public List<M> Get()
		{
			return repository.Read();
		}
		// GET api/<CategoryController>/5
		[HttpGet("{id}")]
		public M Get(int id)
		{
			return repository.Read(id);
		}

		// POST api/<CategoryController>
		[HttpPost]
		public void Post([FromBody] M value)
		{
			repository.Create(value);
		}

		// PUT api/<CategoryController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] M model)
		{
			repository.Update(model);
		}

		// DELETE api/<CategoryController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			repository.Delete(id);
		}
	}
}
