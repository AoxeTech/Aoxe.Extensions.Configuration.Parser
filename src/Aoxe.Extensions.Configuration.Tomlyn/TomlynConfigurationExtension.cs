﻿namespace Aoxe.Extensions.Configuration.Tomlyn;

public static class TomlynConfigurationExtension
{
    public static IConfigurationBuilder AddTomlStream(
        this IConfigurationBuilder builder,
        Stream utf8Stream
    ) =>
        builder.Add(new AoxeStreamConfigurationSource(new TomlFlattener()) { Stream = utf8Stream });

    public static IConfigurationBuilder AddTomlFile(
        this IConfigurationBuilder builder,
        string path,
        bool optional = false
    ) =>
        builder.Add(
            new AoxeFileConfigurationSource(new TomlFlattener())
            {
                Path = path,
                Optional = optional
            }
        );
}
