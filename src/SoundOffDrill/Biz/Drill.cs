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

namespace SoundOffDrill.Biz
{
    /// <summary>
    /// Word Position of Deck
    /// </summary>
    public enum DeckPosition
    {
        Begin,
        Middle,
        End
    }

    public class Drill
    {
        public List<Card> Cards { get; }
        public SortedDictionary<DeckPosition, Deck> Decks { get; internal set; }

        #region Constructor

        /// <summary>
        /// Create new Drill
        /// </summary>
        /// <param name="cards">Cards to include in Drill</param>
        public Drill(List<Card> cards)
        {
            this.Cards = cards; // TODO: Needed?
            var dealer = new Dealer();
            Decks = dealer.BuildDecks(cards);
        }

        #endregion Constructor

        #region Cards

        /// <summary>
        /// Retrieve current word from current cards.
        /// </summary>
        /// <returns></returns>
        public string CurrentWord()
        {
            return string.Join("", Decks.Values
                .Select(d => d.CurrentCard().Sound));
        }

        /// <summary>
        /// Retrieve previous word from cycling all decks to previous card.
        /// </summary>
        /// <returns></returns>
        public string PrevWord()
        {
            return string.Join("", Decks.Values
                .Select(d => d.PrevCard().Sound));
        }

        /// <summary>
        /// Retrieve next word from cycling all decks to next card.
        /// </summary>
        /// <returns></returns>
        public string NextWord()
        {
            return string.Join("", Decks.Values
                .Select(d => d.NextCard().Sound));
        }

        /// <summary>
        /// Retrieve current card for specified deck.
        /// </summary>
        /// <param name="deckPosition"></param>
        /// <returns></returns>
        public Card CurrentCard(DeckPosition deckPosition)
        {
            return Decks[deckPosition].CurrentCard();
        }

        /// <summary>
        /// Retrieve prev card for specified deck.
        /// </summary>
        /// <param name="deckPos"></param>
        /// <returns></returns>
        public Card PrevCard(DeckPosition deckPosition)
        {
            return Decks[deckPosition].PrevCard();
        }

        /// <summary>
        /// Retrieve next card for specified deck.
        /// </summary>
        /// <param name="deckPos"></param>
        /// <returns></returns>
        public Card NextCard(DeckPosition deckPosition)
        {
            return Decks[deckPosition].NextCard();
        }

        #endregion Cards

    }
}
