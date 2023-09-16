using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class BusinessLayerClass
    {
       
        DataLayerClass objDL = new DataLayerClass(); 
        public void SaveResults(int teamAScore, int teamBScore)
        {
            //TeamA,0,TeamB,0 
            string result = $"TeamA,{teamAScore},TeamB,{teamBScore}\n";
            objDL.SaveResultsToCSV(result);
        }
        public string MakeALog()// split, check won and make log
        {
            List<string> resultsFromDL = objDL.GetResultsFromCSV();
            
            int pointsA = 0;
            int pointsB = 0;
            
            foreach (var line in resultsFromDL)
            {       
                //TeamA,0,TeamB,0
                string[] matchAndScore = line.Split(',');
               int TeamAScore = int.Parse(matchAndScore[1]);
               int TeamBScore = int.Parse(matchAndScore[3]);

                if(TeamAScore > TeamBScore)
                {
                    pointsA = pointsA + 3;
                }
                else if(TeamAScore < TeamBScore)
                {
                    pointsB = pointsB + 3;
                }
                else
                {
                    pointsA = pointsA + 1;
                    pointsB = pointsB + 1;
                }
            }
            string Log;
            if (pointsA > pointsB)
            {
                Log = $"TeamA: {pointsA} \nTeamB: {pointsB}";
            }
            else if (pointsA < pointsB)
            {
                Log = $"TeamB: {pointsB} \nTeamA: {pointsA}";
            }
            else
            {
                Log = $"TeamA: {pointsA} \nTeamB: {pointsB}";
            }


            return Log;
        }
    }
}
