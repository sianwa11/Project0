﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollission : MonoBehaviour
{
    public PlayerMovement movement;

     void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}