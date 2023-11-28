using Unity.VisualScripting;
using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    //Delegados 
    public delegate void Escape();
    public delegate void Enter();

    //Eventos
    public static event Escape OnEscapeKeyPressed;
    public static event Enter OnEnterKeyPressed;


    //Evento que se ejecutará cuando pulsemos Escape
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

    //Evento que se ejecutará cuando pulsemos Enter
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

    //Llamada a las funciones 
    private void Update()
    {
        PressEnter();
        PressEscape();
    }
}
