using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Bundle : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ILoad());
    }

    IEnumerator ILoad()
    {
        AssetBundleCreateRequest async =
            AssetBundle.LoadFromFileAsync(Path.Combine
            (Application.streamingAssetsPath, "itemelement"));

        yield return async;

        AssetBundle local = async.assetBundle;

        if(local == null )
            yield break;
    }
}
