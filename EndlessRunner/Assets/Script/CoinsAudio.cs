using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsAudio : MonoBehaviour
{
    public AudioClip collisionSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collisionSound != null)
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
        }
    }
}
