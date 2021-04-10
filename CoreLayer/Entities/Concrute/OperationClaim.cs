using System;
using System.ComponentModel.DataAnnotations;
using CoreLayer.Entities.Abstruct;

namespace CoreLayer.Entities.Concrute
{
    public class OperationClaim : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ClaimType { get; set; }
    }
}
