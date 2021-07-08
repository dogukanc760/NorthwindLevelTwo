using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage = "Sen Kimsiniz?")]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required]
        public string City { get; set; }
        //[Required]
        public string Adress { get; set; }
        //[Required]
        //[Range(18,120)]
        public int Age { get; set; }
    }
}
