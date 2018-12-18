namespace Todo.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Task
    {    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int Id { get; set; }

        [Required]
        public string UserPhoto { get; set; }

        [Required]
        public string Name { get; set; }
       
        [Required]     
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FinalDate { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Importance { get; set; }
    }
}