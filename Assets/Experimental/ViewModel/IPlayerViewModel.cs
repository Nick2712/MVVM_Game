using UnityEngine;
using System;


namespace Experimental
{
    public interface IPlayerViewModel
    {
        IPlayerModel PlayerModel { get; }
        void AplyDamage(float damageValue);
        void MovePlayer(Vector2 position);
        void RotatePlayer(Quaternion rotation);
        event Action<float> OnHPChange;
        event Action<Vector2> OnPlayerMove;
        event Action<Quaternion> OnPlayerRotate;
    }
}