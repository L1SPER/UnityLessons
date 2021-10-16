using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    // Update is called once per frame
    public void Respawn()
    {
        gameObject.transform.position = transform.position;
    }
}
