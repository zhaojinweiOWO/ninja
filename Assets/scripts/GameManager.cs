using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; // �m��Prefab���ܼ�
    public Image hpGauge; // ��q�i�ױ�
    private float span = 1.0f; // �ɶ����j
    private float delta = 0; // �{�b�w�g�ֿn���ɶ�

    void Start()
    {
        if (hpGauge == null)
        {
            Debug.LogError("hpGauge is not assigned.");
        }
    }

    void Update()
    {
        delta += Time.deltaTime; // �C�@�Ӽv��g�L���ɶ��A���֥[��delta��
        if (delta > span) // �u�ndelta�ֿn��j��span�]�j��1��^�A�N�|���ͤ@�ӽb�Y
        {
            delta = 0;
            int px = Random.Range(-6, 7); // �H�����ͤ@��-6��7�������Ʀr
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity); // ���ͽb�Y����
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
