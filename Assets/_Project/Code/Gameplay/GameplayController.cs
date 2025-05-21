using VContainer;
using VContainer.Unity;

namespace TestProject.Gameplay
{
    public class GameplayController : IInitializable
    {
        private readonly IGameplayConfig _config;
        private readonly Head _head;
        private readonly Hand[] _hand;
        private readonly Candle _candle;
        private readonly Glass _glass;

        [Inject]
        public GameplayController(IObjectResolver resolver, IGameplayConfig config, Head head, Hand[] hands, Candle candle, Glass glass)
        {
            _config = config;
            _head = head;
            _hand = hands;
            _candle = candle;
            _glass = glass;
            resolver.Inject(_head);
        }

        public void Initialize()
        {
            _head.Initialize(_config.HeadHealth);
            foreach (var hand in _hand)
            {
                hand.Initialize(_config.HandDamage);
            }
            _candle.Initialize(_config.CandleDamage);
            _glass.Initialize(_config.GlassDamage);
        }
    }
}
