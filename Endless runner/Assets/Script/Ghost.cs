using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ghost : MonoBehaviour
{
    public float speed;
    public float increment;
    public float maxY;
    public float minY;
    public GameObject effect;
    public GameObject GameOver;

    public int HP = 10;
    private Vector2 targetPos;
    private Vector3 spawnEffectPos;

    private Shaked shaked;
    private int score;
    public Text HPdisplay;


    // Start is called before the first frame update
    void Start()
    {
        shaked = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Shaked>();
        HPdisplay.text = "HP " + HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (HP <= 0)
        {
            GameOver.SetActive(true);
            Destroy(gameObject);
        }

        HPdisplay.text = "HP " + HP.ToString();
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            shaked.CamShaked();
            spawnEffectPos = new Vector3(transform.position.x, transform.position.y + increment / 2, transform.position.z);
            Instantiate(effect, spawnEffectPos, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            shaked.CamShaked();
            spawnEffectPos = new Vector3(transform.position.x, transform.position.y - increment / 2, transform.position.z);
            Instantiate(effect, spawnEffectPos, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}