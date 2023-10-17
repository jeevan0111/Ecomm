using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecomm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> listOfCategories = new List<Category>
        {
            new Category{Id=1,Title="Samsung",DisplayOrder=1},
            new Category{Id=2,Title="Noika",DisplayOrder=2},
            new Category{Id=3,Title="LG",DisplayOrder=3},
            new Category{Id=4,Title="Xiomi",DisplayOrder=4},
            new Category{Id=5,Title="Apple",DisplayOrder=5}
        };

        

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return listOfCategories;
        }

        [HttpPost]
        public void Post([FromBody] Category category)
        {
            listOfCategories.Add(category);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            listOfCategories[id] = category;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listOfCategories.RemoveAt(id);
        }
    } 
}
