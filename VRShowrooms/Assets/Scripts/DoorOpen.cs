using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    //public GameObject objectToMove;
    public Vector3 firstPos;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        firstPos = transform.position;
        audioSource.Play();
        iTween.MoveTo(this.gameObject,
                iTween.Hash(
                    "position", new Vector3(firstPos.x, firstPos.y + 4.0f, firstPos.z),
                    "time", 3.2f,
                    "easetype", "linear"
                )
        );

    }
	
}
