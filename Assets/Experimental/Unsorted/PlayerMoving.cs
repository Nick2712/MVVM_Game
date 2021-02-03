using UnityEngine;


namespace Experimental
{
    public class PlayerMoving
    {
        private IPlayerViewModel _playerViewModel;
        private PlayerInput _playerInput;
        private Camera _camera;
        private Vector2 _playerMoving;
        private Vector2 _mousePosition;
        private PlayerModel _playerModel;


        public PlayerMoving(IPlayerViewModel playerViewModel, Camera camera, PlayerModel playerModel)
        {
            _playerViewModel = playerViewModel;
            _camera = camera;
            _playerInput = new PlayerInput();
            _playerModel = playerModel;
        }

        public void Execute()
        {
            _playerMoving = _playerInput.GetMovingInput();
            _mousePosition = _playerInput.GetMousePosition(_camera, _playerModel.PlayerPosition);
        }

        public void FixedExecute(float fixedDeltaTime)
        {
            _playerModel.PlayerPosition = Move(fixedDeltaTime);
            _playerModel.PlayerRotation = Rotation(_mousePosition);
            _playerViewModel.MovePlayer(_playerModel.PlayerPosition);
            _playerViewModel.RotatePlayer(_playerModel.PlayerRotation);
        }

        private Vector2 Move(float fixedDeltaTime)
        {
            Vector2 playerCurrentPosition = _playerModel.PlayerPosition;
            playerCurrentPosition += _playerMoving * _playerModel.Speed * fixedDeltaTime;
            return playerCurrentPosition;
        }

        private Quaternion Rotation(Vector2 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            angle -= 90;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}