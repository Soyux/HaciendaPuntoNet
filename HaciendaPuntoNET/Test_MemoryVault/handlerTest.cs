using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MemoryVault;
using System.Data;

namespace Test_MemoryVault
{
  
    public class handlerTest
    {
        private IHandler _ihandler=null;
        [SetUp]
        public void Setup()
        {
            _ihandler = new Handler();
        }

        [Test]
        public async Task isBootupUp() {
            //Arrange
            bool returnTask = await _ihandler.BootupOnMemory();
            //Act
             ConnectionState state= _ihandler.GetCurrentState();
            //Assert 
            Assert.IsTrue(state == ConnectionState.Open);
        }

        [TestCase("3454ab48-3241-4c35-a9af-530c217eda30")]
        public async Task isGetValueMemoryCorrect(string hash)
        {
            //Arrange
            await _ihandler.BootupOnMemory();
            string expectedValue = "C:\\templogs";
            string actualValue = "";
            //Act
            actualValue = await _ihandler.GetValueMemory(hash);

            //Assert
            Assert.IsTrue(expectedValue == actualValue);

            Assert.IsTrue(await _ihandler.ShutdownOnMemory());
        }

        [TestCase("3454ab48-3241-4c35-a9af-530c217eda30")]
        public async Task isGetValueColdCorrect(string hash)
        {
            //Arrange
            await _ihandler.BootupOnCold();
            
            string expectedValue = "C:\\templogs";
            string actualValue = "";
            //Act
            actualValue = await _ihandler.GetValueCold(hash);

            //Assert
            Assert.IsTrue(expectedValue == actualValue);
        }
        [TestCase]
        public async Task didShutdownOnMemory()
        {

            //Arrange
            await _ihandler.BootupOnMemory();
            //Act
            bool returnTask = await _ihandler.ShutdownOnMemory();
            //Assert

            Assert.IsTrue(returnTask);

        }//end of DidShutdownOnMemory
        
        [TestCase]
        public async Task didShutdownOnCold()
        {

            //Arrange
            await _ihandler.BootupOnCold();
            //Act
            bool returnTask = await _ihandler.ShutdownOnCold();
            //Assert

            Assert.IsTrue(returnTask);

        }//end of DidShutdownOnCold




    }//end of 
}
