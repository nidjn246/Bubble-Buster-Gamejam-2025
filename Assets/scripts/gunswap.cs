using UnityEngine;

public class gunswap : MonoBehaviour
{
    [SerializeField] private GameObject Pistol;
    [SerializeField] private GameObject Shotgun;
    [SerializeField] private bool IsUsingPistol = true;

    private void Update()
    {
        if (IsUsingPistol == true)
        {
            Pistol.SetActive(true);
            Shotgun.SetActive(false);
        }

        if (IsUsingPistol == false)
        {
            Pistol.SetActive(false);
            Shotgun.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            IsUsingPistol = !IsUsingPistol;
        }
    }

}
