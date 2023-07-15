using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public static bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit Game");
            Application.Quit(); // 執行 bulid 成 exe 後才有效
            // EditorApplication.isPlaying = false; //編輯效果中暫停，可以使用EditorApplication
        };
    }
}
