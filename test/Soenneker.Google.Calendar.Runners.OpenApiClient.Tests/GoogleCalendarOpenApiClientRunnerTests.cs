using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Calendar.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GoogleCalendarOpenApiClientRunnerTests : HostedUnitTest
{
    public GoogleCalendarOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
