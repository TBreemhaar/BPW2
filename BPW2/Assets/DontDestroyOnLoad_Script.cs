using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad_Script : MonoBehaviour
{
    private void Awake()
    {

        if (FindObjectsOfType<DontDestroyOnLoad_Script>().Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
    }
}
