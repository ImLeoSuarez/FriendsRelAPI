using HotChocolate;
using HotChocolate.Data;
using friendsrelapi.Services;
using System.Collections.Generic;

namespace friendsrelapi.Schema
{
    public class Query
    {
        public Character GetCharacter([Service]ICharacterRepository repository, string name) => repository.GetCharacter(name);

        [UseFiltering]
        [UseSorting]
        public ICollection<Friendship> GetFriends([Service] ICharacterRepository repository, string name) => repository.GetFriends(name);

        [UseFiltering]
        [UseSorting]
        public ICollection<Quote> GetQuotes([Service] ICharacterRepository repository, string name) => repository.GetQouteByCharacter(name);

        [UseFiltering]
        [UseSorting]
        public Friendship GetFriendship([Service] ICharacterRepository repository, string nameOne, string nameTwo) => repository.GetFriendShip(nameOne,nameTwo);
    }
}