using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IDatasource file=new PlainText();
            var converted = file.Conversion(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IDatasource file = new Encryption(new Compression(new PlainText()));
            var converted = file.Conversion(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IDatasource file = new Compression(new Encoding(new Compression(new Encryption(new PlainText()))));
            var converted = file.Conversion(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            //Assert.True(false);
            var original = "Top Score is 305";
            IDatasource file = new Encryption(new Encoding(new Compression(new PlainText())));
            var converted = file.Conversion(original);
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
