using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    [Header("要生成的蘋果數量/範圍(x1,x2,y1,y2)")]  //可以在變數間寫上標題
    public int spawnAppleAmount;
    public float[] spawnPos = new float[] { -17f, 14f, -10f, 15f };
    [SerializeField] GameObject apple;
    [SerializeField] Transform appleClass;

    // 用來存儲已生成的蘋果物件的列表
    private List<GameObject> spawnedApples = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        // 生成蘋果物件
        for (int i = 0; spawnedApples.Count < spawnAppleAmount; i++)
        {
            GenerateApple();
        }
    }
    void GenerateApple()
    {
        Vector3 spawnPosV;
        bool overlapping;

        do
        {
            spawnPosV = new Vector3(Random.Range(spawnPos[0], spawnPos[1]), Random.Range(spawnPos[2], spawnPos[3]), 0);
            overlapping = CheckOverlap(spawnPosV);
        }
        while (overlapping);

        GameObject newApple = Instantiate(apple, spawnPosV, Quaternion.identity, appleClass);
        spawnedApples.Add(newApple);
    }

    // 檢查生成位置是否與障礙物重疊
    bool CheckOverlap(Vector3 position)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, 0.8f);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("obstacle"))
            {
                return true;
            }
        }

        return false;
    }
    // Update is called once per frame
    void Update()
    {

    }

}
