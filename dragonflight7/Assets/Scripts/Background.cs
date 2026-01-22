using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        Vector2 newOffset = myMaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        myMaterial.mainTextureOffset = newOffset;
    }
}
