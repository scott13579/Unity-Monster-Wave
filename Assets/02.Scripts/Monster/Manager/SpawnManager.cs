using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /// [변수]
    /// 생성하려는 프리팹
    /// 여러 개를 담고 있는 배열로 생성
    public GameObject[] spawnPrefabs;
    
    /// 생성하는 주기
    public float maxTime = 3f;
    private float timer = 0f;

    /// [기능]
    /// 몬스터 스폰 기능
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            timer = 0f;
            // 몬스터 생성
            int randomIndex = Random.Range(0, spawnPrefabs.Length);
            GameObject monsterObj = Instantiate(spawnPrefabs[randomIndex], this.transform, false);
        }
    }
}
