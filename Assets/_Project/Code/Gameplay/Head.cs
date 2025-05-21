using TestProject.Core.SoundsSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VContainer;

namespace TestProject.Gameplay
{
    public class Head : MonoBehaviour
    {
        private const string HIT_SOUND_NAME = "Hit";
        [SerializeField] private ParticleSystem _particle;
        [SerializeField] private DecalProjector _projector;
        private float _maxHealth;
        private float _health;
        private ISoundsController _soundsController;

        [Inject]
        private void OnInject(ISoundsController soundsController)
        {
            _soundsController = soundsController;
        }

        public void Initialize(float maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out IWeapon weapon))
            {
                if (weapon.Velocity.magnitude >= 0.001f)
                {
                    ApplyDamage(weapon.Damage);
                    PlayHitSound();
                    _particle.transform.position = collision.contacts[0].point;
                    PlayParticles();
                }
            }
        }

        private void ApplyDamage(float damage)
        {
            _health -= damage;
            _health = Mathf.Clamp(_health, 0, _maxHealth);
            _projector.fadeFactor = 1f - Mathf.InverseLerp(0, _maxHealth, _health);
        }

        private void PlayHitSound()
        {
            _soundsController.PlaySound(HIT_SOUND_NAME);
        }

        private void PlayParticles()
        {
            if (_particle.isPlaying)
                _particle.Stop();

            _particle.Play();
        }
    }
}
