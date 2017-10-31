using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_force : MonoBehaviour {

    public float speed;
    private float lifeTime;

    // Use this for initialization
    void Start () {
        lifeTime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lifeTime > 30)
            Destroy(gameObject);
        else
            lifeTime++;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
		
	}

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name.Contains("Target"))
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
    }
}
