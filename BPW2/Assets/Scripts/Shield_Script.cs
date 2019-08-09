using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Script : MonoBehaviour
{
    public AudioClip wub;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<Enemy_Script>();
        if (enemy != null)
        {
            source.PlayOneShot(wub);
            Destroy(enemy.gameObject);
            ScoreScript.scoreValue += 1;
        }
    }
}
