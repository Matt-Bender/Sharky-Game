using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPatrol : MonoBehaviour
{

    private Rigidbody2D rbFish;
    private bool goingLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        rbFish = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (goingLeft)
        {
            GoLeft();
        }
        else
        {
            GoRight();
        }
    }
    //When colliding with something reverse direction
    //Rotate accordingly
    private void OnCollisionEnter2D(Collision2D collision)
    {
        goingLeft = !goingLeft;
        if (goingLeft)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    private void GoLeft()
    {
        rbFish.velocity = new Vector3(-300 * Time.deltaTime, 0);
    }

    private void GoRight()
    {
        rbFish.velocity = new Vector3(300 * Time.deltaTime, 0);
    }
}
