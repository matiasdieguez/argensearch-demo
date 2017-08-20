using ArgenSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArgenSearchTests
{
    [TestClass]
    public class ArgenSearchUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var persona = ArgenSearchClient.Search(23456789).Result;
            var id = persona.Data[0];

            var datos = ArgenSearchClient.Detail(id).Result;
        }
    }
}