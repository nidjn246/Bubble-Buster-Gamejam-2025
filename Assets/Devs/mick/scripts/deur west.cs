using Unity.VisualScripting;
//using UnityEditor.Build;
using UnityEngine;

public class deurWest : MonoBehaviour
{
    [SerializeField] private Animator DoorOpen = null;
    [SerializeField] private Animator DoorClosed = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "kaaas";
    [SerializeField] private string doorClose = "DoorClose";

    private void Start()
    {
        DoorOpen = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!openTrigger)
        {
            Debug.Log("trigger door open");
            DoorOpen.Play("kaaas", 0, 0f);
            //gameObject.SetActive(false);
        }

        else if (closeTrigger)
        {
            DoorClosed.Play("doorClose", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
}

