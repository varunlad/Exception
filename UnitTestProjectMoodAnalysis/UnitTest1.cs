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
        public void GivenSadShouldReturnHappy()
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
       
    }
}
