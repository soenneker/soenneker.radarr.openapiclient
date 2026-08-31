[![](https://img.shields.io/nuget/v/soenneker.radarr.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.radarr.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.radarr.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.radarr.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.radarr.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.radarr.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.radarr.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.radarr.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Radarr.OpenApiClient

Generated request builders and models for Radarr movies, calendars, queues, downloads, indexers, quality profiles, commands, and system resources.

## Installation

```bash
dotnet add package Soenneker.Radarr.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Radarr.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "http://localhost:7878"
};

var client = new RadarrOpenApiClient(adapter);
var status = await client.Api.V3.System.Status.GetAsync(
    cancellationToken: cancellationToken);
```

Replace the base URL with the address of your Radarr instance. Find the API key in Radarr under **Settings → General → Security**. The key is sent through `X-Api-Key`; the anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries that header.
