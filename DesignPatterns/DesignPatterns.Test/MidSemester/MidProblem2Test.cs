using Xunit;
using System;
using DesignPatterns.MidSemester.Task2;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            DataSource noConversion = new DataSource(original);
            var converted = noConversion.writeData(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            EncryptionDecorator dataSource = new EncryptionDecorator(new CompresssionDecorator(new DataSource(original)));
            var converted = dataSource.writeData(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            CompresssionDecorator dataSource = new CompresssionDecorator(new EncodeDecorator(new CompresssionDecorator(new EncryptionDecorator(new DataSource(original)))));
            var converted = dataSource.writeData(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            EncryptionDecorator dataSource = new EncryptionDecorator(new EncodeDecorator(new CompresssionDecorator(new DataSource(original))));
            var converted =dataSource.writeData(); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
