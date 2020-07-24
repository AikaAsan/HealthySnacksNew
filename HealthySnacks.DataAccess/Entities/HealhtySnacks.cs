using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthySnacks.DataAccess.Entities

{
    [Table ("HealthySnacks")]

    public class HealthySnacks
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }


        [Column("Name")]
        
        public string Name { get; set; }


        [Column("Description")]
       
        public string Description { get; set; }


        [Column("Price")]
        
        public decimal Price { get; set; }


        [Column("ImageUrl")]
       
        public string ImageUrl { get; set; }



        [Column("CategoryId")]
        
        public int CategoryId { get; set; }

       //[Column("Category")]
       // [Key]
       // public virtual Category Category { get; set; }

 
    }
}
