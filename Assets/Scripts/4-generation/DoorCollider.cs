using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class DoorCollider : MonoBehaviour
{
    [SerializeField] string triggeringTag = null;
    [SerializeField] Tilemap tilemap = null;
    TilemapOceanGeneratorChaser t;
    private void OnTriggerEnter2D(Collider2D other) //this function triggers a creation of a new game tilemap after fish
                                                   // touches the door
    {
        if (other.tag == triggeringTag && enabled)
        {
            
            int gridSize = tilemap.GetComponent<TilemapOceanGeneratorChaser>().gridSize;
            t = tilemap.GetComponent<TilemapOceanGeneratorChaser>();
            t.OceanGeneratorC.RandomizeMap((int)(gridSize * 1.1)); //sets the new tilemap to 10% bigger
            t.setGridSize((int)(gridSize * 1.1));
            t.GenerateAndDisplayTexture(t.OceanGeneratorC.GetMap());
            StartCoroutine(t.SimulateCavePattern());

        }
    }
}