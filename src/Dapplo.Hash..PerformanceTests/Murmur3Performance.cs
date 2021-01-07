// Copyright (c) Dapplo and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

namespace Dapplo.Hash.PerformanceTests
{
    /// <summary>
    /// This defines the benchmarks which can be done
    /// </summary>
    [MinColumn, MaxColumn, MemoryDiagnoser]
    public class Murmur3Performance
    {
        private static readonly string TestString = "The quick brown fox jumps over the lazy dog";
        private static readonly Murmur3 Murmur3Hasher = new Murmur3(0x9747b28c);

        [Benchmark]
        public void MurmurPerformanceTest()
        {
            var hash = Murmur3Hasher.CalculateHash(TestString);
        }
    }
}
