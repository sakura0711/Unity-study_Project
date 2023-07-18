using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public Canvas uiCanvas; // 引用你的UI Canvas
    public Text tipText;
    // Start is called before the first frame update
    void Start()
    {
        tipText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("triggerHome"))
        {
            tipText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("triggerHome"))
        {
            tipText.gameObject.SetActive(false);
        }
    }
}
