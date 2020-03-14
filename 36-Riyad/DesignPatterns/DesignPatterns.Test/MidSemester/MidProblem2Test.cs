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
            var converted = new PlainText(original).getFile(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new EncryptedText(new CompressedText(new PlainText(original))).getFile(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new CompressedText(new EncodedText(new CompressedText(new EncryptedText(new PlainText(original))))).getFile(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            Assert.True(false);
            var original = "Top Score is 305";
            var converted = new EncryptedText(new EncodedText(new CompressedText(new PlainText(original)))).getFile(); // do the convertion
            Assert.Equal("top score is 3", converted);
        }
    }
}
