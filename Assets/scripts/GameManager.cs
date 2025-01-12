using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; // 置放Prefab的變數
    public Image hpGauge; // 血量進度條
    private float span = 1.0f; // 時間間隔
    private float delta = 0; // 現在已經累積的時間

    void Start()
    {
        if (hpGauge == null)
        {
            Debug.LogError("hpGauge is not assigned.");
        }
    }

    void Update()
    {
        delta += Time.deltaTime; // 每一個影格經過的時間，都累加到delta中
        if (delta > span) // 只要delta累積到大於span（大於1秒），就會產生一個箭頭
        {
            delta = 0;
            int px = Random.Range(-6, 7); // 隨機產生一個-6到7之間的數字
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity); // 產生箭頭物件
        }
    }

    public void DecreaseHp()
    {
        if (hpGauge != null)
        {
            hpGauge.fillAmount = Mathf.Max(0, hpGauge.fillAmount - 0.1f);
        }
        else
        {
            Debug.LogError("hpGauge is not assigned.");
        }
    }
}
