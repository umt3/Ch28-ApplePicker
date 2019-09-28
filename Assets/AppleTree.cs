﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    [Header("Set in Inspector")]


    //prefab for instantiating apples



    public GameObject applePrefab;
    //speed at which tree moves
    public float speed = 1f;

    //distance tree turns

    public float leftAndRightEdge = 10f;

    //chance it will change directions

    public float chanceToChangeDirections = 0.1f;

    //rate at which apples will be inisiated

    public float secondsBetweenAppleDrops = 1f;


    // Start is called before the first frame update
    void Start()
    {

        Invoke("DropApple", 2f);
    }




    void DropApple()
    {

        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
    // Update is called once per frame
    void Update()
    {
        // basic movement

        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


        // changing direction

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);  //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move left

        }
        else if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }


        void FixedUpdate()
        {
            if (Random.value < chanceToChangeDirections)
            {
                speed *= -1;
            }
        }


    }
}
