using UnityEngine;


public class PlayerInput
{
    private Vector2 _movingInput;
    private Vector2 _mouseScreenPosition;

    public Vector2 GetMovingInput()
    {
        _movingInput.x = Input.GetAxis("Horizontal");
        _movingInput.y = Input.GetAxis("Vertical");
        return _movingInput;
    }

    internal Vector2 GetMousePosition(Camera camera, Vector2 playerPosition)
    {
        _mouseScreenPosition = Input.mousePosition - camera.WorldToScreenPoint(playerPosition);
        return _mouseScreenPosition;
    }
}
