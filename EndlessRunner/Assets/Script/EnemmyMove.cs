using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemmyMove : MonoBehaviour
{
    Rigidbody2D enemy;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      enemy.AddForce(Vector2.left * force);
    }
}

