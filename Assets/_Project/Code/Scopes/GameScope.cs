using TestProject.Core.SoundsSystem;
using TestProject.Gameplay;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace TestProject.Scopes
{
    public class GameScope : LifetimeScope
    {
        [SerializeField] private SimpleSoundsController _soundsController;
        [SerializeField] private SoundsLibrary _soundsLibrary;
        [Header("Gameplay")]
        [SerializeField] private GameplayConfig _config;
        [SerializeField] private Head _head;
        [SerializeField] private Hand[] _hands;
        [SerializeField] private Glass _glass;
        [SerializeField] private Candle _candle;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_soundsController).As<ISoundsController>();
            builder.RegisterComponent(_soundsLibrary).AsSelf();

            builder.RegisterComponent(_head).AsSelf();
            builder.RegisterComponent(_config).As<IGameplayConfig>();
            builder.RegisterEntryPoint<GameplayController>().WithParameter(_hands).
                WithParameter(_glass).WithParameter(_candle);
        }
    }
}
