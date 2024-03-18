using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst4NorthvndTables.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[]? picture { get; set; }




    }
}
