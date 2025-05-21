namespace TestProject.Core.SoundsSystem
{
    public interface ISoundsController
    {
        public IAudioClipsLibrary SoundsLibrary { get; }
        void PlaySound(string name);
    }
}
