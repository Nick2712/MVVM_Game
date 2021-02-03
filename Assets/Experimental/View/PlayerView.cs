using UnityEngine;


namespace Experimental
{
    public class PlayerView
    {
        private GameObject _playerObject;
        private IPlayerViewModel _playerViewModel;

        public PlayerView(IPlayerViewModel playerViewModel)
        {
            _playerViewModel = playerViewModel;
            _playerObject = Object.Instantiate(Resources.Load("Ship") as GameObject);
            _playerViewModel.OnHPChange += OnHPChange;
            OnHPChange(_playerViewModel.PlayerModel.CurrentHP);
            _playerViewModel.OnPlayerMove += OnPlayerMove;
            _playerViewModel.OnPlayerRotate += OnPlayerRotation;
        }

        private void OnHPChange(float value)
        {
            string mesage = (_playerViewModel.PlayerModel.CurrentHP <= 0) ? "Труп" : value.ToString();
            Debug.Log(mesage);
        }

        private void OnPlayerMove(Vector2 position)
        {
            _playerObject.transform.position = position;
        }

        private void OnPlayerRotation(Quaternion rotation)
        {
            _playerObject.transform.rotation = rotation;
        }

        ~PlayerView()
        {
            _playerViewModel.OnHPChange -= OnHPChange;
            _playerViewModel.OnPlayerMove -= OnPlayerMove;
            _playerViewModel.OnPlayerRotate -= OnPlayerRotation;
        }
    }
}