using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogSpawnDelay; // 개 생성 주기
    public float dogSpawnTime;  // 개 생성 시간 체크
    public bool canSpawn;   // 개 생성 가능 여부

    void Start()
    {
        dogSpawnTime = 0;
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        dogSpawnTime += Time.deltaTime;
        if(dogSpawnTime > dogSpawnDelay)
        {
            dogSpawnTime = 0;
            canSpawn = true;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
        }
    }
}
