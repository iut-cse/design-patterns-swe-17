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
            DataConvertor d1 = new DataStore();
            var converted = d1.DataConvert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DataConvertor d2 = new Compress(new Encrypt(new DataStore()));
            var converted = d2.DataConvert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DataConvertor d3 = new Encrypt(new Compress(new Encode(new Compress(new DataStore()))));
            var converted = d3.DataConvert(original); // encrypt then compress then encode then compress
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            DataConvertor d4 = new Compress(new Encode(new Encrypt(new DataStore())));
            var converted = d4.DataConvert(original); // compress then encode and then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }

    }
}
