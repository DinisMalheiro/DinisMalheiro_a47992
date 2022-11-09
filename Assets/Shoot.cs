using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject ShellPrefab;
    public GameObject ShellSpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Fire()
    {
        GameObject shell = Instantiate(ShellPrefab, ShellSpawnPos.transform.position, ShellSpawnPos.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}
