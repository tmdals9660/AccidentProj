using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data
{
    public class FuncPropose
    {
        public string mailFunc { get; set; }

        public string subjFunc { get; set; }

        public string contentsFunc { get; set; }

       
        public void SuccesProposeSend(FuncPropose funcPropose)
        {
            FeedbackFile feedback = new FeedbackFile();
            feedback.WritePropose(mailFunc, subjFunc, contentsFunc);           
        }

        public bool InputCheck(FuncPropose funcPropose)
        {
            bool check = true;

            if (mailFunc == string.Empty) check = false;
            if (subjFunc == string.Empty) check = false;
            if (contentsFunc == string.Empty) check = false;

            return check;    
        }



    }
}
