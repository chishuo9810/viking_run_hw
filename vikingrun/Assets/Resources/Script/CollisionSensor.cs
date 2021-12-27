using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]
public class CollisionSensor : MonoBehaviour {
    public int SceneIndexDestination = 0;
    Animator animator;
    public bool die=false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Viking_Axes")
        {
            //Scene scene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(SceneIndexDestination);
            //die = true;
            //animator.SetBool("Die",die);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
