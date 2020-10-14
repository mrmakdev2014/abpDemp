using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Events
{
    public class EventDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public EventType EventType { get; set; }

    }
}
