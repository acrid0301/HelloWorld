using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNanoHelloApi;
using RNanoHelloApi.Controllers;
using Moq;
using RNanoHelloApi.Repositories;
using RNanoHello.Model;
using System.Threading.Tasks;
using System;
using System.Web.Http.Results;

namespace RNanoHelloApi.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        private Mock<IRepository<MessageModel>> helloRepository;

        [TestInitialize]
        public void SetUp()
        {
            helloRepository = new Mock<IRepository<MessageModel>>();
        }

        
        [TestMethod]
        public async Task Get_Returns_Message()
        {
            //Arrange   
            var fakeMessage = GetNotifyMessage();
            helloRepository.Setup(x => x.GetNofity()).Returns(fakeMessage);

            HelloController controller = new HelloController(helloRepository.Object);

            //Act
            var message = controller.GetNotify();

            //Assert
            var negotiatedResult = message as OkNegotiatedContentResult<MessageModel>;
            Assert.IsNotNull(negotiatedResult, "Message result is null");
            Assert.IsInstanceOfType(negotiatedResult.Content, typeof(MessageModel), "Wrong Model");
        }

       
        private static MessageModel GetNotifyMessage()
        {
            return new MessageModel() { Id = Guid.NewGuid(), Message = "Hello World" };
        }
    }
}
