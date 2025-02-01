using UnityEngine;

public class gunswap : MonoBehaviour
{
    [SerializeField] private GameObject Pistol;
    [SerializeField] private GameObject FakePistol;
    [SerializeField] private GameObject Shotgun;
    [SerializeField] private GameObject FakeShotgun;
    [SerializeField] private bool IsUsingPistol = true;

    private void Update()
    {
        if (IsUsingPistol == true)
        {
            Pistol.SetActive(true);
            FakePistol.SetActive(false);
            Shotgun.SetActive(false);
            FakeShotgun.SetActive(true);
        }

        if (IsUsingPistol == false)
        {
            FakePistol.SetActive(true);
            Pistol.SetActive(false);
            Shotgun.SetActive(true);
            FakeShotgun.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            IsUsingPistol = !IsUsingPistol;
        }
    }

}
