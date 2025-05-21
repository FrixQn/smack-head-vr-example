using UnityEngine;

namespace TestProject.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        private Vector3 _lastPos;
        public virtual float Damage { get; protected set; }
        public virtual Vector3 Velocity { get; protected set; }

        public void Initialize(float damage)
        {
            Damage = damage;
        }

        protected virtual void Awake()
        {
            _lastPos = transform.position;
        }

        public virtual void FixedUpdate()
        {
            Velocity = transform.position - _lastPos;
            _lastPos = transform.position;
        }
    }
}
