using UnityEngine;

namespace TestProject.Gameplay
{
    public interface IWeapon
    {
        float Damage { get; }
        Vector3 Velocity { get; }
    }
}
