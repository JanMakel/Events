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

    public void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += UpdateText;
        EventsGameManager.OnEscapeKeyPressed += InitializeText;
    }

    public void OnDisable()
    {
       EventsGameManager.OnEnterKeyPressed -= UpdateText;
       EventsGameManager.OnEscapeKeyPressed -= InitializeText;
    }
}
