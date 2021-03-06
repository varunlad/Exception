using Exception058;
using MoodAnlyzesUnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnlyzerUnitTesting
{
    [TestClass]

    public class MsTestForMoodAnalyzer
    {
        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenNullShouldReturnCustomNullException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be null";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmptyShouldReturnCustomEmptyException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be empty";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(string.Empty);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

        /// <summary>
        /// UC-4 Create Default Constructor Using Reflection
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_defaultConstructor()
        {
            MoodAnalyzer excepted = new MoodAnalyzer();
            object obj = null;
            try
            {
                //ACT
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                obj = factory.CreatMoodAnalyzerObject("Exception058.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }
            obj.Equals(excepted);
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_Exception()
        {
            string excepted = "constructor not found";
            object obj = null;
            try
            {
                //ACT
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                obj = factory.CreatMoodAnalyzerObject("Exception058.MoodAnalyzer", "MoodAnal");
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted,execption.Message);
            }
            
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_ClassException()
        {
            string excepted = "class not found";
            object obj = null;
            try
            {
                //ACT
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                obj = factory.CreatMoodAnalyzerObject("Exception058.EmployeeWage", "EmployeeWage");
            }
            catch (CustomMoodAnalyzerException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }

        }
    }
}

