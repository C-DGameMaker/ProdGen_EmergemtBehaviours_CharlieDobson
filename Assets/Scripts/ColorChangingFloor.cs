using UnityEngine;

public class ColorChangingFloor : MonoBehaviour
{
    private Renderer _cubeRenderer;
    private float _timer;

    public float _changeColor = 1f;

    private void Start()
    {
        _cubeRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _changeColor)
        {
            ChangeColor();
            _timer = 0f;
        }
    }

    private void ChangeColor()
    {
        _cubeRenderer.material.color = Random.ColorHSV(0f, 1f, 0.5f, 1f);
    }
}
