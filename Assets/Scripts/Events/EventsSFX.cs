using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        StopParticleSystem();
    }

    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }

    public void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed += StopParticleSystem;
    }

    public void OnDisable()
    {
        EventsGameManager.OnEnterKeyPressed -= StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed -= StopParticleSystem;
    }
}
