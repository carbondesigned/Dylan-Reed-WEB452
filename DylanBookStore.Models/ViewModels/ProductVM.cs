using DylanBookStore.Models;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanBookStore.Models.ViewModels
{
    public class ProductVM
    {
        // SelectListItem doesn't work
        public Product Product { get; set; }
        public IEnumerable<List<string>> CategoryList { get; set; }
        public IEnumerable<List<string>> CoverTypeList { get; set; }
    }
}