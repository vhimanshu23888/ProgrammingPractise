/*
Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.

Example

Scores are in the same order as the games played. She tabulates her results as follows:

                                     Count
    Game  Score  Minimum  Maximum   Min Max
     0      12     12       12       0   0
     1      24     12       24       0   1
     2      10     10       24       1   1
     3      24     10       24       1   1
Given the scores for a season, determine the number of times Maria breaks her records for most and least points scored during the season.

Function Description

Complete the breakingRecords function in the editor below.

breakingRecords has the following parameter(s):

int scores[n]: points scored per game
Returns

int[2]: An array with the numbers of times she broke her records. Index 0 is for breaking most points records, and index 1 is for breaking least points records.
Input Format

The first line contains an integer n, the number of games.
The second line contains n space-separated integers  describing the respective values of scores0,scores1....scoresn.

Constraints
1<=n<=1000
0<=scores[i]<=10^8

*/


using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
   public class BreakingTheRecords
    {
        public List<int> breakingRecords(List<int> scores)
        {
            if (scores.Count < 1 || scores.Count > 1000)
                throw new ArgumentOutOfRangeException(nameof(scores), "Number of games should be between 1 and 1000");
            int min = 0,max = 0;
            int minScore=0,maxScore = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] < 0 || scores[i] > Math.Pow(10, 8))
                    throw new ArgumentOutOfRangeException(null, "Value of scores should lie between 0 to 10^8");

                if (i == 0)
                {
                    min = scores[i];
                    max = scores[i];
                }
                else
                {
                    if (scores[i] < min)
                    {
                        min = scores[i];
                        minScore++;
                    }
                    else if (scores[i] > max)
                    {
                        max = scores[i];
                        maxScore++;
                    }
                }
            }

                return new List<int> { maxScore, minScore };
        }
    }
}
