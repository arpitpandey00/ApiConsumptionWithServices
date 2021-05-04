using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UpdatedcCudApi
{
    public class Product
    {
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }
        public bool InStock { get; set; }
    }
}
