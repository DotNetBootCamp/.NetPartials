# .NetPartials

Take a look at the file **Generated.tt** and its output file **Generated.cs**.
The code in the .tt file uses the helper classes from the **T4Helpers** Project in order to generate classes that we could use at a later stage to access our database. This is a very simplified example of what EntityFramework Database first does.

You will notice that the .cs file contains a User class, this has been generated directly based off of what our database schema was. It contains the [Required] attribute over the properties that the database requires. But what if we would like to add some extra properties to our user class that are specific to our application but which don't necessarily get persisted to the database.

Well we could make a new User class in a different namespace and map the properties across or add the db user object as a property on that:

	namespace DomainObjects
	{
		public class User
		{
			public Database.User User { get; set;}
			public bool IsActive { get; set; }
		}
	}

But this becomes cumbersome very quickly. Luckily we have partials and can do the following.
The generated.cs file:

	namespace Database
	{
		public partial class User
	    {
	        [Required]
	        public int UserId { get; set;}
	        [Required]
	        public string Name { get; set;}
	        [Required]
	        public string Username { get; set;}
	        [Required]
	        public int TimesLoggedIn { get; set;}
	        [Required]
	        public DateTime DateCreatedUtc { get; set;}
	        public DateTime? LastLoggedInUtc { get; set;}
	        public Pet FavouritePet { get; set;}
	    }
	}
Our extension of the user object in User.cs:

	namespace Database
	{
		public partial class User
		{
			public bool IsActive { get; set; }
		}
	}
When the compiler runs, it will stitch the two files together to make one complete class. For this reason, all the parts of the partial must be within the same Project. You can use as many parts as you like, it's not limited to just two files.

But what if we would like to add the [Required] Attribute manually to an auto generated property? We could do the following:

	[MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public bool IsActive { get; set; }

        internal sealed class UserMetadata
        {
            // Metadata classes are not meant to be instantiated.
            private UserMetadata()
            {
            }

            [Required]
            public Pet FavouritePet;
        }
    }

## Excercise ##

1. Update the Pet class that comes from the "Database" to have an enum to store the type, there should be at least 3 different types of pets
2. Update the name of the pet to have a minimum length of 1 and a maximum length of 16