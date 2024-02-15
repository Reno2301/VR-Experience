using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    List<Vector3> trackingPos = new List<Vector3>();
    public float velocity = 1000f;

    bool pickedUp = false;
    GameObject parentHand;
    Rigidbody rb;

    public GameObject player;

    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (pickedUp)
        {
            rb.useGravity = false;

            transform.position = parentHand.transform.position;
            transform.rotation = parentHand.transform.rotation;

            if(trackingPos.Count > 15)
            {
                trackingPos.RemoveAt(0);
            }
            trackingPos.Add(transform.position);

            /*float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

            if (triggerRight < 0.1f)
            {
                pickedUp = false;
                Vector3 direction = trackingPos[trackingPos.Count - 1] - trackingPos[0];
                rb.AddForce(direction * velocity);
                rb.useGravity = true;
                rb.isKinematic = false;
                GetComponent<Collider>().isTrigger = false;
            }*/
        }
    }

    private void OnTriggerEnter(Collider other)
    {
/*        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

        if(other.gameObject.tag == "hand" && triggerRight > 0.9f)
        {
            pickedUp = true;
            parentHand = other.gameObject;
        }*/
    }
}
