using Soenneker.Tests.HostedUnit;

namespace Soenneker.Radarr.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RadarrOpenApiClientTests : HostedUnitTest
{
    public RadarrOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
