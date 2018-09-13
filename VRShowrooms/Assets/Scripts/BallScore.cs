using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour {

    public GameObject objectToMove;
    public AudioSource audioSource;
    public AudioSource audioCheers;
    public Vector3 endPosition;
    private Rigidbody rb;

    // Use this for initialization
    public void KickBall()
    {
        endPosition = new Vector3(6.55f, 3.9f, -0.046f);
        audioSource.Play();
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.detectCollisions = true;
        iTween.MoveTo(objectToMove,
                iTween.Hash(
                    "position", new Vector3(endPosition.x, endPosition.y, endPosition.z),
                    //"position", new Vector3(scorePoint.transform.position.x, scorePoint.transform.position.y, scorePoint.transform.position.z),
                    "time", 3f,
                    "easetype", "spring"
                )
        );
        rb.isKinematic = true;
        rb.detectCollisions = false;
        audioCheers.Play();
    }

    public void BallDrop(GameObject ballObject)
    {

        rb = ballObject.GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }
}