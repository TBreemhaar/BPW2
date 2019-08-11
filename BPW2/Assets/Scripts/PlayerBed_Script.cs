using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBed_Script : MonoBehaviour
{
    public static PlayerBed_Script instance;
    private AsyncOperation asyncOperation;
    [SerializeField]
    private int levelIndex;
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

    private void Start()
    {

        asyncOperation = SceneManager.LoadSceneAsync(levelIndex);
        asyncOperation.allowSceneActivation = false;
    }

    //wanneer er iets met het bed collide, dan wordt deze methode aangeroepen. Deze collision is wat het bed heeft geraakt.
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        var enemy = collision.GetComponent<Enemy_Script>();
        if (enemy != null)
        {
            Time.timeScale = 1f;
            GameObject g = FindObjectOfType<DontDestroyOnLoad_Script>().gameObject;
            Destroy(g);

            asyncOperation.allowSceneActivation = true;
            //Destroy(enemy.gameObject);
            //Destroy(gameObject);
        }
    }
}
