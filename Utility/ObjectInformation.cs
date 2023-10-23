using UnityEngine;

public struct objectInfo
{
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;
    public float   currentAnimation;
    public float   animationLength;
    public float   animationScale;
    public float   time;
    public uint    isLooping;
    public uint    isRendered;
}