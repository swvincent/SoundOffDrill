# region LICENSE
///////////////////////////////////////////////////////////////////////////////
// MIT License
//
// Copyright 2018 Scott W. Vincent
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
///////////////////////////////////////////////////////////////////////////////
#endregion LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundOffDrill.Biz;

namespace SoundOffDrill.Biz
{
    enum DeckPosition
    {
        Begin,
        Middle,
        End
    }

    class Drill
    {
        public Dictionary<DeckPosition, List<string>> Decks { get; set; }

        /// <summary>
        /// Create new Drill
        /// </summary>
        /// <param name="cards">Cards to include in Drill</param>
        /// <param name="outerCards">Outside cards for beginning and end</param>
        public Drill(List<Card> cards)
        {
            // Create decks starting with cards that have a definite place.
            Decks = new Dictionary<DeckPosition, List<string>>
            {
                {
                    DeckPosition.Begin,
                    cards.Where(c => c.SoundPosition == SoundPosition.Begin ||
                        c.SoundPosition == SoundPosition.Both)
                        .Select(c => c.Sound).ToList()
                },

                // Middle cards (Vowels)
                {
                    DeckPosition.Middle,
                    cards.Where(c => c.SoundPosition == SoundPosition.Middle)
                        .Select(c => c.Sound).ToList()
                },

                // End gets ending sounds and sounds that go in both.
                {
                    DeckPosition.End,
                    cards.Where(c => c.SoundPosition == SoundPosition.End ||
                        c.SoundPosition == SoundPosition.Both)
                        .Select(c => c.Sound).ToList()
                }
            };

            // Remaining sounds are either/or and must be split betweeen Beginning and End.
            List<string> eitherOrSounds = cards
                .Where(c => c.SoundPosition == SoundPosition.EitherOr)
                .Select(c => c.Sound).ToList();

            // Use Shuffle extension to randomize then
            // distribute to make both lists same qty
            eitherOrSounds.Shuffle();

            foreach (var sound in eitherOrSounds)
            {
                if (Decks[DeckPosition.End].Count() < Decks[DeckPosition.Begin].Count())
                    Decks[DeckPosition.End].Add(sound);
                else
                    Decks[DeckPosition.Begin].Add(sound);
            }

            // Randomize decks now that they're all complete
            foreach (var deck in Decks.Values)
            {
                deck.Shuffle();
            }
        }
    }
}
