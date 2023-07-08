using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject enmmy;
    // Start is called before the first frame update
    void Start()
    {   // 生成 enmmy 
        Instantiate(enmmy, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
