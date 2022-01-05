using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;

namespace BlossomBeloved.Sounds.Item
{
    public class Ahooga : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            soundInstance = sound.CreateInstance();
            soundInstance.Volume = 6f;
            type = SoundType.Item;
            return soundInstance;
        }
    }
}