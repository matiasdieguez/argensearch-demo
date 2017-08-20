using ArgenSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgenSearchTests
{
    [TestClass]
    public class ArgenSearchUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var persona = ArgenSearchClient.Search(123456).Result;
            var id = persona.Data[0];
            Assert.IsTrue(persona.Success);

            var datos = ArgenSearchClient.Detail(id).Result;
            Assert.IsTrue(datos.Success);
        }
    }
}