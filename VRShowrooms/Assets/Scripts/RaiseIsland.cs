using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseIsland : MonoBehaviour {

    public GameObject secondIsland, oceanFloor;
    private Vector3 firstPosition;

    // Raise the rescue island
    public void Raise () {
        iTween.MoveTo(secondIsland,
                   iTween.Hash(
                       "position", new Vector3(-10.77f, 1.05f, 13.67f),
                       "time", 5.0f,
                       "easetype", "linear"
                   )
           );
    }

    // Raise the ocean
    public void RaiseOcean()
    {
        firstPosition = oceanFloor.transform.position;
        if (firstPosition.y <= 1.0f)
        {
            iTween.MoveTo(oceanFloor,
                   iTween.Hash(
                       "position", new Vector3(firstPosition.x, firstPosition.y + 1.05f, firstPosition.z),
                       "time", 2.5f,
                       "easetype", "linear"
                   )
           );
        }
        
    }
}
