using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<Enemy_Script>();
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
            ScoreScript.scoreValue += 1;
        }
    }
}
