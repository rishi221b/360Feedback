using InitialTry.Application.Features.Events.Queries.GetEventsExport;
using InitialTry.Infrastructure.FileExport;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace InitialTry.Infrastructure.UnitTests.FileExport
{
    public class CsvExporterTests
    {
        [Fact]
        public void ExportEventsToCsv()
        {
            var exporter = new CsvExporter();

            var result = exporter.ExportEventsToCsv(new List<EventExportDto>());

            result.ShouldNotBeNull();
            result.ShouldBeOfType<byte[]>();
        }
    }
}
