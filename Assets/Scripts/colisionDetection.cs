﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("nasheeeeee");
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
