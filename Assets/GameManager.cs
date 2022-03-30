using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private new Camera camera;
    private GameObject playerObject;
    private GameObject coinObject;
    private GameObject floor;

    public int points = 0;

    void Start()
    {
        ConfigureCamera();

        playerObject = new GameObject("Player");
        playerObject.AddComponent<Player>();
        
        coinObject = new GameObject("Coin");
        coinObject.AddComponent<Coin>();
        coinObject.transform.position = new Vector3(40, 0, 0);

        floor = new GameObject("Floor");
        //floor.transform.position = new Vector2(0, 0);
        floor.transform.localScale = new Vector2(200, .1f);
        floor.transform.position = new Vector2(floor.transform.localScale.x / 2, floor.transform.localScale.y / 2);
        floor.AddComponent<BoxCollider2D>();
    }

    private void ConfigureCamera() {
        camera = GetComponent<Camera>();
        camera.backgroundColor = Color.black;
        camera.orthographicSize = 10;
        camera.transform.position = new Vector3(camera.orthographicSize * camera.aspect, camera.orthographicSize, -100);
    }

    private void FixedUpdate()
    {
        var targetVector = new Vector3(playerObject.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        if (playerObject.transform.position.x < camera.orthographicSize * camera.aspect) { return; }
        //camY = Mathf.Clamp(playerObject.tra)
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetVector, 0.5f);
        //camera.transform.position = targetVector;
    }
}
