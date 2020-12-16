/*using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
*/
/**
 * A graph that represents a tilemap, using only the allowed tiles.
 */
/*
public class TilemapGraphAStar : IGraph<Node>
{
    private Tilemap tilemap;
    private TileBase[] allowedTiles;

    public TilemapGraphAStar(Tilemap tilemap, TileBase[] allowedTiles)
    {
        this.tilemap = tilemap;
        this.allowedTiles = allowedTiles;
    }

    static Vector3Int[] directions = {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 1, 0),
    };



    public IEnumerable<Node> Neighbors(Node current)
    {
        Debug.Log("in N1");
        foreach (var direction in directions)
        {
            Vector3Int neighborPos = current.Position + direction;
            TileBase neighborTile = tilemap.GetTile(neighborPos);
            if (allowedTiles.Contains(neighborTile))
                yield return new Node(neighborPos);
        }
        
    }
}
*/