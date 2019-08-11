using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour
{
    public void ChangeLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
