using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmmy : MonoBehaviour
{
    public int damage = 1;
    public GameObject effect;
    [SerializeField] int speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector 除了可以指定方向點外，還可以使用 left / right / up / down 等(真方便)
        transform.Translate(Vector2.left * speed * Time.deltaTime, 0);

        // // 超出邊界
        // if (gameObject.transform.position.x < -9)
        // {
        //     Destroy(gameObject);
        //     // Destroy(gameObject.GetComponent<enmmyPatternt01>());
        // }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Ghost>().HP -= damage;
            // Debug.Log(other.GetComponent<Ghost>().HP);
            Destroy(gameObject);
        }
    }
}
