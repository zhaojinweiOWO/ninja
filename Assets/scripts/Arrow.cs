using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �C�Ӽv�浥�t���U����
        transform.Translate(0, -0.1 f, 0);

        // ��b�Y�W�X�C���e���ɴN�˱󪫥�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
