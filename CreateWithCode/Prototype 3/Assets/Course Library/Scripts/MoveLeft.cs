using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    private PlayerController playerControllerScript;

    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // Move left when player is alive
        if(!playerControllerScript.gameOver)
            transform.Translate(Vector3.left * Time.deltaTime *  speed);

        // if gameobject is obstacle, and it is over the leftbound, destroy it.
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
