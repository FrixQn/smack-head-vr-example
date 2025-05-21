using UnityEngine;

namespace TestProject.Core.SoundsSystem
{
    public interface IAudioClipsLibrary
    {
        AudioClip FindClip(string name, bool throwIfNotFound = false);
    }
}
