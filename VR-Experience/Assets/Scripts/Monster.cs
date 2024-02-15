using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    GameObject player;

    public float timer;
    public float time;

    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        timer = Random.Range(4, 7);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, .01f);

        if (time >= timer)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position, 1.0f);
            SetTimer();
        }
    }

    void SetTimer()
    {
        timer = Random.Range(4, 7);
    }
}
