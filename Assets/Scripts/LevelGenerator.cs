using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;
    [SerializeField] private Transform LevelPart_Start;
    [SerializeField] private Transform Level_gene;  
    private Vector3 lastEndPosition;
    private void Awake()
    {
        lastEndPosition = LevelPart_Start.Find("EndPosition").position;
        SpawnLevelPart();
        SpawnLevelPart();
        //Transform lastLevelPartTransform;
        //lastLevelPartTransform = SpawnLevelPart(LevelPart_Start.Find("EndPosition").position);
        //lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
    }

    private void SpawnLevelPart() {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }
    private Transform SpawnLevelPart(Vector3 SpawnPosition)
    {
        Transform LevelPartTransform = Instantiate(Level_gene, SpawnPosition, Quaternion.identity);
        return LevelPartTransform;
    }
}
