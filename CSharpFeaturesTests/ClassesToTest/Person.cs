using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesTests.ClassesToTest
{
    public class Person
    {
        public string FirstName { get; } = "Bob";
        public string LastName { get; } = "Barker";
        public static int DefaultAge { get; } = 12;
        public string FullName => (FirstName == "Garrett") ? $"Joshua {FirstName} {LastName}" : $"{FirstName} {LastName}";
        public List<string> Errors { get; set; } = new List<string>();

        public Person() {}
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;            
        }

        public void GetSuffixed(string suffix, out string suffixed) {
            suffixed = $"{FullName}, {suffix}";
        }

        public bool IsFirstNameExcept(string fName)
        {
            try
            {
                throw new Exception($"First Name is {FirstName}.");
            }
            catch (Exception ex) when (ex.Message.Contains(fName))
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Will throw an error if FirstName is "Marvin"
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetFullNameAsync()
        {
            try
            {
                return await _getFullNameAsync();
            }
            catch (Exception ex)
            {
                await _logErrorAsync(ex.Message);
                return string.Empty;
            }
        }

        private async Task<string> _getFullNameAsync() {
            if (FirstName == "Marvin") throw new Exception("Not Marvin!");
            return FullName;
        }

        private async Task _logErrorAsync(string errMessage)
        {
            Errors.Add(errMessage);
        } 
    }
}
