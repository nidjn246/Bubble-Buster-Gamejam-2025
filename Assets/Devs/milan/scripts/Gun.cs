using UnityEngine;

public class Gun : MonoBehaviour
{
   [SerializeField] private GameObject Bullet;
   [SerializeField] private GameObject FireLocation;
    void OnMouseDown()
    {
        Debug.Log("mouse clicked");
        Instantiate(Bullet, FireLocation.transform.position, FireLocation.transform.rotation);
        Debug.Log("bullet spawned");
    }
}
