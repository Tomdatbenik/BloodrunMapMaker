using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonGen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        List<TrapInfo> traps = new List<TrapInfo>();

        IEnumerable<GameObject> SpikeTraps = GameObject.FindGameObjectsWithTag("SpikeTrap");
        IEnumerable<GameObject> Darter = GameObject.FindGameObjectsWithTag("Darter");
        IEnumerable<GameObject> AlwaysActiveTrap = GameObject.FindGameObjectsWithTag("AlwaysActiveTrap");
        IEnumerable<GameObject> RotatingDarter = GameObject.FindGameObjectsWithTag("RotatingDarter");
        IEnumerable<GameObject> RotateTrap = GameObject.FindGameObjectsWithTag("RotateTrap");
        IEnumerable<GameObject> Spawns = GameObject.FindGameObjectsWithTag("Spawn");
        GameObject Finish = GameObject.FindGameObjectWithTag("Finish");
        IEnumerable<GameObject> Chekpoints = GameObject.FindGameObjectsWithTag("Checkpoint");

        int i = 1;

        foreach (GameObject trap in SpikeTraps)
        {
            LocationInfo location = new LocationInfo();
            location.x = trap.transform.position.x.ToString();
            location.y = trap.transform.position.y.ToString();
            location.z = trap.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = trap.transform.rotation.x.ToString();
            rotation.y = trap.transform.rotation.y.ToString();
            rotation.z = trap.transform.rotation.z.ToString();
            rotation.w = trap.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = trap.transform.localScale.x.ToString();
            scale.y = trap.transform.localScale.y.ToString();
            scale.z = trap.transform.localScale.z.ToString();

            traps.Add(new TrapInfo(i, transform, scale, TrapType.SpikeTrap));
            i++;
        }

        foreach (GameObject trap in Darter)
        {
            LocationInfo location = new LocationInfo();
            location.x = trap.transform.position.x.ToString();
            location.y = trap.transform.position.y.ToString();
            location.z = trap.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = trap.transform.rotation.x.ToString();
            rotation.y = trap.transform.rotation.y.ToString();
            rotation.z = trap.transform.rotation.z.ToString();
            rotation.w = trap.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = trap.transform.localScale.x.ToString();
            scale.y = trap.transform.localScale.y.ToString();
            scale.z = trap.transform.localScale.z.ToString();

            traps.Add(new TrapInfo(i, transform, scale, TrapType.Darter));
            i++;
        }

        foreach (GameObject trap in AlwaysActiveTrap)
        {
            LocationInfo location = new LocationInfo();
            location.x = trap.transform.position.x.ToString();
            location.y = trap.transform.position.y.ToString();
            location.z = trap.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = trap.transform.rotation.x.ToString();
            rotation.y = trap.transform.rotation.y.ToString();
            rotation.z = trap.transform.rotation.z.ToString();
            rotation.w = trap.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = trap.transform.localScale.x.ToString();
            scale.y = trap.transform.localScale.y.ToString();
            scale.z = trap.transform.localScale.z.ToString();

            traps.Add(new TrapInfo(i, transform, scale, TrapType.AlwaysActiveTrap));
            i++;
        }

        foreach (GameObject trap in RotatingDarter)
        {
            LocationInfo location = new LocationInfo();
            location.x = trap.transform.position.x.ToString();
            location.y = trap.transform.position.y.ToString();
            location.z = trap.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = trap.transform.rotation.x.ToString();
            rotation.y = trap.transform.rotation.y.ToString();
            rotation.z = trap.transform.rotation.z.ToString();
            rotation.w = trap.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = trap.transform.localScale.x.ToString();
            scale.y = trap.transform.localScale.y.ToString();
            scale.z = trap.transform.localScale.z.ToString();

            traps.Add(new TrapInfo(i, transform, scale, TrapType.RotatingDarter));
            i++;
        }

        foreach (GameObject trap in RotateTrap)
        {
            LocationInfo location = new LocationInfo();
            location.x = trap.transform.position.x.ToString();
            location.y = trap.transform.position.y.ToString();
            location.z = trap.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = trap.transform.rotation.x.ToString();
            rotation.y = trap.transform.rotation.y.ToString();
            rotation.z = trap.transform.rotation.z.ToString();
            rotation.w = trap.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = trap.transform.localScale.x.ToString();
            scale.y = trap.transform.localScale.y.ToString();
            scale.z = trap.transform.localScale.z.ToString();

            traps.Add(new TrapInfo(i, transform, scale, TrapType.RotateTrap));
            i++;
        }

        int player = 0;
        List<SpawnPoints> spawnpoints = new List<SpawnPoints>(); ;
        foreach (GameObject Spawn in Spawns)
        {
            LocationInfo location = new LocationInfo();
            location.x = Spawn.transform.position.x.ToString();
            location.y = Spawn.transform.position.y.ToString();
            location.z = Spawn.transform.position.z.ToString();

            SpawnPoints spawnPoints = new SpawnPoints();

            spawnPoints.location = location;
            spawnPoints.Player = player;

            spawnpoints.Add(spawnPoints);

            player++;
        }

        DungeonInfo dungeonInfo = new DungeonInfo();

        dungeonInfo.traps = traps;
        dungeonInfo.spawnpoints = spawnpoints;

        FinishInfo finish = new FinishInfo();
        
        ScaleInfo FinishScale = new ScaleInfo();
        FinishScale.x = Finish.transform.localScale.x.ToString();
        FinishScale.y = Finish.transform.localScale.y.ToString();
        FinishScale.z = Finish.transform.localScale.z.ToString();

        LocationInfo FinishLocation = new LocationInfo();
        FinishLocation.x = Finish.transform.position.x.ToString();
        FinishLocation.y = Finish.transform.position.y.ToString();
        FinishLocation.z = Finish.transform.position.z.ToString();

        RotationInfo FinisRotation = new RotationInfo();
        FinisRotation.x = Finish.transform.rotation.x.ToString();
        FinisRotation.y = Finish.transform.rotation.y.ToString();
        FinisRotation.z = Finish.transform.rotation.z.ToString();
        FinisRotation.w = Finish.transform.rotation.w.ToString();

        finish.scale = FinishScale;
        
        finish.transform.rotation = FinisRotation;
        finish.transform.location = FinishLocation;
        dungeonInfo.finish = finish;

        foreach (GameObject checkpoint in Chekpoints)
        {
            LocationInfo location = new LocationInfo();
            location.x = checkpoint.transform.position.x.ToString();
            location.y = checkpoint.transform.position.y.ToString();
            location.z = checkpoint.transform.position.z.ToString();

            RotationInfo rotation = new RotationInfo();
            rotation.x = checkpoint.transform.rotation.x.ToString();
            rotation.y = checkpoint.transform.rotation.y.ToString();
            rotation.z = checkpoint.transform.rotation.z.ToString();
            rotation.w = checkpoint.transform.rotation.w.ToString();

            TransformInfo transform = new TransformInfo();
            transform.location = location;
            transform.rotation = rotation;

            ScaleInfo scale = new ScaleInfo();
            scale.x = checkpoint.transform.localScale.x.ToString();
            scale.y = checkpoint.transform.localScale.y.ToString();
            scale.z = checkpoint.transform.localScale.z.ToString();

            CheckpointInfo checkpointInfo = new CheckpointInfo();
            checkpointInfo.transform = transform;
            checkpointInfo.scale = scale;

            dungeonInfo.checkpoints.Add(checkpointInfo);
        }

        Debug.Log(dungeonInfo.ToJson());

    }
}

internal class DungeonInfo
{

    public List<TrapInfo> traps = new List<TrapInfo>();
    public List<SpawnPoints> spawnpoints = new List<SpawnPoints>();
    public List<CheckpointInfo> checkpoints = new List<CheckpointInfo>();
    public FinishInfo finish = new FinishInfo();

    public string ToJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }

}

internal class SpawnPoints
{
    public int Player;
    public LocationInfo location;
}

