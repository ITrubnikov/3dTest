using UnityEngine;
using System.Collections;

public class ObjectFactory : MonoBehaviour
{
    public GameObject prefab;
    private int count;
    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
        GameObject obj = Instantiate(prefab, new Vector3(count, 0, 0), Quaternion.identity);
        

        if(count++  > 50)
        {
            Destroy(this);
        }
    }
}
