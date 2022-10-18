﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RockyProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [DisplayName("DisplayOrder")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display order for Category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
