using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D player;
    public int force;
    private int AllowedJump = 2;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AllowedJump > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.AddForce(Vector2.up * force, ForceMode2D.Impulse);
                AllowedJump -= 1;
                Debug.Log(AllowedJump);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            AllowedJump = 2;
        }
    }
}