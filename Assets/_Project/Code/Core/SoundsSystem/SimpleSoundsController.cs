using UnityEngine;
using VContainer;

namespace TestProject.Core.SoundsSystem
{
    public class SimpleSoundsController : MonoBehaviour, ISoundsController
    {
        public IAudioClipsLibrary SoundsLibrary { get; private set; }

        [Inject]
        private void Inject(SoundsLibrary soundsLibrary)
        {
            SoundsLibrary = soundsLibrary;
        }

        public void PlaySound(string name)
        {
            var clip = SoundsLibrary.FindClip(name, true);
            if (clip != null)
            {
                AudioSource.PlayClipAtPoint(clip, transform.position);
            }
        }
    }
}
