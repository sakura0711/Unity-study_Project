using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //用陣列取得所有tag"role"物件，希望只有objs[0]一項，objs.Length=1
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        // GameObject player = GameObject.FindGameObjectWithTag("Player");

        //如果陣列不只一項（第二次加載時重複新增該物件）
        if (objs.Length > 1)
        {
            //就刪除該次加載場景建立物件

            Destroy(this.gameObject);
        }

        //如果陣列只有一項，就不要刪掉這個物件（首次加載）
        Debug.Log("DontDestroyOnLoad(this.gameObject);");
        Debug.Log(this.gameObject);
        DontDestroyOnLoad(this.gameObject);

        // 重新定義 player 位置
        // player.transform.position = new Vector3(0, -3, 0);
    }
}