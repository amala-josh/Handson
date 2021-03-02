using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;



namespace CustomerCom.Tests
{
    [TestFixture]
    public class CustomerTest
    {
        Mock<IMailSender> mock;
        CustomerComm obj;

        [Test]
        [TestCase("jeyaraj@gmail.com", "jai", true)]
        public void OneTimeSetUp(string toaddress, string name, bool expected)

        {
            mock = new Mock<IMailSender>();

            mock.Setup(p => p.SendMail(toaddress, name)).Returns(expected);
            obj = new CustomerComm(mock.Object);

            bool actual = obj.SendMailToCustomer("aaab@gmail.com", name);
            Assert.AreEqual(expected, actual);
        }
    }
}
