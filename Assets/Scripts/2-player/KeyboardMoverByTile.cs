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
        if (newPositionAfterX != min)
        {
            TileBase tileOnNewPosition = TileOnPosition(newPositionAfterX);
            if (tileOnNewPosition.Equals(mountains))
            {
                //tilemap.SetTile(tilemap.WorldToCell(newPositionAfterX), diamond);
                StartCoroutine(Example(newPositionAfterX));
                //tilemap.SetTile(tilemap.WorldToCell(newPositionAfterX), grass);
                //transform.position = newPositionAfterX;
            }
            else if (tileOnNewPosition.Equals(grass))
            {
                transform.position = newPositionAfterX;
            }
            //timeBetweenSteps = 1 / speed; WaitForSeconds(timeBetweenSteps);

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

    IEnumerator Example(Vector3 v)
    {
        tilemap.SetTile(tilemap.WorldToCell(v), diamond);
        yield return new WaitForSecondsRealtime(timeBetweenSteps);
        tilemap.SetTile(tilemap.WorldToCell(v), grass);
        transform.position = v;

    }

}
