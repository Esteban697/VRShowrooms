using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateSpeakers : MonoBehaviour {


    public GameObject speakerObject1, speakerObject2;

    // Use this for initialization
    public void TurnSpeakersOff(bool turner)
    {
        speakerObject1.GetComponent<EventTrigger>().enabled = turner;
        speakerObject2.GetComponent<EventTrigger>().enabled = turner;
    }
}

