using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;

namespace BusinessServiceInterface
{
    public interface ICategoryService
    {
        void Add(Category c);
        void Delete(Category c);
        Category Get(string id);
        IList<Category> GetAll();
        void Update(Category c);
    }
}
