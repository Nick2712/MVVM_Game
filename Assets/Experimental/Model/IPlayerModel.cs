using UnityEngine;


namespace Experimental
{
    public interface IPlayerModel
    {
        float CurrentHP { get; set; }
        float MaxHP { get; }
        float Speed { get; }
        Vector2 PlayerPosition { get; set; }
        Quaternion PlayerRotation { get; set; }
    }
}