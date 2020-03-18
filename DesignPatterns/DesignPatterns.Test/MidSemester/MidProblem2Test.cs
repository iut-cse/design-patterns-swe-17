using DesignPatterns.MidSemester.Problem_2;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IStatistics player = new Statistics();
            var converted = player.statistics(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics player1 = new EncryptionDecorator(new CompressionDecorator(new Statistics()));
            var converted = player1.statistics(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics player2 = new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new Statistics())))); // do the convertion
            var converted = player2.statistics(original);
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            IStatistics player3 = new EncryptionDecorator(new EncodingDecorator(new CompressionDecorator(new Statistics())));
            var converted = player3.statistics(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
