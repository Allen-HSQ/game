using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    private GameObject[] enemys;
    void Start()
    {
        enemys = Resources.LoadAll<GameObject>("Enemys");
        Create();

    }
    void Update()
    {

    }

    private void Create()
    {
        for (int i = -5; i < 5; i++)
        {
            GameObject enemy = Instantiate(enemys[Random.Range(0, enemys.Length)],
                new Vector3(i * 2, 0, 0), Quaternion.identity);
            enemy.AddComponent<EnemyAI>();
        }
    }
}
