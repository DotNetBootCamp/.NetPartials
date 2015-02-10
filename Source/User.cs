using System.ComponentModel.DataAnnotations;

namespace Source
{
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
}
