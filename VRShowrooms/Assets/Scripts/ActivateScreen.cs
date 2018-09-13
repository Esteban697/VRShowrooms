using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateScreen : MonoBehaviour {

    public GameObject screenObject;

	// Use this for initialization
	public void TurnScreenOn (bool turner) {
        screenObject.GetComponent<EventTrigger>().enabled = turner;
    }
	
}
