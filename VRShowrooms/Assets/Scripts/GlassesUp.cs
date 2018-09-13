using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesUp : MonoBehaviour {

    public GameObject glasses;
    public GameObject position;
    private Vector3 endPositiion;

    // Use this for initialization
    public void MoveUp()
    {
        endPositiion = position.transform.position;
        iTween.MoveTo(glasses,
                iTween.Hash(
                    "position", new Vector3(endPositiion.x, endPositiion.y, endPositiion.z),
                    "time", 1.0f,
                    "easetype", "linear"
                )
        );

    }
}
