//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////spawn the tile and fence and //////////////////////////////////////////////////////
///////////////////////////////////////////////////////////spawn the tile and fence and //////////////////////////////////////////////////////
///////////////////////////////////////////////////////////spawn the tile and fence and //////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject barToSpawn;
    public GameObject fence;
    public GameObject coinToSpawn;
    public GameObject referenceObject;
    public float timeOffset = 0.55f;
    public float distanceBetweenTiles = 3.0F;
    public float randomValue0 = 0.5f;
    public float randomValue1 = 0.75f;
    public float randomValue2 = 1.0f;
    private Vector3 previousTilePosition;
    private float startTime;
    private float tempTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0),leftDirection=new Vector3(-1,0,0), rightDirection = new Vector3(1, 0, 0),mainDirection2 = new Vector3(0.5f, 0, 1), mainDirection3 = new Vector3(-0.5f, 0, 1);
    private Vector3 coinDirection;
    bool a = true;
    int tool;
    // Start is called before the first frame update
    void Start()
    {
        previousTilePosition = referenceObject.transform.position;
        startTime = Time.time;
        tempTime = Time.time;
        a = true;
    }

    void Update()
    {
        distanceBetweenTiles = 3;
        if (Time.time - startTime > timeOffset)//每0.55秒生成一個地板
        {
            if (Time.time - tempTime > 5||a)//每五秒考慮是否要變換方向
            {
                float t = Random.value;
                if (t <= randomValue0)//生成直線的路
                {
                    direction = mainDirection;
                        tool = 0;
                }
                else if (t > randomValue0 && t <= randomValue1 && tool != 2)//生成往右的路
                {
                    direction = rightDirection;
                    tool = 1;
                }
                else if (t > randomValue1 && t <= randomValue2 && tool != 1)//生成往左的路
                {
                    direction = leftDirection;
                    tool = 2;
                }
                else if (tool == 1)
                {
                    direction = rightDirection;
                }
                else if (tool == 2)
                {
                    direction = leftDirection;
                }
                if (a)//讓一開始的路一定往前
                {
                    direction = mainDirection;
                    tool = 0;
                }

                Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                startTime = Time.time;
                Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));

                previousTilePosition = spawnPos;
                if (!a)
                {
                    tempTime = Time.time;
                }
                a = false;
            }
            else
            {
                if (Random.value > 0.8)                                                               //生成洞
                {
                    distanceBetweenTiles += 2;
                    Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                    startTime = Time.time;
                    Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
                    previousTilePosition = spawnPos;
                }
                else if(Random.value<0.1&& (tool == 0 || tool == 4))
                {
                    direction = mainDirection2;
                    Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                    startTime = Time.time;
                    Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
                    previousTilePosition = spawnPos;
                    direction = mainDirection;
                    tool = 3;
                }
                else if (Random.value < 0.2 && (tool == 0||tool==3))
                {
                    direction = mainDirection3;
                    Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                    startTime = Time.time;
                    Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
                    previousTilePosition = spawnPos;
                    direction = mainDirection;
                    tool = 4;
                }
                else
                {
                    Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                    startTime = Time.time;
                    Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
                    if (Random.value > 0.7)
                    {
                        spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                        Instantiate(barToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
                    }
                    else if (Random.value > 0.7)
                    {
                        if (direction == rightDirection || direction == leftDirection)
                        {
                            spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                            Instantiate(fence, spawnPos, Quaternion.Euler(0, 90, 0));
                        }
                        else
                        {
                            spawnPos = previousTilePosition + distanceBetweenTiles * direction;
                            Instantiate(fence, spawnPos, Quaternion.Euler(0, 0, 0));
                        }
                    }
                    else if(direction==mainDirection)
                    {
                        if (Random.value < 0.6)
                        {
                                coinDirection = new Vector3(0, 0.3f, 1);
                        }
                        else if (Random.value < 0.7 )
                        {
                            coinDirection = new Vector3(0.5f, 0.3f, 1);
                        }
                        else if (Random.value < 0.8  )
                        {
                            coinDirection = new Vector3(-0.5f, 0.3f, 1);
                        }
                        Vector3 spawnPos2 = previousTilePosition + distanceBetweenTiles * coinDirection;
                        Instantiate(coinToSpawn, spawnPos2, Quaternion.Euler(0, -90, 90));
                    }

                    previousTilePosition = spawnPos;
                }
            }
        }
    }
}
