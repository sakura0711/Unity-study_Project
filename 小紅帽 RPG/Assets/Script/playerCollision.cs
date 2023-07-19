using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerCollision : MonoBehaviour
{
    bool isCollision = false;
    new Collider2D collider = null;
    public Text tipText;
    // Start is called before the first frame update
    void Start()
    {
        tipText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollision)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (collider.name == "HomeTrigger")
                {
                    Debug.Log("小紅帽 碰撞到了 door(進門)");
                    gameObject.transform.position = new Vector3(0, -2.5f, 0);
                    tipText.gameObject.SetActive(false);
                    SceneManager.LoadScene(collider.gameObject.GetComponent<SceneInfo>().SceneName);
                }
                else if (collider.name == "doorTrigger")
                {
                    Debug.Log("小紅帽 碰撞到了 door(出門)");
                    gameObject.transform.position = new Vector3(21.77f, 22.6f, 0);
                    tipText.gameObject.SetActive(false);
                    SceneManager.LoadScene(collider.gameObject.GetComponent<SceneInfo>().SceneName);
                }
                else if (collider.name == "grandmother")
                {
                    Debug.Log("小紅帽 碰撞到了 grandmother(奶奶)");

                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EventTrigger"))
        {
            tipText.gameObject.SetActive(true);
        }
        if (other.gameObject.name == "HomeTrigger" ||
           other.gameObject.name == "doorTrigger" ||
           other.gameObject.name == "grandmother")
        {
            collider = other;
            isCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EventTrigger"))
        {
            tipText.gameObject.SetActive(false);
        }
        {
            if (other.gameObject.name == "HomeTrigger" ||
                other.gameObject.name == "doorTrigger" ||
                other.gameObject.name == "grandmother")
            {
                isCollision = false;
                collider = null;
            }
        }
        playerMoveFun(1, "strinh");
    }

    /// <summary>
    /// tedstste
    /// </summary>
    /// 
    /// <param name="a">awdawd</param>
    /// <param name="stringTalk">awdadw</param>
    /// <returns>ddd</returns>
    /// <code>dawdij</code>
    public int playerMoveFun(int a, string stringTalk)
    {
        a = 0;
        stringTalk = "dd";
        return 0;
    }
}
