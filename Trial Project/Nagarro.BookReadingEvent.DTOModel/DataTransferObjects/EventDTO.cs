using Nagarro.BookReadingEvent.Shared;
using System;

namespace Nagarro.BookReadingEvent.DTOModel
{
    [EntityMapping("Event", MappingType.TotalExplicit)]
    [ViewModelMapping("Nagarro.BookReadingEvent.Web.Shared.EventInfo", MappingType.TotalExplicit)]
    public class EventDTO : DTOBase,IEventDTO
    {

        [EntityPropertyMapping(MappingDirectionType.Both, "Id")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Id")]
        public int Id { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "title")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "title")]
        public string title { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "date")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "date")]
        public DateTime date { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "startTime")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "startTime")]
        public DateTime startTime { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "description")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "description")]
#nullable enable
        public string? description { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "type")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "type")]
        public bool type { get; set; }
    }
}
