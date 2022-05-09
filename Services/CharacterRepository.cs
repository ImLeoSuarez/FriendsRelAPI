using friendsrelapi.Schema;
using System.Collections.Generic;
using System.Linq;

namespace friendsrelapi.Services
{
    public class CharacterRepository : ICharacterRepository
    {
        public Character GetCharacter(string characName)
        {
            return GetCharacters().Where(i => i.name == characName).FirstOrDefault();
        }

        public FriendshipStatus GetStatus(string status)
        {
            return (new List<FriendshipStatus>()
            {
                new FriendshipStatus{ statusname = "Just friends" },
                new FriendshipStatus{ statusname = "Dating secretly" },
                new FriendshipStatus{ statusname = "Dating openly" },
                new FriendshipStatus{ statusname = "Married" },
                new FriendshipStatus{ statusname = "On a break" }
            }).Find(x=>x.statusname==status);
        }

        public List<Quote> GetQouteByCharacter(string characName)
        {
            return ( new List<Quote>()
            {
                new Quote{character="Joey", quote="Here come the meat sweats."},
                new Quote{character="Monica", quote="Guys can fake it? Unbelievable! The one thing that’s ours!"},
                new Quote{character="Ross", quote="Pivot! Pivot! Pivot! Pivot! Pivot!"},
                new Quote{character="Phoebe", quote="This is brand-new information!"},
                new Quote{quote="It's a moo point. It's like a cow's opinion; it doesn't matter. It's moo.",character="Joey"},
                new Quote{quote="Phoebe. That's P, as in Phoebe, H as in hoebe, O as in oebe, E as in ebe, B as in bebe, and E as in 'Ello there mate.",character="Phoebe"},
                new Quote{quote="Smelly cat, smelly cat, what are they feeding you? Smelly cat, smelly cat, it's not your fault.",character="Phoebe"},
                new Quote{quote="I grew up in a house with Monica, okay. If you didn't eat fast, you didn't eat.",character="Ross"},
                new Quote{quote="I got off the plane.",character="Rachel"},
                new Quote{quote="How you doin?",character="Joey"},
                new Quote{quote="Joey doesn't share food!",character="Joey"},
                new Quote{quote="We were on a break!",character="Ross"},
                new Quote{quote="Unagi.",character="Ross"},
                new Quote{quote="I'm not so good with the advice. Can I interest you in a sarcastic comment?",character="Chandler"},
                new Quote{quote="But they don't know that we know they know we know!",character="Phoebe"},
                new Quote{quote="Look at me! I'm Chandler! Could I be wearing any more clothes?!",character="Joey"},
                new Quote{quote="Just so you know, it's not that common, it doesn't happen to every guy, and it is a big deal!",character="Rachel"}
            }).FindAll(x=>x.character == characName);
        }

        public Friendship GetFriendShip(string nameOne, string nameTwo)
        {
           return GetFriendlist().Find(x=>(x.CharacterOne.name==nameOne && x.CharacterTwo.name==nameTwo) || 
           (x.CharacterOne.name==nameTwo && x.CharacterTwo.name==nameOne));
        }

        public List<Friendship> GetFriends(string name)
        {
           return GetFriendlist().FindAll(x=>x.CharacterOne.name==name || x.CharacterTwo.name==name);
        }

        public List<Friendship> GetFriendlist()
        {
            return (new List<Friendship>(){
                new Friendship(){
                    CharacterOne = new Character{ name="Ross" },
                    CharacterTwo = new Character{ name="Emily" },
                    status = GetStatus("Married"),
                },
                new Friendship(){
                    CharacterOne = new Character{ name="Ross" },
                    CharacterTwo = new Character{ name="Chandler" },
                    status = GetStatus("Just Friends"),
                },
                new Friendship(){
                    CharacterOne = new Character{ name="Chandler" },
                    CharacterTwo = new Character{ name="Monica" },
                    status = GetStatus("On a break"),
                },
                new Friendship(){
                    CharacterOne = new Character{ name="Phoebe" },
                    CharacterTwo = new Character{ name="Joey" },
                    status = GetStatus("Just Friends"),
                },
                new Friendship(){
                    CharacterOne = new Character{ name="Rachel" },
                    CharacterTwo = new Character{ name="Joey" },
                    status = GetStatus("Dating secretly"),
                }
            });
        }
        public List<Character> GetCharacters()
        {
            return new List<Character>()
            {
                new Character() { name = "Ross" },
                new Character() { name = "Monica" },
                new Character() { name = "Chandler" },
                new Character() { name = "Rachel" },
                new Character() { name = "Phoebe" },
                new Character() { name = "Joey" }
            };
        }
    }
}
