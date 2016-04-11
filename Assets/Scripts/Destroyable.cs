using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip destroySound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Projectile"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(destroySound);
            }
                Destroy(gameObject);

        }
    }
}
