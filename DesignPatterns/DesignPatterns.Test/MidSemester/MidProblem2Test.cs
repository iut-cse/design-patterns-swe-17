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
            IStatistics player1 = new GamersStatistics(); 
            var converted = player1.statistics(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics player2 = new EncryptionDecorator(new CompressionDecorator(new GamersStatistics()));
            var converted = player2.statistics(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics player3 = new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new GamersStatistics()))));
            var converted = player3.statistics(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics player4 = new EncryptionDecorator(new EncodingDecorator(new CompressionDecorator(new GamersStatistics())));
            var converted = player4.statistics(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
