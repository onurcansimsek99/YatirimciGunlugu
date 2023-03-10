using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		
		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BloAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
            throw new NotImplementedException();

        }

		public Blog GetById(int id)
		{
            throw new NotImplementedException();
        }

		public List<Blog> GetList()
		{
			return _blogdal.GetListAll();
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BloDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogdal.GetListWithCategory();

        }
	}
}
