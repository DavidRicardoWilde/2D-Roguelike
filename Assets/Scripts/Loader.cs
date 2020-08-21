using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameObject;

    private void Awake()
    {
        if (GameManager.instance == null)
        {
            Instantiate(gameObject);
        }
    }
}
