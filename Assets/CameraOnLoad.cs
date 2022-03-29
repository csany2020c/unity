using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnLoad : MonoBehaviour
{
    public GameObject track = null;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = (GameObject)Resources.Load("PreFab/Circle", typeof(GameObject));
        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Instantiate(go, new Vector3(i*1.7f,j * 1.7f, 1), new Quaternion());                
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (track != null)
        {
            transform.position = new Vector3(track.transform.position.x, track.transform.position.y, transform.position.z);
        }
    }
}
