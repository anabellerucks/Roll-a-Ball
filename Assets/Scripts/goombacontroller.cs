using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombacontroller : MonoBehaviour {

    private Animator anim;

    public float speed;

    public LayerMask isGround;

    public Transform wallhitbox;

    private bool wallhit;

    public float wallhitwidth; 
     
    public float wallhitheight;

    private AudioSource source;
    public AudioClip deathClip;
    private float volLowRange = .5f; 
    private float volHighRange = 1.0f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    void Awake()  
    { 
        source = GetComponent<AudioSource>(); 
    }
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        wallhit = Physics2D.OverlapBox(wallhitbox.position, new Vector2(wallhitwidth, wallhitheight), 0, isGround);

        if(wallhit == true)
        {
            speed = speed * -1;
        }
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.collider.tag == "player")
        {
            float vol = Random.Range(volLowRange, volHighRange); 
            source.PlayOneShot(deathClip);
            Debug.Log("I Loved Living");
            Destroy(gameObject, 0.25f);
        }
	}

	private void OnDrawGizmosSelected()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallhitbox.position, new Vector3(wallhitwidth, wallhitheight, 1));
	}
}
