using UnityEngine;

namespace TestProject.Gameplay
{
    [CreateAssetMenu(fileName = nameof(GameplayConfig), menuName = "Project/Configs/" + nameof(GameplayConfig))]
    public class GameplayConfig : ScriptableObject, IGameplayConfig
    {
        [field: SerializeField] public float HeadHealth { get; set; }
        [field: SerializeField] public float HandDamage { get; set; }
        [field: SerializeField] public float CandleDamage { get; set; }
        [field: SerializeField] public float GlassDamage { get; set; }
    }
}
