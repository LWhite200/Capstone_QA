namespace PetPortal
{
    /// <summary>
    /// Filename: ProgramFile.cs
    /// Part of Project: PetPortal
    /// 
    /// File Purpose:
    /// This file contains a support class that provides various utility-style
    /// methods used throughout the PetPortal system. These methods include
    /// mathematical calculations, string formatting, pet age classification,
    /// and collection-based operations.
    /// 
    /// Program Purpose:
    /// The purpose of the PetPortal program is to simulate basic logic that
    /// might be used in a pet management system. The methods in this file
    /// provide logic that can be unit tested to ensure correctness of core
    /// operations such as calculations, decision-making, and data processing.
    /// This file is heavily used by the QA test project to validate behavior.
    /// </summary>
    public class ProgramFile
    {
        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS
        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS
        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS

        /// <summary>
        /// This function returns the square of a number.
        /// </summary>
        /// <param name="number"> The integer value to be multiplied by itself </param>
        /// <returns> int - The squared result </returns>
        public int SquareNumber(int number)
        {
            return number * number;
        }

        /// <summary>
        /// This function adds two integers together.
        /// </summary>
        /// <param name="a"> First integer </param>
        /// <param name="b"> Second integer </param>
        /// <returns> int - The sum of the two integers </returns>
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// This function divides one number by another.
        /// </summary>
        /// <param name="a"> Dividend </param>
        /// <param name="b"> Divisor </param>
        /// <returns> int - Result of the division </returns>
        /// <exception cref="DivideByZeroException">Thrown when divisor is zero</exception>
        public int DivideNumbers(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }

        /// <summary>
        /// This function combines a pet's name and type into a formatted string.
        /// </summary>
        /// <param name="name"> The pet's name </param>
        /// <param name="type"> The type of animal </param>
        /// <returns> string - A formatted pet description </returns>
        public string GetFullPetName(string name, string type)
        {
            return $"{name} the {type}";
        }

        /// <summary>
        /// This function determines whether a pet name is considered long.
        /// </summary>
        /// <param name="name"> The pet's name </param>
        /// <returns> bool - True if name length is greater than 8 characters </returns>
        public bool IsNameLong(string name)
        {
            return name.Length > 8;
        }

        /// <summary>
        /// This function categorizes a pet based on age.
        /// </summary>
        /// <param name="age"> Age of the pet </param>
        /// <returns> string - "Baby", "Adult", or "Senior" </returns>
        /// <exception cref="ArgumentException">Thrown when age is negative</exception>
        public string GetPetAgeCategory(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age cannot be negative.");

            if (age <= 2)
                return "Baby";
            else if (age <= 7)
                return "Adult";
            else
                return "Senior";
        }

        /// <summary>
        /// This function returns the total number of pets in a list.
        /// </summary>
        /// <param name="pets"> A list of pet names </param>
        /// <returns> int - Total number of pets </returns>
        public int GetTotalPets(List<string> pets)
        {
            return pets.Count;
        }

        /// <summary>
        /// This function checks whether a pet exists in a list.
        /// </summary>
        /// <param name="pets"> List of pet names </param>
        /// <param name="name"> Name to search for </param>
        /// <returns> bool - True if pet exists in the list </returns>
        public bool PetExists(List<string> pets, string name)
        {
            return pets.Contains(name);
        }

        /// <summary>
        /// This function calculates the average age of pets.
        /// </summary>
        /// <param name="ages"> List of pet ages </param>
        /// <returns> double - Average age </returns>
        /// <exception cref="ArgumentException">Thrown when list is empty</exception>
        public double GetAverageAge(List<int> ages)
        {
            if (ages.Count == 0)
                throw new ArgumentException("Age list cannot be empty.");

            double total = 0;
            foreach (int age in ages)
                total += age;

            return total / ages.Count;
        }
    }
}
