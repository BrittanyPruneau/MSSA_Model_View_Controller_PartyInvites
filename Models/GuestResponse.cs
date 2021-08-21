using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse  // POCO Plain Old C# Object 
    {
        // Fields

        [Required(ErrorMessage = "Name Is Required")]

        public string    Name              { get; set; } // property create some field behind 
                                            //the scenes and get a field 
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string    Email             { get; set; } //property

        [Required(ErrorMessage = "Phone Is Required")]
        public string    Phone             { get; set; } // Property 

        [Required(ErrorMessage = "WillAttend Is Required")]
        public bool?     WillAttend        { get; set; } // Property 
                                                 //   ?  it can have   true  false  NULL 
        
        public char      Gender            { get; set; }   

        public string Password             { get; set; }

        // Constructors 

        // methods 
    }
}
