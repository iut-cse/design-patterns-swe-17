using Xunit;
using DesignPatterns.MidSemester;
namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            // Do the "No Change" conversion.
            var original = "Top Score is 305";
            Data file = new Data(original);
            string converted = file.Convert();
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            // compress then encryppt.
            var original = "Top Score is 305";
            Info file = new Data(original);
            file = new Compressed(file);
            file = new Encryption(file);
            var converted = file.Convert(); 
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            // do the convertion
            var original = "Top Score is 305";
            Info file = new Data(original);
            file = new Encryption(file);
            file = new Compressed(file);
            file = new Encoding(file);
            file = new Compressed(file);
            var converted = file.Convert(); 
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            Info file = new Data(original);

            file = new Compressed(file);
            file = new Encoding(file);
            file = new Encryption(file);

            var converted = file.Convert(); // do the convertion
            Assert.Equal("(top score is 3)", converted);
            //Assert.True(false);
        }
    }
}
