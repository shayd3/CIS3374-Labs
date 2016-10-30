/*
Name: Ryan Ross
Class: CIS3374
Assignment: Lab 5 - Coding/Unit Testing a Bowling Game

Details:
-If strike => Add 10 points PLUS sum of your next TWO shots
-If Spare => Add 10 points PLUS the sum of your next ONE shot
-If Open Frame => Just add on to running score.
-10th Frame => if you roll strike in first shot => 2 more shots
               if you roll a spare in first two shots => 1 more shot
               if open frame after two shots => game is over
               -score is total number of pins knocked down in 10th frame
 */


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling_Game;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingGameTests
    {

        private BowlingGame game;

        [TestInitialize]
        public void Initialize()
        {
            game = new BowlingGame();
        }


        [TestMethod]
        public void AllGutterGame()
        {
            RollMany(0,20);
            Assert.AreEqual(0, game.Score);
        }


        [TestMethod]
        public void AllOnesGame()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void CanScoreSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);
            Assert.AreEqual(16, game.Score);
        }

        [TestMethod]
        public void CanScoreStrike()
        {
            game.Roll(10);
            game.Roll(2);
            game.Roll(3);
            RollMany(0,16);
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void PerfectGame()
        {
            RollMany(10,12);
            Assert.AreEqual(300, game.Score);
        }
        [TestMethod]
        public void RollTwoSparesThenAStrike()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(7);
            game.Roll(3);
            game.Roll(10);
            RollMany(0, 14);
            Assert.AreEqual(47, game.Score);
        }

        [TestMethod]
        public void RollTwoStrikesThenASpare()
        {
            game.Roll(10);
            game.Roll(10);
            game.Roll(5);
            game.Roll(5);
            RollMany(0, 14);
            Assert.AreEqual(55, game.Score);
        }

        [TestMethod]
        public void RollFivesStrikesThenFiveSpares()
        {
            RollMany(10, 5);
            RollMany(5, 11);

            Assert.AreEqual(210, game.Score);

        }

        private void RollMany(int pins, int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
