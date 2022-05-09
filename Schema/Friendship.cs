namespace friendsrelapi.Schema
{
    public class Friendship
    {
        public Character CharacterOne { get; set; }
        public Character CharacterTwo { get; set; }
        public FriendshipStatus status { get; set; }
    }
}