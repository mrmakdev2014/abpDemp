using System;
using System.Reflection;
using System.Security.Permissions;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Events
{
    public class Event : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public EventType EventType { get; set; }

    }
}
