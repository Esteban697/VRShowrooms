using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour {

    public GameObject roomLights;
    public GameObject newLights;
    public GameObject speakers;
    private Vector3 firstPos;

	// Takes the lights out of the room
	public void LightsUp () {
        firstPos = roomLights.transform.position;
        iTween.MoveTo(roomLights,
                iTween.Hash(
                    "position", new Vector3(firstPos.x, firstPos.y + 3.0f, firstPos.z),
                    "time", 1.0f,
                    "easetype", "linear"
                )
        );
        roomLights.SetActive(false);
    }

    // Takes the new lights in
    public void LightsDown()
    {
        newLights.SetActive(true);
        firstPos = speakers.transform.position;
        iTween.MoveTo(speakers,
                iTween.Hash(
                    "position", new Vector3(firstPos.x, firstPos.y + 1.8f, firstPos.z),
                    "time", 2.0f,
                    "easetype", "linear"
                )
        );
    }
    // Takes up the new speakers
    public void NewSpeakers()
    {
        newLights.SetActive(true);
        firstPos = newLights.transform.position;
        iTween.MoveTo(newLights,
                        iTween.Hash(
                            "position", new Vector3(firstPos.x, firstPos.y - 3.0f, firstPos.z),
                            "time", 2.0f,
                            "easetype", "linear"
                        )
                );
    }
}
