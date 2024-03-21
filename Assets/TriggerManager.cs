using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //    if(collision.transform.CompareTag("Player"))
        collision.transform.GetComponent<ProjectileMotion>().Jump2();

    }
}
