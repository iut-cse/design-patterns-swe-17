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
            // Do the "No Change" conversion.
            StringDataSource stringDataSource = new StringDataSource(original);
            var converted = stringDataSource.writeData();
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            //var converted = ""; // compress then encryppt.
            var converted = new EncryptionDecorator(new CompresssionDecorator(
                new StringDataSource(original))).writeData();
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new EncryptionDecorator(new CompresssionDecorator(
                new EncodeDecorator(new CompresssionDecorator(
                    new StringDataSource(original))))).writeData();
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            var converted = new EncryptionDecorator(new EncodeDecorator(new CompresssionDecorator(new StringDataSource(original)))).writeData(); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
