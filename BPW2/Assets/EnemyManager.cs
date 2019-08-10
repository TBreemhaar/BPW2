using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq; //Hulp van Casey

public class EnemyManager : MonoBehaviour
{
    public float speedIncrease = 0.25f;
    public float maxSpeedIncrease = 5f;

    private List<Enemy_Script> enemies = new List<Enemy_Script>();

    private void Start()
    {
        enemies = FindObjectsOfType<Enemy_Script>().ToList();
    }

    private void Update()
    {
        //Hulp van Casey
        enemies.RemoveAll(e => e == null);
        if (enemies.Count == 0)
        {
            Reload();
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = Mathf.Min(Time.timeScale + speedIncrease, maxSpeedIncrease);
    }
}
