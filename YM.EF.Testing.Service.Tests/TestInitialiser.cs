using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YM.EF.Testing.Service.Tests
{
    [TestClass]
    public class TestInitialiser
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }
}
