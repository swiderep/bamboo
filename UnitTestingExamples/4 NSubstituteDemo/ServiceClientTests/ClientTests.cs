using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using ServiceClient;

namespace ServiceClientTests
{
    [TestFixture]
    public class ClientTests
    {
        [TestFixture]
        public class WhenIGetTheContentAsFormatted
        {
            IService service;
            IContentFormat format;
            Client client;

            const long Identity = 12L;
            const string TestContent = "TestContent";
            const string TestContentFormatted = "<TestContent />";

            [SetUp]
            public void SetUp()
            {
                service = Substitute.For<IService>();
                service
                    .GetContent(Identity)
                    .Returns(TestContent);

                format = Substitute.For<IContentFormat>();
                format
                    .Format(Arg.Any<string>())
                    .Returns(TestContentFormatted);
                client = new Client(service, format);
            }

            [Test]
            public void ThenTheServiceLifecycleShouldBeManagedInOrder()
            {

                // Act 123
                client.GetContentFormatted(Identity);

                // Assert
                Received.InOrder(() =>
                {
                    service.Connect();
                    service.GetContent(Identity);
                    service.Dispose();
                    format.Format(TestContent);
                });
            }

            [Test]
            public void ThenTheContentIsProperlyFormatted()
            {
                // Act
                var result = client.GetContentFormatted(Identity);

                // Assert
                result.Should().Be(TestContentFormatted);
            }
        }

        [TestFixture]
        public class WhenIDisposeTheClient
        {
            [Test]
            public void ThenTheServiceShouldBeReleased()
            {
                // Arrange
                var service = Substitute.For<IService>();
                var client = new Client(service);

                // Act
                client.Dispose();

                // Assert
                service
                    .Received()
                    .Dispose();
            }
        }

        [TestFixture]
        public class WhenIGetTheServiceName
        {
            IService service;
            Client client;

            [SetUp]
            public void SetUp()
            {
                service = Substitute.For<IService>();
                client = new Client(service);
            }

            [Test]
            public void ThenTheServiceNameShouldBeReturned()
            {
                // Arrange
                const string serviceName = "ServiceName";
                service
                    .Name
                    .Returns(serviceName);

                // Act 
                var result = client.GetServiceName();

                // Assert
                result.Should().Be(serviceName);
            }

            public void ThenTheServiceShouldBeUsedToGetTheServiceNAme()
            {
                client.GetServiceName();

                var tmp = service
                            .Received()
                            .Name;
            }
        }
    }
}
