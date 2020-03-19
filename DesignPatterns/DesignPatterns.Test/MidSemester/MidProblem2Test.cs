using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            StateSource source1 = new StateSource();
            var converted = source1.Stat(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DecoratorClass source2 = new EncryptDecorator(new CompressDecorator(new StateSource()));
            var converted = source2.Stat(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DecoratorClass source3 = new CompressDecorator(new EncodeDecorator(new CompressDecorator(new EncryptDecorator(new StateSource()))));
            var converted = source3.Stat(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
        
             
            var original = "The Game has end on score 600";
            DecoratorClass source4 = new EncryptDecorator(new EncodeDecorator(new CompressDecorator(new StateSource())));
            var converted = source4.Stat(original);
            Assert.Equal("(the game has end on score 6)", converted);
        }
    }
}
