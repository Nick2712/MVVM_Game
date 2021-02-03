using System;
using UnityEngine;


namespace Experimental
{
    public class PlayerViewModel : IPlayerViewModel
    {
        public IPlayerModel PlayerModel { get; }

        public event Action<float> OnHPChange;
        public event Action<Vector2> OnPlayerMove;
        public event Action<Quaternion> OnPlayerRotate;


        public PlayerViewModel(IPlayerModel playerModel)
        {
            PlayerModel = playerModel;
        }

        public void AplyDamage(float damageValue)
        {
            PlayerModel.CurrentHP -= damageValue;
            OnHPChange?.Invoke(PlayerModel.CurrentHP);
        }

        public void MovePlayer(Vector2 position)
        {
            OnPlayerMove?.Invoke(position);
        }

        public void RotatePlayer(Quaternion rotation)
        {
            OnPlayerRotate?.Invoke(rotation);
        }
    }
}