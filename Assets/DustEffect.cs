using UnityEngine;

public class DustEffect : MonoBehaviour
{
    public ParticleSystem dustParticles;

    private void CreateDust()
    {
        if (dustParticles != null)
            dustParticles.Play();
    }
}
