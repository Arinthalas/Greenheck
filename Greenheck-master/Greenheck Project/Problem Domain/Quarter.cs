using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Quarter
    {
        public DateTime fiscYear;
        public int fiscQuarter;
        public int statusNotStart;
        public int statusInProgress;
        public int statusComplete;
        public int statusDelay;
        public int statusCancelled;

        //Creates an empty Quarter object
        public Quarter()
        {

        }

        //Creates a Quarter object with passed values
        public Quarter(DateTime year, int quarter, int notstarted, int ongoing, int finished, int delayed, int cancelled)
        {
            fiscQuarter = quarter;
            fiscYear = year;
            statusCancelled = cancelled;
            statusComplete = finished;
            statusDelay = delayed;
            statusInProgress = ongoing;
            statusNotStart = notstarted;
        }

        //Determines the current quarter of the fiscal year and returns 1 through 4
        public static int DetermineQuarter()
        {
            int sendback;

            //Test and determine which is the current quarter based on the month of the year
            if (DateTime.Now.Month > 9)
            {
                sendback = 1;
            }
            else
            {
                if (DateTime.Now.Month > 6)
                {
                    sendback = 4;
                }
                else
                {
                    if (DateTime.Now.Month > 3)
                    {
                        sendback = 3;
                    }
                    else
                    {
                        sendback = 2;
                    }
                }
            }
            return sendback;
        }
    }
}
