using Xunit;
using GenerateQR;

namespace GenerateQR.Tests
{
    public class QRGeneratorTests
    {
        [Fact]
        public void Generate_ShouldReturnCorrectQRCode()
        {
            string input = "Test";
            string expected = "QR:Test";

            string result = QRGenerator.Generate(input);

            Assert.Equal(expected, result);
        }
    }
}
