using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject player;
	float initialx = 12.6f;
	float y = 5.75f;
	float z = -10f;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("MarioHolder");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 myPos = gameObject.transform.position;
        if (player.transform.position.x >= initialx)
        {
            this.gameObject.transform.position = new Vector3(player.transform.position.x, y, z);
        }
    }
}
