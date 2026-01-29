using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetPortal;
using System;
using System.Collections.Generic;

namespace TEST_PetPortal
{
    /// <summary>
    /// Filename: TestFile.cs
    /// Part of Project: TEST_PetPortal
    /// 
    /// File Purpose:
    /// This file contains the unit tests for the ProgramFile class located
    /// in the main PetPortal project. These tests verify that all logic and
    /// calculations perform correctly under normal and exceptional conditions.
    /// 
    /// Test Project Purpose:
    /// The purpose of this project is to ensure software quality by validating
    /// the correctness of individual methods. Unit testing helps detect errors
    /// early and ensures that updates to the program do not break existing
    /// functionality.
    /// </summary>
    [TestClass]
    public class TestFile
    {
        private ProgramFile portal = null!;


        /// <summary>
        /// This method runs before each test to create a fresh instance
        /// of the ProgramFile class.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            portal = new ProgramFile();
        }

        // TEST METHODS -- TEST METHODS -- TEST METHODS -- TEST METHODS
        // TEST METHODS -- TEST METHODS -- TEST METHODS -- TEST METHODS

        /// <summary>
        /// Tests squaring a number.
        /// </summary>
        [TestMethod]
        public void SquareNumber_Input4_Returns16()
        {
            Assert.AreEqual(16, portal.SquareNumber(4));
        }

        /// <summary>
        /// Tests addition of two numbers.
        /// </summary>
        [TestMethod]
        public void AddNumbers_2and3_Returns5()
        {
            Assert.AreEqual(5, portal.AddNumbers(2, 3));
        }

        /// <summary>
        /// Tests normal division.
        /// </summary>
        [TestMethod]
        public void DivideNumbers_10by2_Returns5()
        {
            Assert.AreEqual(5, portal.DivideNumbers(10, 2));
        }

        /// <summary>
        /// Ensures division by zero throws an exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideNumbers_ByZero_ThrowsException()
        {
            portal.DivideNumbers(5, 0);
        }

        /// <summary>
        /// Tests pet name formatting.
        /// </summary>
        [TestMethod]
        public void GetFullPetName_ReturnsFormattedName()
        {
            Assert.AreEqual("Buddy the Dog", portal.GetFullPetName("Buddy", "Dog"));
        }

        /// <summary>
        /// Tests long name detection.
        /// </summary>
        [TestMethod]
        public void IsNameLong_LongName_ReturnsTrue()
        {
            Assert.IsTrue(portal.IsNameLong("SirBarksALot"));
        }

        /// <summary>
        /// Tests short name detection.
        /// </summary>
        [TestMethod]
        public void IsNameLong_ShortName_ReturnsFalse()
        {
            Assert.IsFalse(portal.IsNameLong("Max"));
        }

        /// <summary>
        /// Tests pet age category logic.
        /// </summary>
        [TestMethod]
        public void GetPetAgeCategory_Age5_ReturnsAdult()
        {
            Assert.AreEqual("Adult", portal.GetPetAgeCategory(5));
        }

        /// <summary>
        /// Ensures negative age throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetPetAgeCategory_NegativeAge_ThrowsException()
        {
            portal.GetPetAgeCategory(-1);
        }

        /// <summary>
        /// Tests counting pets in a list.
        /// </summary>
        [TestMethod]
        public void GetTotalPets_ReturnsCorrectCount()
        {
            var pets = new List<string> { "Max", "Bella", "Charlie" };
            Assert.AreEqual(3, portal.GetTotalPets(pets));
        }

        /// <summary>
        /// Tests searching for a pet in a list.
        /// </summary>
        [TestMethod]
        public void PetExists_ExistingPet_ReturnsTrue()
        {
            var pets = new List<string> { "Max", "Bella" };
            Assert.IsTrue(portal.PetExists(pets, "Bella"));
        }

        /// <summary>
        /// Tests average age calculation.
        /// </summary>
        [TestMethod]
        public void GetAverageAge_ValidList_ReturnsAverage()
        {
            var ages = new List<int> { 2, 4, 6 };
            Assert.AreEqual(4, portal.GetAverageAge(ages));
        }
    }
}
