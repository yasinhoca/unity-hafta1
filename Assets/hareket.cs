using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hareket : MonoBehaviour
{
    Vector3 hiz = new Vector3(0f,0f,0f);
    
    void Start()
    {
        hiz.z = Random.Range(0f, 0.07f);
        hiz.x = Random.Range(0f, 0.01f);
        hiz.y = Random.Range(0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position += hiz;
        this.transform.position = position;
    }
}
