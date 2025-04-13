using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;
    Vector3 lastPos;
    float distanceToMove;


    private void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
        lastPos = player.transform.position;
    }

    private void Update()
    {
        distanceToMove = player.transform.position.x - lastPos.x;//на какое расстояние нужно сместить камеру
        transform.position = new Vector3(transform.position.x+distanceToMove,
            transform.position.y,
            transform.position.z);//смещение камеры
        lastPos = player.transform.position;//присвоение позиции объекта
    }
}
