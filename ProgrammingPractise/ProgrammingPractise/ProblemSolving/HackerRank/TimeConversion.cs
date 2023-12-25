#region
//Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

//Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

//Example
//s='12:10:00PM'

//Return '12:01:00'.
//s='12:01:00AM'

//Return '00:01:00'.

//Function Description

//Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

//timeConversion has the following parameter(s):

//string s: a time in 12 hour format
//Returns

//string: the time in 24 hour format
//Input Format

//A single string  that represents a time in 12-hour clock format (i.e. hh:mm:ssAM  or hh:mm:ssPM).

//Constraints

//All input times are valid
//Sample Input

//07:05:45PM
//Sample Output

//19:05:45

#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class TimeConversion
    {
        public string timeConversion(string s)
        {
            string[] time = s.Split(':');
            if (time[0] == "12")
            {
                if(s.Contains("AM"))
                {
                    time[0] = "00";
                }
                else if(time[1] == "00" && time[2].Replace("AM","").Replace("PM","")=="00")
                {
                    time[0] = "24";
                }
            }
            else if (s.Contains("PM"))
            {
                time[0] = (Convert.ToByte(time[0]) + 12).ToString();
            }

            return time[0] + ":" + time[1] + ":" + time[2].Replace("AM", "").Replace("PM", "");

        }
    }
}
