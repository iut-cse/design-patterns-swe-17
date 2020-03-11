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

            DataDecorator plain = new Decorator(original);
            string converted = plain.getData(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";

            DataDecorator pl = new Decorator(original);

            pl = new CompressionDecorator(pl);
            pl = new EncryptionDecorator(pl);
            string converted =pl.getData(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";

            DataDecorator pl = new Decorator(original);

            pl = new EncryptionDecorator(pl);
            pl = new CompressionDecorator(pl);
            pl = new EncodeDecorator(pl);
            pl = new CompressionDecorator(pl);
            var converted = pl.getData(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";

            DataDecorator pl = new Decorator(original);

            pl = new CompressionDecorator(pl);
            pl = new EncodeDecorator(pl);
            pl = new EncryptionDecorator(pl);
            string converted = pl.getData(); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
