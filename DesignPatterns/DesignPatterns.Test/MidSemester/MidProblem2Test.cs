using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            var converted = new PlainText().Convert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted =new EncryptText(new CompressText(new PlainText())).Convert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted =new CompressText(new EncodeText(new CompressText(new EncryptText(new PlainText())))).Convert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new EncryptText(new EncodeText(new CompressText(new PlainText()))).Convert(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
            // TODO: Implement this;
            //Assert.True(false);
        }
    }
}
