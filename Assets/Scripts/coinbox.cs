using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinbox : MonoBehaviour
{

    public LayerMask isGround;

    public Transform coinhitbox;

    private bool coinhit;

    public float coinhitwidth;

    public float coinhitheight;

    public int numberOfCoins;

    private AudioSource source;
    public AudioClip coinClip;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start()
    {
        numberOfCoins = 0;
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void FixedUpdate()
    {
        coinhit = Physics2D.OverlapBox(coinhitbox.position, new Vector2(coinhitwidth, coinhitheight), 0, isGround);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("pickUp"))
        {
            other.gameObject.SetActive(false);

            numberOfCoins = numberOfCoins + 1;
        }
    }
}