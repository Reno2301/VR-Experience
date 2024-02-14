using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject axe;
    public GameObject axePrefab;
    public Vector3 axeOffset;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetAxe();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            axe.GetComponent<Axe>().Throw();
        }
    }

    public void GetAxe()
    {
        axeOffset = transform.forward;

        axe = Instantiate(axePrefab, transform.position + axeOffset, Quaternion.identity, transform);
    }
}
