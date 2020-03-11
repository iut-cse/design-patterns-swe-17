using DesignPatterns.MidSemester;
using System;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            DataFile file = new DataFile(original);
            string converted = file.Convert();// Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            File file = new DataFile(original);
            file = new Compress(file);
            file = new Encrypt(file);
            var converted = file.Convert(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            File file = new DataFile(original);
            file = new Encrypt(file);
            file = new Compress(file);
            file = new Encode(file);
            file = new Compress(file);
            var converted = file.Convert(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            File file = new DataFile(original);

            file = new Compress(file);
            file = new Encode(file);
            file = new Encrypt(file);

            var converted = file.Convert(); // do the convertion
            Assert.Equal("(top score is 3)", converted);
            //Assert.True(false);
        }
    }
}
