using Unity.VisualScripting;
using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    public delegate void Escape();
    public delegate void Enter();


    public static event Escape OnEscapeKeyPressed;
    public static event Enter OnEnterKeyPressed;

    public void PressEscape()
    {
        if (Input.GetKeyDown("escape"))
        {
            if(OnEscapeKeyPressed != null)
            {
                OnEscapeKeyPressed();
            }
            
        }


    }

    public void PressEnter()
    {
        if (Input.GetKeyDown("return"))
        {
            if (OnEnterKeyPressed != null)
            {
                OnEnterKeyPressed();
            }
            
        }
    }


    private void Update()
    {
        PressEnter();
        PressEscape();
    }
}
