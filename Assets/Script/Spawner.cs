using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy birdscript_;

    public GameObject Pipes;

    public float height;

    public float time;

    void Start()
     {
         StartCoroutine(SpawnObject(time));
     }


     public IEnumerator SpawnObject(float time) //IEnumerator saniye bazlı olay örgüsü yaratmak için kullanılır
     {
         while (!birdscript_.isDead)
         {
             Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
             yield return new WaitForSeconds(time);
         }

    }
}
