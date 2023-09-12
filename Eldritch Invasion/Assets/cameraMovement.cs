using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    public Transform player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) //é possivel que o jogador morra
        {
            transform.position = Vector2.Lerp(transform.position, player.position, speed);//interpolação
        }

       
    }
}
