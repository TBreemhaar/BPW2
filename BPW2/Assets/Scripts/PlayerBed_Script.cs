using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBed_Script : MonoBehaviour
{
    public static PlayerBed_Script instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    //wanneer er iets met het bed collide, dan wordt deze methode aangeroepen. Deze collision is wat het bed heeft geraakt.
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        var enemy = collision.GetComponent<Enemy_Script>();
        if(enemy != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Destroy(enemy.gameObject);
            //Destroy(gameObject);
        }
    }
}
