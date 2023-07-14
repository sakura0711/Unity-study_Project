using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public string playerName;
    SpriteRenderer playerFilpX;

    // Start is called before the first frame update
    void Start()
    {
        playerFilpX = GetComponent<SpriteRenderer>();
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
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerFilpX.flipX = true;
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
    }
}
