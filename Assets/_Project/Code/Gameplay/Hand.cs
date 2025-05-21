using UnityEngine;
using UnityEngine.InputSystem;

namespace TestProject.Gameplay
{
    public class Hand : WeaponBase
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private InputActionProperty _gripAnimationAction;

        private void Update()
        {
            _collider.enabled = _gripAnimationAction.action.IsPressed();
        }
    }
}
