using Unity.Mathematics;
using UnityEngine;

public class Gun : MonoBehaviour
{
   [SerializeField] private Rigidbody Bullet;
   [SerializeField] private GameObject FireLocation;
   [SerializeField] private float Speed;
    private float cooldown;
    void Update()
    { 
        cooldown = cooldown - Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (cooldown <= 0)
            {
            Rigidbody bulletclone;
            bulletclone = Instantiate(Bullet, FireLocation.transform.position, FireLocation.transform.rotation);
            bulletclone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);
            cooldown = 0.2f;
            }
        }
    }
}
