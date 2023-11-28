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

    //Subscripci�n de las funciones a los Eventos
    public void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed += StopParticleSystem;
    }

    //DesSubscripci�n de las funciones a los Eventos
    public void OnDisable()
    {
        EventsGameManager.OnEnterKeyPressed -= StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed -= StopParticleSystem;
    }
}
