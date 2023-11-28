using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        InitializeText();
    }

    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
    }


    //Subscripción de las funciones a los Eventos
    public void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += UpdateText;
        EventsGameManager.OnEscapeKeyPressed += InitializeText;
    }

    //DesSubscripción de las funciones a los Eventos
    public void OnDisable()
    {
       EventsGameManager.OnEnterKeyPressed -= UpdateText;
       EventsGameManager.OnEscapeKeyPressed -= InitializeText;
    }
}
