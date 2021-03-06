// Copyright (c) Dapplo and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Text;
using Xunit;

namespace Dapplo.Hash.Tests
{
    /// <summary>
    ///  Some simple tests to prove Murmur3 was correctly implemented
    /// </summary>
    public class Murmur3Tests
    {
        private static readonly uint Seed = 0x9747b28c;
        private static readonly string TestString = "The quick brown fox jumps over the lazy dog";
        private static readonly string ShortString = "S";

        [Fact]
        public void Murmur3_UTF8_Test()
        {
            var murmur3Hasher = new Murmur3(Seed);
            var testBytes = Encoding.UTF8.GetBytes(TestString);
            var hash = murmur3Hasher.CalculateHash(testBytes.AsSpan());
            Assert.Equal(0x2FA826CDu, hash);
        }

        [Fact]
        public void Murmur3_String_Test()
        {
            var murmur3Hasher = new Murmur3(Seed);

            var hash = murmur3Hasher.CalculateHash(TestString);
            Assert.Equal((uint)96102032, hash);
        }

        [Fact]
        public void Murmur3_Short_String_Test()
        {
            var murmur3Hasher = new Murmur3(Seed);

            var hash = murmur3Hasher.CalculateHash(ShortString);
            Assert.Equal((uint)3419752435, hash);
        }
    }
}
