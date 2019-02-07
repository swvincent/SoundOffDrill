using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundOffDrill.Extensions.List;

namespace SoundOffDrill.Biz
{
    class Dealer
    {
        public SortedDictionary<DeckPosition, Deck> BuildDecks(List<Card> cards)
        {
            // Create decks starting with cards that have a definite place.
            var decks = new SortedDictionary<DeckPosition, Deck>
            {
                {
                    DeckPosition.Begin,
                    new Deck(
                        cards.Where(c => c.SoundPosition == SoundPosition.Begin ||
                            c.SoundPosition == SoundPosition.Both).ToList())
                },

                // Middle cards (Vowels)
                {
                    DeckPosition.Middle,
                    new Deck(
                        cards.Where(c => c.SoundPosition == SoundPosition.Middle).ToList())
                },

                // End gets ending sounds and sounds that go in both.
                {
                    DeckPosition.End,
                    new Deck(
                        cards.Where(c => c.SoundPosition == SoundPosition.End ||
                            c.SoundPosition == SoundPosition.Both).ToList())
                }
            };

            // Remaining sounds are either/or and must be split betweeen Beginning and End.
            List<Card> eitherOrSounds = cards
                .Where(c => c.SoundPosition == SoundPosition.EitherOr)
                .ToList();

            // Use Shuffle extension to randomize then
            // distribute to make both lists same qty
            eitherOrSounds.Shuffle();

            foreach (var card in eitherOrSounds)
            {
                if (decks[DeckPosition.End].Cards.Count() < decks[DeckPosition.Begin].Cards.Count())
                    decks[DeckPosition.End].Add(card);
                else
                    decks[DeckPosition.Begin].Add(card);
            }

            // Randomize decks now that they're all complete
            foreach (var deck in decks.Values)
            {
                deck.Cards.Shuffle();
            }

            return decks;
        }
    }
}
