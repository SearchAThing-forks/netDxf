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
                var dxf = DxfDocument.Load(TestAsset(testfilename));

                Assert.Fail("should generate DebugAssertException");
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name != "DebugAssertException")
                    Assert.Fail("should generate DebugAssertException");
            }

            try
            {
                var dxf = DxfDocument.Load(TestAsset(testfilename),
                    DxfLoaderOptions.ChunkValueEmptyStringAsZero |
                    DxfLoaderOptions.ChunkValueStringStandardAsZero
                    );
            }
            catch
            {
                Assert.Fail("no exceptions expected");
            }
        }

    }
}