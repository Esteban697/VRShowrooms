using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureUp : MonoBehaviour {

    public Vector3 downPos;
    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        downPos = transform.position;
        audioSource.Play();
        iTween.MoveTo(this.gameObject,
                iTween.Hash(
                    "position", new Vector3(downPos.x, downPos.y + 2.92f, downPos.z),
                    "time", 3.2f,
                    "easetype", "linear"
                )
        );

    }
}
