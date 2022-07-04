using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScreen : MonoBehaviour
{
   public List<GameObject> Locks;
   public List<GameObject> Texts;
   public List<GameObject> Light;

   private void OnEnable()
   {
      for (int i = 1; i < 10; i++)
      {
         if (i<=Session.Instance.UnlockedCount)
         {
           Locks[i].SetActive(false); 
           Texts[i].SetActive(true); 
           Light[i].SetActive(true); 
         }
         else
         {
            Locks[i].SetActive(true); 
            Texts[i].SetActive(false); 
            Light[i].SetActive(false); 

         }
      }
   }
}
