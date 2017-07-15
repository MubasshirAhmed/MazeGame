using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public GameObject targetPlayer;
    private Rigidbody rb;
    private float moveSpeed = 10;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 lookDir = targetPlayer.transform.position - transform.position;
        lookDir.y = 0;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDir), Time.deltaTime * 20.0f);
        float distance = Vector3.Distance(targetPlayer.transform.position, transform.position);
        //if (distance > 2)
        //    transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, Time.deltaTime * 3.0f);
        //float distance = Vector3.Distance(targetPlayer.transform.position, transform.position);
        //if (distance > 2)
        //transform.Translate(transform.forward * 10.0f * Time.deltaTime, Space.World);
        //transform.position += transform.forward * 10.0f * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, targetPlayer.transform.position, Time.deltaTime * 3.0f);

        rb.MoveRotation(Quaternion.Slerp(rb.rotation, Quaternion.LookRotation(lookDir), 20 * Time.deltaTime));
        //if (distance > 3)
        {
            rb.MovePosition(transform.position + (transform.forward * Time.deltaTime * moveSpeed));
        }
    }
}
