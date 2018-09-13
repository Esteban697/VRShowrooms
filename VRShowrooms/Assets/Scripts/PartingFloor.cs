using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartingFloor : MonoBehaviour {

    public GameObject floorPart1;
    public GameObject floorPart2;
    public GameObject floorPart3;
    public GameObject bridge;
    private Vector3 firstPos1, firstPos2, firstPos3, firstPos4;

    // Parting floor movement 1
    public void PartingFloor1 () {
        firstPos1 = floorPart1.transform.position;
        iTween.MoveTo(floorPart1,
                iTween.Hash(
                    "position", new Vector3(firstPos1.x, firstPos1.y - 0.2f, firstPos1.z - 6.0f),
                    "time", 5.0f,
                    "easetype", "linear"
                )
        );
    }
	// Parting floor movement 2
    public void PartingFloor2()
    {
        firstPos2 = floorPart2.transform.position;
        iTween.MoveTo(floorPart2,
                iTween.Hash(
                    "position", new Vector3(firstPos2.x + 12.0f, firstPos2.y - 0.2f, firstPos2.z),
                    "time", 5.0f,
                    "easetype", "linear"
                )
        );
    }
    // Parting floor movement 3
    public void PartingFloor3()
    {
        firstPos3 = floorPart3.transform.position;
        iTween.MoveTo(floorPart3,
                iTween.Hash(
                    "position", new Vector3(firstPos3.x, firstPos3.y - 0.2f, firstPos3.z + 9.0f),
                    "time", 5.0f,
                    "easetype", "linear"
                )
        );
    }
    // Raise bridge
    public void RaiseBridge()
    {
        firstPos4 = bridge.transform.position;
        //audioSource.Play();
        iTween.MoveTo(bridge,
                iTween.Hash(
                    "position", new Vector3(firstPos4.x, firstPos4.y + 1.6f, firstPos4.z),
                    "time", 4.5f,
                    "easetype", "linear"
                )
        );
    }
}
