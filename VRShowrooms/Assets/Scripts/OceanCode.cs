using UnityEngine;
using System.Collections;

public class OceanCode : MonoBehaviour
{
    public Material ocean_material;
    public GameObject secondIsland;
    bool firstFlight = false;

    public void WakeOcean()
    {
        Ocean.gameObject.SetActive(true);
        if (firstFlight == false)
        {
            Ocean.gameObject.transform.position = new Vector3(4.50f, -2.0f, 23.50f);
            firstFlight = true;
        }
        Ocean.gameObject.transform.localScale = Vector3.one * 15.0f;
        Ocean.gameObject.GetComponent<MeshRenderer>().material = ocean_material;
        iTween.MoveTo(Ocean.gameObject,
                iTween.Hash(
                    "position", new Vector3(4.50f, 0.2f, 23.50f),
                    "time", 3.0f,
                    "easetype", "linear"
                )
        );

        iTween.MoveTo(secondIsland,
                iTween.Hash(
                    "position", new Vector3(-10.77f, 1.05f, 13.67f),
                    "time", 5.0f,
                    "easetype", "linear"
                )
        );
    }


    void Update()
    {
        if (Ocean.gameObject.activeSelf)
        {
            Ocean.AdjustPitch();
            Ocean.SetSoundPositionRelativeToViewer();
        }
    }
}
