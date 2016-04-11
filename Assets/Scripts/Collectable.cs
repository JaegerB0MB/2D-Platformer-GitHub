using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip collectSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(collectSound);
            }
                Destroy(gameObject);

        }
    }
}
