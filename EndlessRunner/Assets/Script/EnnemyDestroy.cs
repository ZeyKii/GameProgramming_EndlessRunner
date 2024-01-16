using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnnemyDestroy : MonoBehaviour
{
    void OnBecameInvisible()
    {
        FindObjectOfType<ScoreManager>().IncrementScore();
        Destroy(gameObject);
    }
}
