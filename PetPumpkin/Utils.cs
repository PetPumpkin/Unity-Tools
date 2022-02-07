using System.Collections.Generic;
using UnityEngine;

namespace PetPumpkin
{
   public static class Utils {
       /// <summary>Returns a random int between 100.</summary>
       public static int RandomNum(){
           return Random.Range(0, 101);
       }
       /// <summary>Returns a random int between 0 and given max int.</summary>
       public static int RandomNum(int max){
            return Random.Range(0, max);
       }

       /// <summary>"Flips a coin" and returns true or false."</summary>
       public static bool FlipCoin(){
           return Random.Range(0, 2) > 0;
       }
   }
   
}
