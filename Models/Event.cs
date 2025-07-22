using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Event
    {
        [Required(ErrorMessage = "Event name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Event date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Event location is required.")]
        [StringLength(100, ErrorMessage = "Location can't be longer than 100 characters.")]
        public string Location { get; set; }
    }
}
