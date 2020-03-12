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
            IStatistics unchanged = new PlainText(); 
            var converted = unchanged.conversion(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics compressThenEncrypt = new Encryption(new Compression(new PlainText()));
            var converted = compressThenEncrypt.conversion(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics complex = new Compression(new Encoding(new Compression(new Encryption(new PlainText()))));
            var converted = complex.conversion(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            IStatistics compressThenEncodeThenEncrypt = new Encryption(new Encoding(new Compression(new PlainText())));
            var converted = compressThenEncodeThenEncrypt.conversion(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
            
        }
    }
}
