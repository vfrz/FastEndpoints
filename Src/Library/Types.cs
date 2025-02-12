﻿using FastEndpoints.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace FastEndpoints;

internal static class Types
{
    //there's no performance benefit gained from this.
    //it's only there to make code more readable and save a few keystrokes.

    internal static readonly Type Enum = typeof(Enum);
    internal static readonly Type EmptyResponse = typeof(EmptyResponse);
    internal static readonly Type EmptyRequest = typeof(EmptyRequest);
    internal static readonly Type Guid = typeof(Guid);
    internal static readonly Type Http = typeof(Http);
    internal static readonly Type IEndpoint = typeof(IEndpoint);
    internal static readonly Type IEndpointFeature = typeof(IEndpointFeature);
    internal static readonly Type IEventHandler = typeof(IEventHandler);
    internal static readonly Type IFormFile = typeof(IFormFile);
    internal static readonly Type IPlainTextRequest = typeof(IPlainTextRequest);
    internal static readonly Type IValidator = typeof(IValidator);
    internal static readonly Type Object = typeof(object);
    internal static readonly Type String = typeof(string);
    internal static readonly Type TimeSpan = typeof(TimeSpan);
    internal static readonly Type Uri = typeof(Uri);
    internal static readonly Type Version = typeof(Version);
}
