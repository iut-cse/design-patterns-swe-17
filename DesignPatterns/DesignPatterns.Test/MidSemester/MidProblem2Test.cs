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
            Statistics test1 = new GamerStat();
            var converted = test1.statistics(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            Statistics test2 = new EncryptedText((new Compressed(new GamerStat())));
            var converted = test2.statistics(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            Statistics test3 = new Compressed(new Encoded(new Compressed(new EncryptedText(new GamersStat()))));
            var converted = test3.statistics(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            Statistics test4 = new EncryptedText(new Encoded(new Compressed(new GamersStat())));
            var converted = test4.statistics(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
