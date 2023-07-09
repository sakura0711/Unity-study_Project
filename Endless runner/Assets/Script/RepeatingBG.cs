using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;
    public float endX;
    public float startX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ! 須注意，當使用 Vector 2 時，因為 vector2 已經包含了 x , y 兩點的資料，所以如果使用 translate.Tranform 時，只能在填一個 z 的參數
        // transform.Translate(Vector2.left * speed * Time.deltaTime, 0, 0); **報錯** 因為多一個參數

        transform.Translate(Vector2.left * speed * Time.deltaTime, 0);
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos; // 可以直接使用 vector 的值指派給 translate.position
        }
    }
}
