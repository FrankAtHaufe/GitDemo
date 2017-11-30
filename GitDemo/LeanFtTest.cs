using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.WinForms;
using System.Drawing;
using System.Windows.Forms;
using LogeAppModel;
using System.Configuration;

namespace GitDemo
{
    [TestFixture]
    public class LeanFtTest : UnitTestClassBase
    {
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
             // Before each test
        }

        [Test]
        public void Test()
        {
            //MessageBox.Show("Yeppee, Unit Test is running fine...");
            var x = new LogeAppModel.ClassStandardDialog();
            //supi DEV g

        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
