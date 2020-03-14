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
            IScoreConversion score1 = new GameScore();
            var converted = score1.ScoreConvert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IScoreConversion score2 = new Encryption(new Compression(new GameScore()));
            var converted = score2.ScoreConvert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IScoreConversion score3 = new Compression(new Encoding(new Compression(new Encryption(new GameScore()))));
            var converted = score3.ScoreConvert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IScoreConversion score4 = new Encryption(new Compression(new Encoding(new GameScore())));
            var converted = score4.ScoreConvert(original); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
