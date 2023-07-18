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
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "HomeTrigger" || other.gameObject.name == "doorTrigger")
        {
            collider = other;
            isCollision = true;
        }
        // {
        //     Debug.Log("小紅帽 碰撞到了 door(進門)");
        //     gameObject.transform.position = new Vector3(0, -3, 0);

        //     SceneManager.LoadScene(other.gameObject.GetComponent<SceneInfo>().SceneName);
        // }
        // if (other.gameObject.name == "doorTrigger")
        // {
        //     Debug.Log("小紅帽 碰撞到了 door(出門)");
        //     gameObject.transform.position = new Vector3(21.77f, 22.6f, 0);
        //     SceneManager.LoadScene(other.gameObject.GetComponent<SceneInfo>().SceneName);
        // }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "HomeTrigger" || other.gameObject.name == "doorTrigger") { isCollision = false; collider = null; }
    }
}
