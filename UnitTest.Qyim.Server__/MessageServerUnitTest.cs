using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Nega.Common;
using Nega.Entlib;

using Qyim.Server;

namespace UnitTest.Qyim.Server__
{
    [TestClass]
    public class MessageServerUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LogManager.Factory = new Nega.Entlib.LoggerFactoryImpl();

            MessageServer server = new MessageServer();
            server.Initialize();
            Assert.IsTrue(server.IsInitialized);
            server.Destroy();
            Assert.IsFalse(server.IsInitialized);
        }
    }
}
