using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject destroyPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroyPoint = GameObject.Find("DestroyPoint");    
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyPoint.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
