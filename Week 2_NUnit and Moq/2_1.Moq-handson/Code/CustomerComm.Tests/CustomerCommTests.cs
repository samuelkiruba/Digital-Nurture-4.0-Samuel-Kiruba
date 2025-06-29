using CustomeComms;
using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomeComms.Tests
{
    [TestFixture]
    public class CustomeCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomeComm _customeComm;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            _customeComm = new CustomeComm(_mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailSentSuccessfully()
        {
            bool result = _customeComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
