using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float xMin;
    [SerializeField] float xMax;
    [SerializeField] float moveSpeed=1f;
    [SerializeField] float offset=0.1f;

    // Start is called before the first frame update
    void Start()
    {
        BallBoundraies();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        var xValue = Input.GetAxis("Horizontal") * Time.deltaTime*moveSpeed;
        var newxValue = Mathf.Clamp(transform.position.x + xValue, xMin, xMax);
        var newyValue = Mathf.Clamp(transform.position.y, -8f, 8f);


        transform.position = new Vector2(newxValue, newyValue);
    }
    private void BallBoundraies()
    {
        Camera camera = Camera.main;
        xMin = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + offset;
        xMax = camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - offset;
    }
}
