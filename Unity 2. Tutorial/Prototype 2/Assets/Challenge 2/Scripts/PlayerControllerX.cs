using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0.0f;

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;
        Debug.Log(cooldown);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&cooldown>=1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 0.0f;
        }
    }
}
