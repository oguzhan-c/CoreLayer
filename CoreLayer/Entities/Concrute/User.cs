using System;
using System.ComponentModel.DataAnnotations;
using CoreLayer.Entities.Abstruct;

namespace CoreLayer.Entities.Concrute
{
    public class User : IEntity
    {
        [Key]
        public int Id{ get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String  Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
