using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsound : MonoBehaviour
{

    private AudioSource source;

    public AudioClip coinClip;

    private float volLowRange = .5f;

    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
	private void OnCollisionStay2D(Collision2D collision)
	{
        float vol = Random.Range(volLowRange, volHighRange); 
        source.PlayOneShot(coinClip);
	}
}