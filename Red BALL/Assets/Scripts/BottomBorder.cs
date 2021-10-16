using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBorder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name); 
        if(collision.gameObject.tag == "Ball")
        {
            FindObjectOfType<HeartSystem>().TakeDamage(1);
            FindObjectOfType<RestartMenu>().setCanvasActive();
        }
    }
}
