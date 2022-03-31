using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private new Camera camera;
    private GameObject playerObject;
    private GameObject coinObject;

    private Color backgroundColor = new Color32(142, 253, 130, 1);
    public int points = 0;

    enum CreationType {
        Row,
        Stair
    }

    void CreateItems(CreationType type, Vector2 startPosition, int count)
    {
        switch (type)
        {
            case CreationType.Row:
                for (int i = 0; i < count; i++)
                {
                    var cube = new GameObject("Cube");
                    cube.AddComponent<Cube>();
                    cube.transform.position = new Vector2(startPosition.x + cube.transform.localScale.x * i, startPosition.y);
                }
                break;
            case CreationType.Stair:
                for (int i = 0; i < count; i++)
                {
                    CreateItems(CreationType.Row, new Vector2(startPosition.x + i, startPosition.y + i), count - i);
                }
                break;
        }
    }

    void Start()
    {
        ConfigureCamera();

        playerObject = new GameObject("Player");
        playerObject.AddComponent<Player>();
        playerObject.transform.position = new Vector3(0, 1, 0);

        coinObject = new GameObject("Coin");
        coinObject.AddComponent<Coin>();
        coinObject.transform.position = new Vector3(20, 3, 0);

        CreateItems(CreationType.Row, new Vector2(0, 0), 25);
        CreateItems(CreationType.Row, new Vector2(30, 0), 25);
        CreateItems(CreationType.Stair, new Vector2(20, 1), 5);
    }

    private void ConfigureCamera() {
        camera = GetComponent<Camera>();
        camera.backgroundColor = backgroundColor;
        camera.orthographicSize = 10;
        camera.transform.position = new Vector3(camera.orthographicSize * camera.aspect, camera.orthographicSize, -100);
    }

    private void FixedUpdate()
    {
        var targetVector = new Vector3(playerObject.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        if (playerObject.transform.position.x < camera.orthographicSize * camera.aspect) { return; }
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetVector, 0.5f);
    }
}
