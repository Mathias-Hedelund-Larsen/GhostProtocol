﻿using UnityEngine;

/// <summary>
/// This script is for testing purposes
/// </summary>
public class TestScript : MonoBehaviour
{
    [SerializeField] //If it should spawn a clone through the object pool
    private bool _doSpawn = false;

    /// <summary>
    /// Starting method called by unity, used to spawn a clone through the object pool
    /// </summary>
    private void Start()
    {
        if (_doSpawn)
        {
            _doSpawn = false;
            ObjectPool.Instance.Spawn(this);
            SceneManager.Instance.LoadSceneAdditive(SceneID.SampleScene);

            //Instantiating the cameramanager
            var cam = CameraManager.Instance.Cam;
            SaveManager.Instance.StartSave();
        }
    }
}