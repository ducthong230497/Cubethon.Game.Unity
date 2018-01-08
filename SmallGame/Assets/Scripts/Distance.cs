using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {
    public Transform player;
    public Text distance;
	// Update is called once per frame
	void Update () {
        distance.text = (player.position.z + 4510).ToString("0");
	}
}
