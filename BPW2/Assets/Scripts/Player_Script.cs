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
        leftGhost.SetActive(false);
        rightGhost.SetActive(false);
        downGhost.SetActive(true);
        upGhost.SetActive(false);
    }

    void Update()
    {
        // Code voor inputcheck
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SetDirection(true, false, false, false);
            /*leftGhost.SetActive(true);
            rightGhost.SetActive(false);
            downGhost.SetActive(false);
            upGhost.SetActive(false);*/
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SetDirection(false, true, false, false);
            //leftGhost.SetActive(false);
            //rightGhost.SetActive(true);
            //downGhost.SetActive(false);
            //upGhost.SetActive(false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            SetDirection(false, false, true, false);
            //leftGhost.SetActive(false);
            //rightGhost.SetActive(false);
            //downGhost.SetActive(true);
            //upGhost.SetActive(false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            SetDirection(false, false, false, true);
            //leftGhost.SetActive(false);
            //rightGhost.SetActive(false);
            //downGhost.SetActive(false);
            //upGhost.SetActive(true);
        }
    }

    private void SetDirection(bool left,bool right,bool down,bool up)
    {
        leftGhost.SetActive(left);
        rightGhost.SetActive(right);
        downGhost.SetActive(down);
        upGhost.SetActive(up);
    }
}
