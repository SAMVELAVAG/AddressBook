//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApp.DBContexts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="You need to give us your FullName")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "You need to give us your EmailAddress")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You need to give us your PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You need to give us your PhysicalAddress")]
        public string PhysicalAddress { get; set; }
    }
}
