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
    enum WordPosition
    {
        Begin,
        Middle,
        End
    }

    class Drill
    {
        public Dictionary<WordPosition, List<string>> Decks { get; set; }

        public Drill(List<Card> middleCards, List<OuterCard> outerCards)
        {
            Decks = new Dictionary<WordPosition, List<string>>();

            // Add Middle cards (Vowels)
            Decks.Add(WordPosition.Middle,
                middleCards.Select(c => c.Sound).ToList());

            // Begin gets beginning sounds and sounds that go in both.
            Decks.Add(WordPosition.Begin,
                outerCards
                .Where(c => c.SoundPosition == SoundPosition.Begin ||
                    c.SoundPosition == SoundPosition.Both)
                .Select(c => c.Sound).ToList());

            // End gets ending sounds and sounds that go in both.
            Decks.Add(WordPosition.End,
                outerCards
                .Where(c => c.SoundPosition == SoundPosition.End ||
                    c.SoundPosition == SoundPosition.Both)
                .Select(c => c.Sound).ToList());

            // Remaining sounds are either/or and must be split betweeen Beginning and End.
            List<string> eitherOrSounds = outerCards
                .Where(c => c.SoundPosition == SoundPosition.EitherOr)
                .Select(c => c.Sound).ToList();

            eitherOrSounds.Shuffle();

            foreach (var sound in eitherOrSounds)
            {
                if (Decks[WordPosition.End].Count() < Decks[WordPosition.Begin].Count())
                    Decks[WordPosition.End].Add(sound);
                else
                    Decks[WordPosition.Begin].Add(sound);
            }

            // var blah = eitherOrSounds.Split(2);

        }
    }
}
