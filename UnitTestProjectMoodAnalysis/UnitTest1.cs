using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticeException;

namespace UnitTestProjectMoodAnalysis
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenHappyShouldReturnHappy()
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            ExceptionMood moodAnalyser = new ExceptionMood("I am in a happy Mood");//Creating a object and passing a message

            //ACT
            string actual = moodAnalyser.AnalyzeMood();
            
                //ASSERT
                Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not

        }

        [TestMethod]
        public void GivenSadShouldReturnSad()
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            ExceptionMood moodAnalyser = new ExceptionMood("I am in a sad mood");//Creating a object and passing a message

            //ACT
            string actual = moodAnalyser.AnalyzeMood();

            //ASSERT
            Assert.AreEqual(excepted, actual);//Checking wether my actual rasult and Excepted Results Matches or not

        }
        
        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenNullShouldReturnCustomNullException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be null";
            ExceptionMood moodAnalyser = new ExceptionMood(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenEmptyShouldReturnCustomEmptyException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be empty";
            ExceptionMood moodAnalyser = new ExceptionMood(string.Empty);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

    }
}
