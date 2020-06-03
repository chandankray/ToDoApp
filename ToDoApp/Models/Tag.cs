﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]        
        public string Name { get; set; }

        //Many to many relationship
        public ICollection<TodoTag> TodoTags { get; set; }
    }
}
