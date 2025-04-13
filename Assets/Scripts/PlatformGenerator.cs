using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform generatorPoint;
    public Transform destroyPoint;
    public float distanceBetween;
    public float distanceMin;
    public float distanceMax;
    public PlatformMamager[] platformsMamager;   
    int platformSelector;
    float[] platformsWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //platformWidth = platform.GetComponent<BoxCollider2D>().size.x;//получаем размер платформы
        platformsWidth = new float[platformsMamager.Length];
        for(int i = 0; i < platformsMamager.Length; i++)
        {
            platformsWidth[i] = platformsMamager[i].platform.GetComponent<BoxCollider2D>().size.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generatorPoint.position.x)
        {
            distanceBetween = Random.Range(distanceMin, distanceMax);
            platformSelector = Random.Range(0, platformsMamager.Length);
            transform.position = new Vector3(transform.position.x + /*platformsWidth[platformSelector]*/ + distanceBetween,
                transform.position.y,
                transform.position.z);//задаем позицию для новой платформы

            //Instantiate(/*platform*/platforms[platformSelector], transform.position, transform.rotation);
            GameObject activePlatform = platformsMamager[platformSelector].GetPlatform();//активируем платформу
            activePlatform.transform.position = transform.position;
            activePlatform.transform.rotation = transform.rotation;
            activePlatform.SetActive(true);
        }
    }
}
