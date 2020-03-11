using Xunit;
using DesignPatterns.MidSemester;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {

            var original = "Top Score is 305";
            StringDataSource stringDataSource = new StringDataSource(original);
            var converted = stringDataSource.writeData(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new EncryptionDecorator(new CompresssionDecorator(new StringDataSource(original))).writeData(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new EncryptionDecorator(new CompresssionDecorator(new EncodeDecorator(new CompresssionDecorator(new StringDataSource(original))))).writeData(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new EncryptionDecorator(new EncodeDecorator(new CompresssionDecorator(new StringDataSource(original)))).writeData(); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
