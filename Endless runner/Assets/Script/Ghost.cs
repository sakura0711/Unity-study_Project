using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float speed;
    public float increment;
    public float maxY;
    public float minY;
    public GameObject effect;

    public int HP = 10;
    private Vector2 targetPos;
    private Vector3 spawnEffectPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            spawnEffectPos = new Vector3(transform.position.x, transform.position.y + increment / 2, transform.position.z);
            Instantiate(effect, spawnEffectPos, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            spawnEffectPos = new Vector3(transform.position.x, transform.position.y - increment / 2, transform.position.z);
            Instantiate(effect, spawnEffectPos, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}