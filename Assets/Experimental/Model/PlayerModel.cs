using UnityEngine;


namespace Experimental
{
    public class PlayerModel : IPlayerModel
    {
        private float _currentHP;

        public float CurrentHP 
        {
            get
            {
                return _currentHP;
            }
            set
            {
                _currentHP = value;
                if (_currentHP < 0) _currentHP = 0;
                if (_currentHP > MaxHP) _currentHP = MaxHP;
            } 
        }
        public float Speed { get; }
        public float MaxHP { get; }
        public Vector2 PlayerPosition { get; set; }
        public Quaternion PlayerRotation { get; set; }

        public PlayerModel(float maxHP, float speed)
        {
            _currentHP = maxHP;
            MaxHP = maxHP;
            Speed = speed;
        }
    }
}