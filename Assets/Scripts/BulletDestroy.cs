using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip collectSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Ground"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(collectSound);
            }
            Destroy(gameObject);

        }
    }
}