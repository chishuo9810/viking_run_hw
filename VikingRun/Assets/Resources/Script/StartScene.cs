//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////switch the scene to the game///////////////////////////////////////////////////////
///////////////////////////////////////////////////////////switch the scene to the game///////////////////////////////////////////////////////
///////////////////////////////////////////////////////////switch the scene to the game///////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour, IPointerClickHandler
{
    public int SceneIndexDestination = 1;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneIndexDestination);
    }
}
