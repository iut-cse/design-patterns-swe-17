using DesignPatterns.MidSemester.problem2;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            var converted = new NoConversion(original).GetString(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new EncryptConversion(new CompressConversion(new NoConversion( original))).GetString();// compress then encryppt.
            
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted =new CompressConversion (new EncodeConversion (new CompressConversion(new EncryptConversion(new NoConversion(original))))).GetString(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            var converted = new EncryptConversion(new EncodeConversion(new CompressConversion(new NoConversion(original)))).GetString();
            Assert.Equal("(top score is ", converted);


        }
    }
}
