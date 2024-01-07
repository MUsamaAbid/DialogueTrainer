using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlendShape : MonoBehaviour
{
    #region Instance
    public static BlendShape Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    [SerializeField] SkinnedMeshRenderer meshRenderer;
    [SerializeField] float lerpSpeed;

    bool isTalking;
    bool smile;
    bool idle;
    bool sad;
    private void Start()
    {
        //Talking();
    }
    public void Talking()
    {
        idle = false;
        smile = false;
        sad = false;
        isTalking = true;
    }
    public void Idle()
    {
        smile = false;
        isTalking = false;
        sad = false;
        idle = true;
    }
    public void Smile()
    {
        idle = false;
        isTalking = false;
        sad = false;
        smile = true;
    }
    public void Sad()
    {
        idle = false;
        isTalking = false;
        smile = false;
        sad = true;
    }

    private void Update()
    {
        if (isTalking)
        {
            // Calculate the t value using a sine wave for smooth oscillation
            //float t = 0.5f + 0.5f * Mathf.Sin(Time.time * lerpSpeed);

            float randomT = Random.value;
            // Use Lerp to interpolate between 0 and 1
            //float lerpedValue = Mathf.Lerp(0f, 0.75f, t);
            float lerpedValue = Mathf.Lerp(0f, 0.75f, randomT);

            // Print the result or use it in any other way
            meshRenderer.SetBlendShapeWeight(0, lerpedValue);

            float smile = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(1), 0.5f, 1);

            meshRenderer.SetBlendShapeWeight(1, smile);
        }
        if (idle)
        {
            float lerpedValue = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(0), 0, 1);

            meshRenderer.SetBlendShapeWeight(0, lerpedValue);

            float smile = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(1), 0.5f, 1);

            meshRenderer.SetBlendShapeWeight(1, smile);
        }
        if (smile)
        {
            float lerpedValue = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(0), 0.5f, 1);

            meshRenderer.SetBlendShapeWeight(0, lerpedValue);

            float smile = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(1), 0.75f, 1);

            meshRenderer.SetBlendShapeWeight(1, smile);
        }
        if (sad)
        {
            float lerpedValue = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(0), 0f, 1);

            meshRenderer.SetBlendShapeWeight(0, lerpedValue);

            float smile = Mathf.Lerp(meshRenderer.GetBlendShapeWeight(1), 0f, 1);

            meshRenderer.SetBlendShapeWeight(1, smile);
        }
    }
}
