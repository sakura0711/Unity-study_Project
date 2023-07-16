using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
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

        if (other.gameObject.name == "HomeTrigger")
        {
            Debug.Log("小紅帽 碰撞到了 door");
            gameObject.transform.position = new Vector3(0, -3, 0);

            SceneManager.LoadScene(other.gameObject.GetComponent<SceneInfo>().SceneName);
        }
        if (other.gameObject.name == "doorTrigger")
        {
            Debug.Log("小紅帽 碰撞到了 door(出門)");
            gameObject.transform.position = new Vector3(0, 0, 0);
            SceneManager.LoadScene(other.gameObject.GetComponent<SceneInfo>().SceneName);
        }
    }
}
