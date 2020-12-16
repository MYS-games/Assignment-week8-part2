using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;



public class TilemapOceanGeneratorChaser : MonoBehaviour
{
    [SerializeField] Tilemap tilemap = null;

    [Tooltip("The tile that represents a reef (an impassable block)")]
    [SerializeField] TileBase reefTile = null;

    [Tooltip("The tile that represents a sea (a passable block)")]
    [SerializeField] TileBase seaTile = null;

    [Tooltip("The tile that represents a fish (a passable block)")]
    [SerializeField] public GameObject fish = null;

    [Tooltip("The tile that represents a Door (a passable block)")]
    [SerializeField] public GameObject Door = null;

    [Tooltip("The tile that represents a enemy 1 (a passable block)")]
    [SerializeField] public GameObject enemy1 = null;

    [Tooltip("The tile that represents a enemy 2 (a passable block)")]
    [SerializeField] public GameObject enemy2 = null;

    [Tooltip("The percent of reefs in the initial random map")]
    [Range(0, 1)]
    [SerializeField] public float randomFillPercent = 0.5f;

    [Tooltip("How many steps do we want to simulate?")]
    [SerializeField] int simulationSteps = 20;

    [Tooltip("For how long will we pause between each simulation step so we can look at the result?")]
    [SerializeField] float pauseTime = 1f;

    [SerializeField] public int gridSize = 20;

    public OceanGeneratorChaser OceanGeneratorC;
   
    void Start()
    {
       
        //To get the same random numbers each time we run the script
        Random.InitState(100);
       
        OceanGeneratorC = new OceanGeneratorChaser(randomFillPercent, gridSize);
        OceanGeneratorC.RandomizeMap(gridSize);

        //For testing that init is working
        GenerateAndDisplayTexture(OceanGeneratorC.GetMap());

        //Start the simulation
        StartCoroutine(SimulateCavePattern());
    }


    //Do the simulation in a coroutine so we can pause and see what's going on
    public IEnumerator SimulateCavePattern()
    {
        for (int i = 0; i < simulationSteps; i++)
        {
            yield return new WaitForSeconds(pauseTime);

            //Calculate the new values
            OceanGeneratorC.SmoothMap();

            //Generate texture and display it on the plane
            GenerateAndDisplayTexture(OceanGeneratorC.GetMap());
        }
        Debug.Log("Simulation completed!");
    }



    //Generate a black or white texture depending on if the pixel is cave or wall
    //Display the texture on a plane
    public void GenerateAndDisplayTexture(int[,] data)
    {
        System.Random rnd = new System.Random();
        int enemy1pos = rnd.Next(1, gridSize - 1);
        int enemy2pos = rnd.Next(1, gridSize - 1);
  
        fish.transform.position = new Vector3(1, 1, 0);
        Door.transform.position = new Vector3(gridSize - 1, gridSize - 1, 0);
        enemy1.transform.position = new Vector3(enemy1pos, enemy1pos, 0);
        enemy2.transform.position = new Vector3(enemy2pos, enemy2pos, 0);
        Debug.Log(gridSize + " gridsize on TILEMAP2 ");
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

                tilemap.SetTile(position, tile);
            }
        }
    }
    public void setGridSize(int newGrid)
    {
        this.gridSize = newGrid;
    }
}