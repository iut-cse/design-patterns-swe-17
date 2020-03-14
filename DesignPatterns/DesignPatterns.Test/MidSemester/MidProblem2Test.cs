using DesignPatterns.MidSemester.Problem_2;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            GamerData log = new plaintext(); 
            var converted = log.writeData(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            GamerData log = new plaintext();
            log = new CompressionDecorator(log);
            log = new EncryptionDecorator(log);
            var converted = log.writeData(original); ; // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            GamerData log = new plaintext();
            log = new EncryptionDecorator(log);
            log = new CompressionDecorator(log);
            log = new EncodeDecorator(log);
            log = new CompressionDecorator(log);
            var converted = log.writeData(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            GamerData log = new plaintext();
            log = new CompressionDecorator(log);
            log = new EncodeDecorator(log);
            log = new EncryptionDecorator(log);
            var converted = log.writeData(original); ; // do the convertion
            Assert.Equal("(top score is 3)", converted);
            //Assert.True(false);
        }
    }
}
