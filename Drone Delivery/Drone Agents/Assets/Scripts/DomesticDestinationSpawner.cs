using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DomesticDestinationSpawner : MonoBehaviour
{
    public GameObject DestinationPrefab;
    public FleetManager takeawayFleetManager;
    public FleetManager parcelFleetManager;
    public bool drawGrid;
    public bool drawNetworkConnections;
    public bool PersistentGizmos;

    // The length and width of the spawn grid
    public Vector2 gridSize;

    // Number of cells in the rows and columns of the grid
    public Vector2Int takeawayGridNum;
    public Vector2Int parcelGridNum;


    public float height = 50f;

    private void Start()
    {
        // This is horrendously inefficient, but I don't want to waste time optimising code if
        // I can get away with it running all right
        SpawnDestinations(takeawayGridNum, takeawayFleetManager);
        SpawnDestinations(parcelGridNum, parcelFleetManager);
    }

    void DrawGridAndConnections()
    {
        if (!(takeawayGridNum.x == 0 && takeawayGridNum.y == 0))
        {
            Vector2 cellSize = gridSize / takeawayGridNum;

            float xoffset = transform.position.x;
            float yoffset = transform.position.z;

            // Using this to make sure I get the edge of the grid and floating point rounding doesn't scupper me
            for (float x = xoffset - gridSize.x / 2f; x < xoffset + gridSize.x / 2f; x += cellSize.x)
            {
                for (float y = yoffset - gridSize.y / 2f; y < yoffset + gridSize.y / 2f; y += cellSize.y)
                {
                    if (drawGrid)
                    {
                        Gizmos.color = GizmoColourSettings.DestinationColour;
                        // Draw the cell boundaries - there are gonna be overlaps here but meh
                        Gizmos.DrawLine(new Vector3(x, height, y), new Vector3(x + cellSize.x, height, y));
                        Gizmos.DrawLine(new Vector3(x + cellSize.x, height, y), new Vector3(x + cellSize.x, height, y + cellSize.y));
                        Gizmos.DrawLine(new Vector3(x, height, y), new Vector3(x, height, y + cellSize.y));
                        Gizmos.DrawLine(new Vector3(x, height, y + cellSize.y), new Vector3(x + cellSize.x, height, y + cellSize.y));
                    }

                    if (drawNetworkConnections)
                    {
                        float xp = x + (cellSize.x / 2f);
                        float yp = y + (cellSize.y / 2f);

                        if (takeawayFleetManager)
                        {
                            if (takeawayFleetManager.hangars != null && takeawayFleetManager.hangars.Length > 0)
                            {
                                Gizmos.color = GizmoColourSettings.TakeawayConnectionColour;
                                for (int i = 0; i < takeawayFleetManager.hangars.Length; i++)
                                {
                                    Gizmos.DrawLine(new Vector3(xp, height, yp), takeawayFleetManager.hangars[i].position);
                                }
                            }
                        }

                        if (parcelFleetManager)
                        {
                            if (parcelFleetManager.hangars != null && parcelFleetManager.hangars.Length > 0)
                            {
                                Gizmos.color = GizmoColourSettings.ParcelConnectionColour;
                                for (int i = 0; i < parcelFleetManager.hangars.Length; i++)
                                {
                                    Gizmos.DrawLine(new Vector3(xp, height, yp), parcelFleetManager.hangars[i].position);
                                }
                            }
                        }
                    }
                }
            }

            // I know... two loops instead of one - but I want the cubes drawing over the top of the connection lines
            // Using this to make sure I get the edge of the grid and floating point rounding doesn't scupper me
            if (drawNetworkConnections)
            {
                for (float x = xoffset - gridSize.x / 2f; x < xoffset + gridSize.x / 2f; x += cellSize.x)
                {
                    for (float y = yoffset - gridSize.y / 2f; y < yoffset + gridSize.y / 2f; y += cellSize.y)
                    {
                        float xp = x + (cellSize.x / 2f);
                        float yp = y + (cellSize.y / 2f);

                        Gizmos.color = GizmoColourSettings.DestinationColour;
                        Gizmos.DrawCube(new Vector3(xp, height, yp), Vector3.one * 10f);
                    }
                }
            }



        }
    }

    void OnDrawGizmosSelected()
    {
        if (!PersistentGizmos)
        {
            DrawGridAndConnections();
        }
    }

    void OnDrawGizmos()
    {
        if (PersistentGizmos)
        {
            DrawGridAndConnections();
        }
    }

    public static System.Random rand = new System.Random(2);
    public float requestRange = 3600f;

    void SpawnDestinations(Vector2Int gridNum, FleetManager manager)
    {
        if (DestinationPrefab)
        {
            Vector2 cellSize = gridSize / gridNum;
            float xoffset = transform.position.x;
            float yoffset = transform.position.z;
            
            float startX = (cellSize.x / 2f) + xoffset - (gridSize.x / 2f);
            float endX = xoffset + (gridSize.x / 2f) - (cellSize.x / 2f);

            float startY = (cellSize.y / 2f) + yoffset - (gridSize.y / 2f);
            float endY = yoffset + (gridSize.y / 2f) - (cellSize.y / 2f);

            Vector3 pos;
            int skipped = 0;

            // Using this to make sure I get the edge of the grid and floating point rounding doesn't scupper me
            for (float x = startX; x <= endX; x += cellSize.x)
            {
                for (float y = startY; y <= endY; y += cellSize.y)
                {
                    pos = new Vector3(x, height, y);

                    // Need this check so we don't spawn a destination that can't be reached
                    if (NavMesh.SamplePosition(pos, out _, 1f, NavMesh.AllAreas))
                    {
                        DeliveryDestination deliveryDestination = Instantiate(DestinationPrefab, pos, Quaternion.identity, transform).GetComponent<DeliveryDestination>();
                        
                        // Takeaways
                        deliveryDestination.manager = manager;
                        deliveryDestination.requestRate = requestRange * (float)rand.NextDouble();
                    }
                    else
                    {
                        skipped++;
                    }
                }
            }

            if(skipped > 0)
            {
                Debug.LogWarning(skipped.ToString() + " destinations skipped for spawner: " + gameObject.name);
            }
        }
    }

}
