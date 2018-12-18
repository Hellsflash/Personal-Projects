namespace Todo.Dto
{
    using System;
    using Enums;
    using System.ComponentModel.DataAnnotations;

    public class TaskDto
    {       
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill the Name field!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill the Content field!")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please fill the Date field!")]
        [DataType(DataType.Date,ErrorMessage = "The field should be a proper date!")]
        public DateTime FinalDate { get; set; }
        
        public ImportanceEnum Importance { get; set; }

        public string UserPhoto { get; set; }

        public string Status { get; set; }
    }
}
