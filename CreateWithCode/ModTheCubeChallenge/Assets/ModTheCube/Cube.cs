using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float randomPosX;
    private float randomPosY;
    private float randomPosZ;

    private float randomScale;

    private Color randomColor;

    private float randomRotationSpeed;

    void Awake()
    {
        // Set random value whenever start
        randomPosX = Random.Range(-10f, 6f);
        randomPosY = Random.Range(-8f, 8f);
        randomPosZ = Random.Range(-10f, 18f);

        randomScale = Random.Range(0.5f, 10f);

        randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0.1f, 1f));

        randomRotationSpeed = Random.Range(50f, 1000f);
    }

    void Start()
    {
        transform.position = new Vector3(randomPosX, randomPosY, randomPosZ);
        transform.localScale = Vector3.one * randomScale;

        Material material = Renderer.material;

        material.color = randomColor;
    }
    
    void Update()
    {
        transform.Rotate(randomRotationSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
