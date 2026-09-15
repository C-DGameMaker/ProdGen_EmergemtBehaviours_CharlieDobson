using UnityEngine;

public class RandomColorChange : MonoBehaviour
{
    private Renderer _cubeRenderer;

    private void Start()
    {
        _cubeRenderer = GetComponent<Renderer>();
        ChangeColor();
    }

   

    private void ChangeColor()
    {
        _cubeRenderer.material.color = Random.ColorHSV(0f, 1f, 0.5f, 1f);
    }
}
