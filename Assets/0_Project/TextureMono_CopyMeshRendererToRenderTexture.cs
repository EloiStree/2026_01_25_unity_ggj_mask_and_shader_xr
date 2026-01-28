using UnityEngine;
using UnityEngine.Events;

public class TextureMono_CopyMeshRendererToRenderTexture : MonoBehaviour
{
    [Header("Source")]
    [SerializeField] private MeshRenderer m_source;

    [Header("Target")]
    [SerializeField] private RenderTexture m_result;

    [Header("Events")]
    public UnityEvent<RenderTexture> m_onRenderTextureUpdated;

    private Material cachedMaterial;
    private Texture cachedTexture;

    void Awake()
    {
        if (m_source != null && m_source.sharedMaterials.Length > 0)
        {
            cachedMaterial = m_source.sharedMaterials[0];
        }
    }

    void Update()
    {
        if (cachedMaterial == null || m_result == null)
            return;

        Texture sourceTexture = cachedMaterial.mainTexture;
        if (sourceTexture == null)
            return;

        // Optional: skip blit if texture hasn't changed
        if (sourceTexture == cachedTexture)
            return;

        cachedTexture = sourceTexture;

        Graphics.Blit(sourceTexture, m_result);

        m_onRenderTextureUpdated?.Invoke(m_result);
    }
}

