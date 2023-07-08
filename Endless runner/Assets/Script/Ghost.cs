using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    public int HP = 10;
    private Vector2 targetPos;

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
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}