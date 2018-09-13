using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateModel : MonoBehaviour {

    public GameObject modelObject1;
    public GameObject modelObject2;

    // Use to turn model off
    public void TurnModelOff1(bool turner)
    {
        modelObject1.GetComponent<EventTrigger>().enabled = turner;
    }

    // Use  to turn model off
    public void TurnModelOff2(bool turner)
    {
        modelObject2.GetComponent<EventTrigger>().enabled = turner;
    }

}
