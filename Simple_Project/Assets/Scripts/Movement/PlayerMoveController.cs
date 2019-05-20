using UnityEngine;

public class PlayerMoveController : MoveController
{
    protected override void Update()
    {
        // Вперед
        if (Input.GetKeyDown(KeyCode.W))
        {
            _input.y = 1f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _input.y = (Input.GetKey(KeyCode.S)) ? -1f : 0f;
        }
        // Назад
        if (Input.GetKeyDown(KeyCode.S))
        {
            _input.y = -1f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _input.y = (Input.GetKey(KeyCode.W)) ? 1f : 0f;
        }
        // Влево
        if (Input.GetKeyDown(KeyCode.A))
        {
            _input.x = -1f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _input.x = (Input.GetKey(KeyCode.D)) ? 1f : 0f;
        }
        // Вправо
        if (Input.GetKeyDown(KeyCode.D))
        {
            _input.x = 1f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _input.x = (Input.GetKey(KeyCode.A)) ? -1f : 0f;
        }
        // Поворот против часовой
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rotateDirection = -1f;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _rotateDirection = (Input.GetKey(KeyCode.E)) ? 1f : 0f;
        }
        // Поворот по часовой
        if (Input.GetKeyDown(KeyCode.E))
        {
            _rotateDirection = 1f;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            _rotateDirection = (Input.GetKey(KeyCode.Q)) ? -1f : 0f;
        }
        base.Update();
    }
}
