using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
	public class BaseRepository<M> where M : BaseModel
	{
		public void Create(M model)
		{
			using (var context = new CategoryContext())
			{
				context.Set<M>().Add(model);
				context.SaveChanges();
			}
		}
		public List<M> Read()
		{
			List<M> list = new List<M>();
			using (var context = new CategoryContext())
			{
				list = context.Set<M>().ToList();
			}
			return list;
		}
		public M Read(int id)
		{
			M model = Activator.CreateInstance<M>();
			using (var context = new CategoryContext())
			{
				model = context.Set<M>().Find(id);
			}
			return model;
		}
		public void Update(M model)
		{
			using (var context = new CategoryContext())
			{
				context.Entry<M>(model).State =EntityState.Modified;
				context.SaveChanges();
			}
		}
		public void Delete(int id)
		{
			using (var context = new CategoryContext())
			{
				context.Entry<M>(this.Read(id)).State = EntityState.Deleted;
				context.SaveChanges();
			}
		}
	}
}
