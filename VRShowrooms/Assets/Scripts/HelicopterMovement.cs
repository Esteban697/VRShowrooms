using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelicopterMovement : MonoBehaviour {

    public GameObject player;
    public GameObject screenObject;

    public void Move(GameObject highpoint)
    {
            screenObject.GetComponent<EventTrigger>().enabled = false;
            iTween.MoveTo(player,
                iTween.Hash(
                    "position", new Vector3(highpoint.transform.position.x, highpoint.transform.position.y, highpoint.transform.position.z),
                    "time", 3f,
                    "easetype", "linear"
                )
            );
    }

    public void Move2(GameObject rescuepoint)
    {
        iTween.MoveTo(player,
            iTween.Hash(
                "position", new Vector3(rescuepoint.transform.position.x, rescuepoint.transform.position.y, rescuepoint.transform.position.z),
                "time", 5f,
                "easetype", "linear"
            )
        );
        screenObject.GetComponent<EventTrigger>().enabled = true;
    }


}

