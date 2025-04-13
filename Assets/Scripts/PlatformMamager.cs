using System.Collections.Generic;
using UnityEngine;

public class PlatformMamager : MonoBehaviour
{
    public GameObject platform;
    public int platformCount;
    List<GameObject> platforms;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //создание и заполнение списка платформ
        platforms = new List<GameObject>();
        for (int i = 0; i < platformCount; i++) 
        { 
            GameObject obj = (GameObject)Instantiate(platform);
            obj.SetActive(false);
            platforms.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetPlatform()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            if (!platforms[i].activeInHierarchy)//если платформа не активна вернуть ее в список
            { 
                return platforms[i]; 
            }
        }
        GameObject obj = (GameObject)Instantiate(platform);
        obj.SetActive(false);
        platforms.Add(obj);
        return obj; //активировать платформу
    }
}
