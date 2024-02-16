using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    GameObject player;

    public float walkingSpeed;
    public float screamVolume = 0.5f;
    public int timer;
    public float time;

    public float health = 1f;
    public bool isDead;

    public AudioClip clipScream;
    public AudioClip clipDead;

    public GameObject monsterDead;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        timer = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, walkingSpeed * 0.01f);
        transform.LookAt(player.transform);

        if (time >= timer)
        {
            AudioSource.PlayClipAtPoint(clipScream, transform.position, screamVolume);
            SetTimer();
        }

        if(health <= 0 && !isDead)
        {
            isDead = true;
            Dead();
        }
    }

    void SetTimer()
    {
        timer = Random.Range(4, 10);
        time = 0;
    }

    void Dead()
    {
        AudioSource.PlayClipAtPoint(clipDead, transform.position, screamVolume);
        monsterDead = Instantiate(monsterDead, transform.position, Quaternion.identity);
        monsterDead.transform.LookAt(player.transform);
        Destroy(gameObject);
    }
}
