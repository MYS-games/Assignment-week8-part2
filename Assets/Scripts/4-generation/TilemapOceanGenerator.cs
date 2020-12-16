using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;



public class TilemapOceanGenerator : MonoBehaviour
{
    [SerializeField] Tilemap tilemap = null;

    [Tooltip("The tile that represents a reef (an impassable block)")]
    [SerializeField] TileBase reefTile = null;

    [Tooltip("The tile that represents a sea (a passable block)")]
    [SerializeField] TileBase seaTile = null;

    [Tooltip("The tile that represents a shark (a passable block)")]
    [SerializeField] TileBase sharkTile = null;

    [Tooltip("The tile that represents a bluereef (a passable block)")]
    [SerializeField] TileBase blueReefTile = null;

    [Tooltip("The percent of reefs in the initial random map")]
    [Range(0, 1)]
    [SerializeField] float randomFillPercent = 0.5f;

    [Tooltip("Length and height of the grid")]
    [SerializeField] int gridSize = 100;

    [Tooltip("How many steps do we want to simulate?")]
    [SerializeField] int simulationSteps = 20;

    [Tooltip("For how long will we pause between each simulation step so we can look at the result?")]
    [SerializeField] float pauseTime = 1f;

    private OceanGenerator OceanGenerator;

    void Start()
    {
        //To get the same random numbers each time we run the script
        Random.InitState(100);

        OceanGenerator = new OceanGenerator(randomFillPercent, gridSize);
        OceanGenerator.RandomizeMap();

        //For testing that init is working
        GenerateAndDisplayTexture(OceanGenerator.GetMap());

        //Start the simulation
        StartCoroutine(SimulateCavePattern());
    }


    //Do the simulation in a coroutine so we can pause and see what's going on
    private IEnumerator SimulateCavePattern()
    {
        for (int i = 0; i < simulationSteps; i++)
        {
            yield return new WaitForSeconds(pauseTime);

            //Calculate the new values
            OceanGenerator.SmoothMap();

            //Generate texture and display it on the plane
            GenerateAndDisplayTexture(OceanGenerator.GetMap());
        }
        Debug.Log("Simulation completed!");
    }



    //Generate a black or white texture depending on if the pixel is cave or wall
    //Display the texture on a plane
    private void GenerateAndDisplayTexture(int[,] data)
    {
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                var position = new Vector3Int(x, y, 0);
                var tile = seaTile;
                if (data[x, y] == 1)
                {
                    tile = reefTile;   
                }
                else if (data[x, y] == 2) 
                {
                    tile = sharkTile;
                }
                else if (data[x, y] == 3)
                {
                    tile = blueReefTile;
                }

                tilemap.SetTile(position, tile);
            }
        }
    }
}