//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////leave the game////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////leave the game////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////leave the game////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ExitGame : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        Application.Quit();
    }
    void Update()
    {
         if (Input.GetKey(KeyCode.Escape))//press esc to leave the game
        {
            Application.Quit(0);
        }
    }
}