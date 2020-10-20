using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    static class user
    {
        //nice there aren't any methods in this class. 

        public static String name { get; set; }
        private static UInt16 Age;
        public static UInt16 age
        {
            get { return Age;}
            set {
                //if (value <= 3 || value >= 10)
                //{
                //    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "."+MethodInfo.GetCurrentMethod().Name);
                //}
               
                Age = value;
                
            }
        }
        public static UInt16 gameMode{ get; set; }
        public static UInt16 correctScore { get; set; }
        public static UInt16 incorrectScore { get; set; }
        public static UInt64 TimeinSeconds { get; set; }



    }

   
}
