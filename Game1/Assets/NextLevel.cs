using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public Transform Target;
    public Transform Key;
    int id = 0;
    int MaxDist = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Key.position) <= MaxDist )
        {
            id = 1;
            Debug.Log("Find the key!");
        }

        if (Vector3.Distance(transform.position, Target.position) <= MaxDist & id==1)
        {
            id = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Game Completed!!!");
        }

        
    }

}
