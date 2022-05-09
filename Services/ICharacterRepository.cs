using friendsrelapi.Schema;
using System.Collections.Generic;
using System.Linq;

namespace friendsrelapi.Services
{
    public interface ICharacterRepository
    {
        Character GetCharacter(string characName);
        List<Quote> GetQouteByCharacter(string characName);
        FriendshipStatus GetStatus(string status);
        Friendship GetFriendShip(string nameOne, string nameTwo);
        List<Friendship> GetFriends(string name);
    }
}