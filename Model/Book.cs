using System;
using System.ComponentModel.DataAnnotations;

public class Book
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public String Name { get; set; }

            [Display(Name="Author Name")]
            public String Author { get; set; }

            public String Editor {get; set; }
        }