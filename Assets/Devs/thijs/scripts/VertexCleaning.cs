using UnityEngine;

public class VertexCleaning : MonoBehaviour
{
    public float brushSize = 0.1f;
    public float cleaningSpeed = 0.1f;

    private Mesh mesh;
    private Color[] colors;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        colors = new Color[mesh.vertices.Length];
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Color.black; // Start with all dirty
        }
        mesh.colors = colors;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                CleanAtPoint(hit.point);
            }
        }
    }

    void CleanAtPoint(Vector3 worldPoint)
    {
        Vector3[] vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 vertexWorld = transform.TransformPoint(vertices[i]);
            float distance = Vector3.Distance(worldPoint, vertexWorld);

            if (distance < brushSize)
            {
                float cleaningAmount = 1 - (distance / brushSize);
                colors[i].r = Mathf.Min(colors[i].r + cleaningAmount * cleaningSpeed * Time.deltaTime, 1f);
            }
        }

        mesh.colors = colors;
    }
}

