using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using Source;

namespace Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void CheckIfFavouritePetIsRequired()
        {
            var user = new User
            {
                DateCreatedUtc = DateTime.UtcNow,
                IsActive = true,
                LastLoggedInUtc = DateTime.UtcNow,
                Name = "Potato",
                UserId = 32,
                Username = "ThePotato",
                SomeDescription = "The example description"
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user, null, null);
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(User), typeof(User.UserMetadata)), typeof(User));

            var isValid = Validator.TryValidateObject(user, context, results, validateAllProperties: true);
            Assert.False(isValid);
            CollectionAssert.IsNotEmpty(results);
        }
    }
}