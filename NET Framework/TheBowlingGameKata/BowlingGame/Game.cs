using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int currentRoll = 0;
        private int[] rolls = new int[21];
        private int score;
        private readonly int totalFrame = 10;
        private readonly int lastFrameIndex = 9;

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score()
        {

            for (int frame = 0; frame < totalFrame; frame++)
            {
                bool isLastFrame = (frame == lastFrameIndex);
                if (isLastFrame)
                {
                    EvaluateScoreForLastFrame(frame);

                }
                else
                {
                    EvaluateScoreFrame(frame);
                }
            }

            return score;
        }

        private void EvaluateScoreFrame(int frame)
        {
            if (isStrikeFrame(frame))
            {
                AddStrikeBonus(frame);
            }

            else if (isSpareFrame(frame))
            {
                AddSpareBonus(frame);
            }

            score += EvaluateFrameScore(frame);
        }

        private void EvaluateScoreForLastFrame(int frame)
        {
            if (isStrikeFrame(frame))
            {
                for (int bonusRoll = 0; bonusRoll <= 2; bonusRoll++)
                {
                    int roll = (frame * 2) + bonusRoll;
                    score += rolls[roll];
                }
            }

            else if (isSpareFrame(frame))
            {
                score += EvaluateFrameScore(frame);
                AddSpareBonus(frame);
            }
            else
            {
                score += EvaluateFrameScore(frame);
            }
        }

        private void AddSpareBonus(int frame)
        {
            score += EvaluateFirstRollScoreOfFrame(frame + 1);
        }

        private void AddStrikeBonus(int frame)
        {
            score += EvaluateFrameScore(frame + 1);

        }

        private bool isStrikeFrame(int frame)
        {
            int firstRollScore = EvaluateFirstRollScoreOfFrame(frame);
            if (firstRollScore == 10)
            {
                return true;
            }
            return false;
        }

        private bool isSpareFrame(int frame)
        {
            int firstRollScore = EvaluateFirstRollScoreOfFrame(frame);
            int frameScore = EvaluateFrameScore(frame);
            if (frameScore == 10)
            {
                return true;
            }
            return false;
        }

        private int EvaluateFrameScore(int frame)
        {
            int firstRollScore = EvaluateFirstRollScoreOfFrame(frame);
            int nextRoll = frame * 2 + 1;
            int frameScore = firstRollScore + rolls[nextRoll];
            return frameScore;
        }

        private int EvaluateFirstRollScoreOfFrame(int frame)
        {
            int roll = frame * 2;
            return rolls[roll];
        }

    }
}
