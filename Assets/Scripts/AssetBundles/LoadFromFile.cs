using System.IO;
using UnityEngine;

public class LoadFromFile : MonoBehaviour
{
    [SerializeField] private string nameAssetBundle;
    [SerializeField] private string path;
    void Start() 
    {
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(path, nameAssetBundle));
        if (myLoadedAssetBundle == null) 
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("TestCube");
        Instantiate(prefab);
    }
}