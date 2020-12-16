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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("on door collider");
            /*Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);*/

            int gridSize = tilemap.GetComponent<TilemapOceanGeneratorChaser>().gridSize;
            //float randomFillPercent = tilemap.GetComponent<TilemapOceanGeneratorChaser>().randomFillPercent;
            t = tilemap.GetComponent<TilemapOceanGeneratorChaser>();
            Debug.Log((int)(gridSize * 1.1) + " gridsize ");
            t.OceanGeneratorC.RandomizeMap((int)(gridSize * 1.1));
            t.setGridSize((int)(gridSize * 1.1));
            Debug.Log(tilemap.GetComponent<TilemapOceanGeneratorChaser>().gridSize + "dnsjgdkngldsangks. ");
            t.GenerateAndDisplayTexture(t.OceanGeneratorC.GetMap());
            StartCoroutine(t.SimulateCavePattern());
            /* OceanGeneratorChaser OceanGeneratorC = new OceanGeneratorChaser(randomFillPercent, gridSize);
             OceanGeneratorC.RandomizeMap(gridSize);*/

        }
    }
}