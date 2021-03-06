using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnLoad : MonoBehaviour
{
    public GameObject track = null;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = (GameObject)Resources.Load("PreFab/Circle", typeof(GameObject));
        for (int i = -10; i < 10; i++)
        {
            for(int j = -10; j < 10; j++)
            {
                var newgo = Instantiate(go, new Vector3(i*1.7f + Random.Range(-0.3f, 0.3f), j * 1.7f + Random.Range(-0.3f, 0.3f), 1), new Quaternion());
                SpriteRenderer sprite = (SpriteRenderer)newgo.gameObject.GetComponent<SpriteRenderer>();
                sprite.color = new Color(Random.value, Random.value, Random.value, 1f);
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
