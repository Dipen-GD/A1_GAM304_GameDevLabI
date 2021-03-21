using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMove : MonoBehaviour
{
    // spawnee speed after spawning
    public float moveSpeed;

    // spawnee move direction
    public Vector3 moveVector;

   
    void Update()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        Destroy(gameObject, 2);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            Destroy(this.gameObject);
        }
    }
}
