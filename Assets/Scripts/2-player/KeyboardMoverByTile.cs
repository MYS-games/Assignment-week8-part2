using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile: KeyboardMover {
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileBase mountains = null;
    [SerializeField] TileBase grass = null;
    [SerializeField] TileBase diamond = null;
    [SerializeField] float speed = 2f;
    private float timeBetweenSteps;

    

    private TileBase TileOnPosition(Vector3 worldPosition) {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void Update()  {
        Vector3 newPosition = NewPosition();
        Vector3 newPositionAfterX = NewPositionAfterX();
        timeBetweenSteps = 1 / speed;
        if (newPositionAfterX != min) //if we did press X:
        {
            TileBase tileOnNewPosition = TileOnPosition(newPositionAfterX);
            if (tileOnNewPosition.Equals(mountains)) // pressed X at a mountain tile :
            {
                StartCoroutine(Example(newPositionAfterX));
              
            }
            else if (tileOnNewPosition.Equals(grass)) //pressed X at a grass tile:
            {
                transform.position = newPositionAfterX;
            }

        }
        else
        {
            TileBase tileOnNewPosition = TileOnPosition(newPosition);
            if (allowedTiles.Contain(tileOnNewPosition))
            {
                transform.position = newPosition;
            }
            else
            {
                Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
            }
        }
    }

    IEnumerator Example(Vector3 v) //this function replaces the mountain tile for a diamond tile and grass tile 
                                    //and waits some time between (to slow the player while carving)
    {
        tilemap.SetTile(tilemap.WorldToCell(v), diamond); //replace to diamond
        yield return new WaitForSecondsRealtime(timeBetweenSteps); //slow the player while carving
        tilemap.SetTile(tilemap.WorldToCell(v), grass); //replace to grass after some time
        transform.position = v; 

    }

}
