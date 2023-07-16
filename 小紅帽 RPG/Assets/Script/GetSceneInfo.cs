using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSceneInfo : MonoBehaviour
{
    GameObject doorObject;


    // Start is called before the first frame update
    void Start()
    {
        // 獲取當前活動的場景
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        Debug.Log("Current Scene: " + sceneName);
        GetDoorFromScene(sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        if (doorObject != null)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                // 獲取CompositeCollider2D組件的引用
                // doorObject.GetComponent<BoxCollider2D>().isTrigger = !doorObject.GetComponent<BoxCollider2D>().isTrigger;

                // activeSelf 可以獲取物件現在的狀態 (true / false)
                doorObject.SetActive(!doorObject.activeSelf);
            }
        }
    }
    void GetDoorFromScene(string sceneName)
    {
        // 檢查場景是否存在
        // if (!SceneManager.sceneLoaded || SceneManager.GetSceneByName(sceneName) == null)
        // {
        //     Debug.LogWarning("Scene " + sceneName + " is not loaded or does not exist.");
        //     return;
        // }

        // 獲取場景中的根物件
        Scene scene = SceneManager.GetSceneByName(sceneName);

        GameObject[] rootObjects = scene.GetRootGameObjects();

        Debug.Log(rootObjects);
        foreach (GameObject rootObject in rootObjects)
        {
            Debug.Log(rootObject);
            if (rootObject.name == "Grid")
            {
                doorObject = GameObject.FindGameObjectWithTag("triggerHome");
                doorObject.SetActive(false);
                Debug.Log(doorObject);
            }
        }
        // 尋找位於 "grid" 和 "trigger" 下方的 "door" 物件



    }
}
