using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enmmyPattern;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            // Quaternion.identity 代表生成時對其父級物件
            int rand = Random.Range(0, enmmyPattern.Length);
            Instantiate(enmmyPattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            // if (startTimeBtwSpawn > minTime)
            // {
            //     startTimeBtwSpawn -= decreaseTime;
            // }

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
