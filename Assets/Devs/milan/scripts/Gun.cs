using Unity.Mathematics;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Animator GunAnimation;
   [SerializeField] private Rigidbody Bullet;
   [SerializeField] private GameObject FireLocation;
    private string gunanim = "gunanim";
    private float cooldown;

    private void Start()
    {
        GunAnimation = GetComponent<Animator>();
    }
    void Update()
    { 
        cooldown = cooldown - Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (cooldown <= 0)
            {
                GunAnimation.Play("gun", 0, 0f);
            Rigidbody bulletclone;
            bulletclone = Instantiate(Bullet, FireLocation.transform.position, FireLocation.transform.rotation);
            bulletclone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);
            cooldown = 0.2f;
            }
        }
    }
}
