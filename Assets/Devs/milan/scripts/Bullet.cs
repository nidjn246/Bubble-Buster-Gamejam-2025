using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float timeleft = 5;
    void Start()
    {
        timeleft = 5;
    }


    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft < 0)
        {
            Destroy(gameObject);
        }
    }

   void OnCollisionEnter(Collision collision)
    {

        
            Destroy(gameObject);
        
    }

}
