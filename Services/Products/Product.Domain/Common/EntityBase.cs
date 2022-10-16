﻿using System.ComponentModel.DataAnnotations;

namespace Product.Domain.Common
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
