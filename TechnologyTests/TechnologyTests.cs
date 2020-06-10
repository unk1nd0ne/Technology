using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        Computer test_computer;
        Laptop test_laptop;
        Smartphone test_smartphone; 

        [TestInitialize]
        public void InitializeComponents()
        {
            test_computer = new Computer("x86", 500, 500.00, "Windows 10");
            test_laptop = new Laptop("x86", 300, 400.00, "MacOS");
            test_smartphone = new Smartphone("arm", 100, 32.00, "Android");
        }

        [TestMethod]
        public void TestComputerID()
        {
            Assert.AreEqual(10, test_computer.componentID);

        }
        [TestMethod]
        public void TestLaptopID()
        {

            Assert.AreEqual(14, test_laptop.componentID);
        }

        [TestMethod]
        public void TestSmartphoneID()
        {

            Assert.AreEqual(24, test_smartphone.componentID);
        }

        [TestMethod]
        public void TestBootComputer()
        {
            Assert.AreEqual("Welcome to Windows 10!", test_computer.Boot());
        }

        [TestMethod]
        public void TestStorePictureTooBig()
        {

            Assert.AreEqual("Picture, lakehouse.jpg too large to store", test_computer.StorePicture("lakehouse.jpg", 600.00));
        }

        [TestMethod]
        public void TestStorePicture()
        {

            Assert.AreEqual("Picture, lakehouse.jpg saved", test_computer.StorePicture("lakehouse.jpg", 28.00));
        }

        [TestMethod]
        public void TestBootLaptop()
        {
            Assert.AreEqual("Welcome to MacOS!", test_laptop.Boot());
        }

        [TestMethod]
        public void TestLaptopRunProgramNotConnected()
        {
            Assert.IsFalse(test_laptop.IsConnected);
            Assert.AreEqual("Program zoom, cannot connect. Please connect to wifi and try again!", test_laptop.RunProgram("zoom"));
        }

        [TestMethod]
        public void TestLaptopRunProgramConnected()
        {
            Assert.IsFalse(test_laptop.IsConnected);
            test_laptop.Connect();
            Assert.IsTrue(test_laptop.IsConnected);
            Assert.AreEqual("Program zoom, running!", test_laptop.RunProgram("zoom"));
        }

        [TestMethod]
        public void TestBootSmartphone()
        {
            Assert.AreEqual("Welcome to Android!", test_smartphone.Boot());
        }

        [TestMethod]
        public void TestStorePictureTooBigSmartphone()
        {

            Assert.AreEqual("lakehouse.jpg: not enough space for your duck face", test_smartphone.StorePicture("lakehouse.jpg", 600.00));
        }

        [TestMethod]
        public void TestStorePictureSmartphone()
        {

            Assert.AreEqual("lakehouse.jpg: looking good, have you been working out?", test_smartphone.StorePicture("lakehouse.jpg", 28.00));
            Assert.AreEqual(test_smartphone.FreeSpace, 4.00, 0.001);
        }

        
    }
}
