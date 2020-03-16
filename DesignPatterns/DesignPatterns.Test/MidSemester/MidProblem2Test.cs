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
            DataSource dataSource = new FileDataSource(original);
            dataSource.writeData(original);
            var converted = dataSource.readData(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var data = new CompressDecorator((new FileDataSource(original)));
            data.writeData(original);
            var data2 = new EncryptionDecorator(data);
            data2.writeData(data.readData());
            var converted = data2.readData(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            
            var original = "Top Score is 305";
            var data = new EncryptionDecorator(new FileDataSource(original));
            data.writeData(original);
            var data2 = new CompressDecorator(data);
            data2.writeData(data.readData());
            var data3 = new EncodeDecorator(data2);
            data3.writeData(data2.readData());
            var data4 = new CompressDecorator(data3);
            data4.writeData(data3.readData());
            var converted = data4.readData(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            var data = new CompressDecorator(new FileDataSource(original));
            data.writeData(original);
            var data2 = new EncodeDecorator(data);
            data2.writeData(data.readData());
            var data3 = new EncryptionDecorator(data2);
            data3.writeData(data2.readData());
            var converted = data3.readData();
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
