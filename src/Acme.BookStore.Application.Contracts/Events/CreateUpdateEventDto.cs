using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Events
{
    public class CreateUpdateEventDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }


        [Required]
        public EventType EventType { get; set; }

    }
}
