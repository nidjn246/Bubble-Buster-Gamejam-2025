using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    private Renderer rend;
    [SerializeField] private int howdirty = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        howdirty--;
        if (howdirty == 1)
        {
            rend.sharedMaterial = materials[1];
        }

        else if (howdirty == 0)
        {
           Destroy(gameObject);
        }
    }

}
