//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////switch the scene to introduction/////////////////////////////////////////////////////
/////////////////////////////////////////////////////////switch the scene to introduction/////////////////////////////////////////////////////
/////////////////////////////////////////////////////////switch the scene to introduction/////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ExplainScene : MonoBehaviour, IPointerClickHandler
{
    public int SceneIndexDestination = 2;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneIndexDestination);
    }
}