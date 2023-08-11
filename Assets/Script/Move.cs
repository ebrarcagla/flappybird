using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("DestroyFunction");
    }

    IEnumerator DestroyFunction()
    {
        yield return new WaitForSeconds(7f);
        Destroy(this.gameObject);
    }

    public float speed;
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


}
