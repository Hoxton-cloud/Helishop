using Helishop.Folder.Interfaces;
using Helishop.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Folder.Mocks
{
    public class MockCategory : IHelicopterCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Robinson", desc = "Вертолеты компании Robinson"},
                    new Category{ categoryName = "Airbus", desc = "Вертолеты компании Airbus"},
                };
            }
        }
    }
}
