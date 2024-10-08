using System.Collections.Generic;
using UnityEngine;

public class MaterialEmission : MonoBehaviour
{
    public List<GameObject> targetObject;
    void Start()
    {
        ApplyEmissionToAllChildMaterials(targetObject);
    }
    void ApplyEmissionToAllChildMaterials(List<GameObject> objs)
    {
        foreach (GameObject obj in objs)
        {
            Renderer[] renderers = obj.GetComponentsInChildren<Renderer>();
            foreach (Renderer renderer in renderers)
            {
                foreach (Material material in renderer.materials)
                {
                    EnableEmissionWithAlbedoColor(material);
                }
            }
        }
    }

    void EnableEmissionWithAlbedoColor(Material material)
    {
        Color albedoColor = material.GetColor("_Color");
        material.EnableKeyword("_EMISSION");
        material.SetColor("_EmissionColor", albedoColor);
    }
}
