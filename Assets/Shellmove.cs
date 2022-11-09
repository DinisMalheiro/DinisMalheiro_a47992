using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shellmove : MonoBehaviour
{

    float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, (Speed * Time.deltaTime)/2.0f, Speed*Time.deltaTime);
    }
}
