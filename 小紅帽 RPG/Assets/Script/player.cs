using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public string playerName;
    SpriteRenderer playerFilpX;
    Animator anim;
    int score;
    [SerializeField] GameObject apple;

    // Start is called before the first frame update
    void Start()
    {
        playerFilpX = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        score = 0;
        Vector3 spwanPos = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0);
        Instantiate(apple, spwanPos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerFilpX.flipX = false;
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerFilpX.flipX = true;
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        else
        {
            anim.SetBool("isMove", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "apple")
        {
            score++;
            Debug.Log("score: " + score);
            Destroy(other.gameObject);
            Vector3 spwanPos = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0);
            Instantiate(apple, spwanPos, Quaternion.identity);
        }
    }
}
