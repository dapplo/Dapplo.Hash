// Copyright (c) Dapplo and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Dapplo.Log;

namespace Dapplo.Hash.PerformanceTests
{
    /// <summary>
    /// This initializes the benchmark tests
    /// </summary>
    public static class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            LogSettings.RegisterDefaultLogger<NullLogger>(LogLevels.Info);

            var jobCore50 = Job.Default.WithRuntime(CoreRuntime.Core50).WithPlatform(Platform.X64);
            var jobCore31 = Job.Default.WithRuntime(CoreRuntime.Core31).WithPlatform(Platform.X64);
            var jobNet472 = Job.Default.WithRuntime(ClrRuntime.Net472).WithPlatform(Platform.X64);
            var config = DefaultConfig.Instance
                .AddJob(jobCore50)
                .AddJob(jobCore31)
                .AddJob(jobNet472);
            BenchmarkRunner.Run<Murmur3Performance>(config);
            Console.ReadLine();
        }
    }
}
