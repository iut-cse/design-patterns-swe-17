using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            DataSource ds1=new PlainTextFile();
            var converted = ds1.conversion(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource ds2 =new EncryptionDecorator(new CompressDecorator(new PlainTextFile()));
            var converted = ds2.conversion(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DataSource ds3 =new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new PlainTextFile()))));
            var converted = ds3.conversion(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            //Assert.True(false);
            var original = "Top Score is 305";
            DataSource ds4 =new EncryptionDecorator (new EncodingDecorator(new CompressionDecorator(new PlainTextFile())));
            var converted = ds4.conversion(original); // do the convertion
            Assert.Equal("(top score is ", converted);

        }
    }
}
