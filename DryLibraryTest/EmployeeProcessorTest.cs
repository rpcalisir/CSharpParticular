using DryLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DryLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("timothy", "corey", "timocore")]
        [InlineData("tim", "corey", "timcore")]
        [InlineData("tim", "co", "timco")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            //Arrange
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();

            //Act
            string actualStart = employeeProcessor.GenerateEmployeeId(firstName, lastName).Substring(0, expectedStart.Length);

            //Assert
            Assert.Equal(actualStart, expectedStart);
        }
    }
}
