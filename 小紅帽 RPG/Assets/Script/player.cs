using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public string playerName;
    SpriteRenderer playerFilpX;
    Animator anim;
    int score;
    [SerializeField] GameObject apple;
    [Space()]     //可以在變數之間留空格 //標題不能
    public Text scoreText;

    [Header("要生成的蘋果數量/範圍(x1,x2,y1,y2)")]  //可以在變數間寫上標題
    public int spawnAppleAmount;
    public float[] spawnPos = new float[4];

    // 用來存儲已生成的蘋果物件的列表
    private List<GameObject> spawnedApples = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        playerFilpX = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        score = 0;
        scoreText.text = "獲得的蘋果 : 0";
        for (int i = 0; i < spawnAppleAmount; i++)
        {
            Vector3 spwanPos = new Vector3(Random.Range(spawnPos[0], spawnPos[1]), Random.Range(spawnPos[2], spawnPos[3]), 0);
            Instantiate(apple, spwanPos, Quaternion.identity);
        }
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
            scoreText.text = "獲得的蘋果 : " + score.ToString();
            Debug.Log("score: " + score);
            Destroy(other.gameObject);
            // Vector3 spwanPos = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0);
            // Instantiate(apple, spwanPos, Quaternion.identity);
        }
    }
}
