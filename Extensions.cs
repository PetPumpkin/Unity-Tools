using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetPumpkin
{
    public static class Exentions {
       /// <summary>Returns a random element from the list.</summary>
       public static T GetRandom<T>(this List<T> list){
           return list[Random.Range(0, list.Count)];
       }
   }
}
