﻿using FastEndpoints.Validation;
using FastEndpoints.Validation.Results;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using System.Text;

namespace FastEndpoints;

public abstract class BaseEndpoint : IEndpoint
{
    protected internal HttpContext _httpContext; //this is set at the start of ExecAsync() method of each endpoint instance

    internal static PropertyInfo SettingsPropInfo { get; } = typeof(BaseEndpoint).GetProperty(nameof(Settings), BindingFlags.NonPublic | BindingFlags.Instance)!;

    internal EndpointSettings Settings { get; set; } = new();

    internal abstract Task ExecAsync(HttpContext ctx, IValidator? validator, object? preProcessors, object? postProcessors, CancellationToken ct);

    internal string GetTestURL()
    {
        Configure();

        if (Settings.Routes is null)
            throw new ArgumentNullException($"GetTestURL()[{nameof(Settings.Routes)}]");

        return new StringBuilder().BuildRoute(Settings.Version, Settings.Routes[0]);
    }

    /// <summary>
    /// the http context of the current request
    /// </summary>
    public HttpContext HttpContext => _httpContext;

    /// <summary>
    /// use this method to configure how the endpoint should be listening to incoming requests.
    /// <para>HINT: it is only called once during endpoint auto registration during app startup.</para>
    /// </summary>
    public abstract void Configure();

    /// <summary>
    /// the list of validation failures for the current request dto
    /// </summary>
    public List<ValidationFailure> ValidationFailures { get; } = new();
}
