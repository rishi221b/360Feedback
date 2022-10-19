using InitialTry.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace InitialTry.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
