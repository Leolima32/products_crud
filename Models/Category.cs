using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace products_crud.Models
{
    public class Category {

        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public virtual List<CategoryProducts> CategoryProducts { get; set; }
    }
}