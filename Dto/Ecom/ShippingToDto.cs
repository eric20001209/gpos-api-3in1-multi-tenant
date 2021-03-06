using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerce_API.Dto
{
    public struct mystruct
    {
        public void print1()
        {
            Console.WriteLine("11111");
        }
    }
    public class ShippingToDto
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string contact { get; set; }
        public string note { get; set; }
    }
}
