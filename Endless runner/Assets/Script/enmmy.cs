using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmmy : MonoBehaviour
{
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ghost"))
        {
            other.GetComponent<Ghost>().HP -= damage;
            Debug.Log(other.GetComponent<Ghost>().HP);
            Destroy(gameObject);
        }
    }
}
