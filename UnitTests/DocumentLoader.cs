using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using netDxf;
using static UnitTesting.Toolkit;

namespace UnitTesting
{
    [TestClass]
    public class DocumentLoader
    {

        [TestMethod]
        public void TestTriangle()
        {
            var testfilename = "TriangleAC1015Libre.dxf";
            
            try
            {
                var dxf = DxfDocument.Load(TestAsset(testfilename), DxfLoaderOptions.None);

                Assert.Fail("should generate an exception");
            }
            catch
            {                
            }

            try
            {
                var dxf = DxfDocument.Load(TestAsset(testfilename));
            }
            catch
            {
                Assert.Fail("no exceptions expected");
            }
        }

    }
}