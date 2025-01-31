using Unity.Mathematics;
using UnityEngine;

public class Gun : MonoBehaviour
{
   [SerializeField] private Rigidbody Bullet;
   [SerializeField] private GameObject FireLocation;
   [SerializeField] private float Speed;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bulletclone;
            Debug.Log("mouse clicked");
            bulletclone = Instantiate(Bullet, FireLocation.transform.position, FireLocation.transform.rotation);
            bulletclone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);
            Debug.Log("bullet spawned");
        }
    }
}
