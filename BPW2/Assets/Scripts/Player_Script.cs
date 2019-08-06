using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public GameObject leftGhost;
    public GameObject rightGhost;
    public GameObject downGhost;
    public GameObject upGhost;

    private void Start()
    {
        leftGhost.SetActive(true);
        rightGhost.SetActive(false);
        downGhost.SetActive(false);
        upGhost.SetActive(false);
    }

    void Update()
    {

        // Code voor inputcheck
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftGhost.SetActive(true);
            rightGhost.SetActive(false);
            downGhost.SetActive(false);
            upGhost.SetActive(false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            leftGhost.SetActive(false);
            rightGhost.SetActive(true);
            downGhost.SetActive(false);
            upGhost.SetActive(false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            leftGhost.SetActive(false);
            rightGhost.SetActive(false);
            downGhost.SetActive(true);
            upGhost.SetActive(false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            leftGhost.SetActive(false);
            rightGhost.SetActive(false);
            downGhost.SetActive(false);
            upGhost.SetActive(true);
        }
    }
}
