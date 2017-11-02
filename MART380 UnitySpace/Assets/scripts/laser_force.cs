﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_force : MonoBehaviour {

    public float speed;
    public float lifeTime;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FixedUpdate()
    {
        if (lifeTime == 0)
        {
            Destroy(gameObject);
        }
        else
            lifeTime--;

        transform.position = new Vector3(transform.position.x, transform.position.y, -11);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);

            GameController_Script.IncreaseScore(1);
            Debug.Log(GameController_Script.GetScore());
        }
    }
}
