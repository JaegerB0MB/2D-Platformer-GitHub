using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above

    public AudioSource audioSource;
    public AudioClip collectSound;

    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

        if (Time.time >= coolDown)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Fire();
                audioSource.PlayOneShot(collectSound);
                animator.SetBool("shoot", true);
                Debug.Log("Test");
            }
            else
            {
                animator.SetBool("shoot", false);
            }
        }
    }

    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), Quaternion.identity) as Rigidbody2D;

        bPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);

        coolDown = Time.time + attackSpeed;
    }
}