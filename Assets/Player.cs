using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public static bool IsPlayer(Collider2D col)
    {
        if (col.attachedRigidbody == null)
        {
            return false;
        }
        else if (col.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            return true;
        }
        else return false;
    }
    public static bool IsPlayer(Collision2D col)
    {
        if (col.rigidbody == null)
        {
            return false;
        }
        else if (col.rigidbody.gameObject.CompareTag("Player"))
        {
            return true;
        }
        else return false;
    }



}
