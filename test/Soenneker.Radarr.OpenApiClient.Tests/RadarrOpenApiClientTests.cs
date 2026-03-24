using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Radarr.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class RadarrOpenApiClientTests : FixturedUnitTest
{
    public RadarrOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
