using UnityEngine;


namespace Experimental
{
    public class Main : MonoBehaviour
    {
        private PlayerViewModel _playerViewModel;
        private PlayerView _playerView;
        private PlayerMoving _playerMoving;


        private void Start()
        {
            var playerModel = new PlayerModel(100, 30);
            _playerViewModel = new PlayerViewModel(playerModel);
            _playerView = new PlayerView(_playerViewModel);
            _playerMoving = new PlayerMoving(_playerViewModel, Camera.main, playerModel);
        }

        private void Update()
        {
            _playerMoving.Execute();
        }

        private void FixedUpdate()
        {
            _playerMoving.FixedExecute(Time.fixedDeltaTime);
        }
    }
}