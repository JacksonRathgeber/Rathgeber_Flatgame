using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    public GameObject TitleTrigger;
    public Player player;
    public AudioMixer mixer;

    private bool bgm_playing = false;

    AudioSource[] AudioSources;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSources = GetComponents<AudioSource>();
        AudioSources[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Player>().is_active && !bgm_playing)
        {
            bgm_playing = true;
            AudioSources[1].Play();
            AudioSources[2].Play();
            AudioSources[3].Play();
            AudioSources[4].Play();
        }

        if (bgm_playing)
        {
            for (int i = 0; i < AudioSources.Length; i++)
            {
                AudioSource a_s = AudioSources[i];
                if (!a_s.isPlaying && i > 4)
                {
                    if (Random.Range(0, 100) > 90)
                    {
                        mixer.SetFloat("cave_pitch", Random.Range(0.8f, 1.2f));
                        a_s.Play();
                    }
                }
            }
        }
    }
}
