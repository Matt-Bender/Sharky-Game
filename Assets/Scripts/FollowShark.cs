using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShark : MonoBehaviour
{
    [SerializeField] private GameObject sharkPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(sharkPlayer.transform.position.x, sharkPlayer.transform.position.y, -10);
    }
}
