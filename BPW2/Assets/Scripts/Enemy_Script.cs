using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    //public float chaseRange;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        //laat enemy naar playerbed toe bewegen
        Vector3 targetDir = target.position - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);

        transform.Translate(Vector3.up * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * 5 * Time.deltaTime); //(om de enemy naar de target toe te laten bewegen)
    }
}
