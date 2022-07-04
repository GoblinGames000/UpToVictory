using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public List<Vector3> SpawnPosition6;
   public List<Vector3> SpawnPosition5;
   public List<Vector3> SpawnPosition4;
   public List<Vector3> SpawnPosition3;
   public List<Vector3> SpawnPosition2;
   public List<GameObject> CirclePrefab6;
   public List<GameObject> CirclePrefab5;
   public List<GameObject> CirclePrefab4;
   public List<GameObject> CirclePrefab3;
   public List<GameObject> CirclePrefab2;
   public int Circle6Speed;
   public int Circle5Speed;
   public int Circle4Speed;
   public int Circle3Speed;
   public int Circle2Speed;
   private void Start()
   {
      Circle6Speed = UnityEngine.Random.Range(50, 100);
      Circle5Speed = UnityEngine.Random.Range(50, 100);
      Circle4Speed = UnityEngine.Random.Range(50, 100);
      Circle3Speed = UnityEngine.Random.Range(50, 100);
      Circle2Speed = UnityEngine.Random.Range(50, 100);
      Spawn6();
      Spawn5();
      Spawn4();
      Spawn3();
      Spawn2();
     
    
   }

   void Spawn6()
   {
      int index = UnityEngine.Random.Range(1, SpawnPosition6.Count);
      for (int i = 0; i <= index; i++)
      {
        var obj= Instantiate(CirclePrefab6[0], SpawnPosition6[i], quaternion.identity);
        obj.GetComponent<Circle>().Speed = Circle6Speed;
      }
   } void Spawn5()
   {
      int index = UnityEngine.Random.Range(1, SpawnPosition5.Count);
      for (int i = 0; i <= index; i++)
      {
        var obj= Instantiate(CirclePrefab5[0], SpawnPosition5[i], quaternion.identity);
         obj.GetComponent<Circle>().Speed = Circle5Speed;

      }
   } void Spawn4()
   {
      int index = UnityEngine.Random.Range(1, SpawnPosition4.Count);
      for (int i = 0; i <= index; i++)
      {
       var obj=  Instantiate(CirclePrefab4[0], SpawnPosition4[i], quaternion.identity);
         obj.GetComponent<Circle>().Speed = Circle4Speed;

      }
   } void Spawn3()
   {
      int index = UnityEngine.Random.Range(1, SpawnPosition3.Count);
      for (int i = 0; i <= index; i++)
      {
        var obj= Instantiate(CirclePrefab3[0], SpawnPosition3[i], quaternion.identity);
         obj.GetComponent<Circle>().Speed = Circle3Speed;

      }
   } void Spawn2()
   {
      int index = UnityEngine.Random.Range(1, SpawnPosition2.Count);
      for (int i = 0; i <= index; i++)
      {
        var obj= Instantiate(CirclePrefab2[0], SpawnPosition2[i], quaternion.identity);
         obj.GetComponent<Circle>().Speed = Circle2Speed;

      }
   }
   
}
