﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

	public GameObject player;

	public bool teleport;

	private float heightAboveWaypoint = 1.8f;


	public void Move (GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player,
				iTween.Hash (
					"position", new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z),
					"time", 2f,
					"easetype", "easeInOutQuad"
                )
			);
		} else {
			player.transform.position = new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z);
		}
	}
}
