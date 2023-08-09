﻿using System.Collections.Generic;

namespace FModel.Views.Snooper.Animations;

public class Bone
{
    public readonly int Index;
    public readonly int ParentIndex;
    public readonly Transform Rest;
    public string LoweredParentName;

    public int SkeletonIndex = -1;
    public readonly List<int> AnimatedBySequences;

    public Bone(int i, int p, Transform t)
    {
        Index = i;
        ParentIndex = p;
        Rest = t;

        AnimatedBySequences = new List<int>();
    }

    public bool IsRoot => Index == 0 && ParentIndex == -1 && string.IsNullOrEmpty(LoweredParentName);
    public bool IsMapped => SkeletonIndex > -1;
    public bool IsAnimated => AnimatedBySequences.Count > 0;
    public bool IsNative => Index == SkeletonIndex;

    public override string ToString() => $"Mesh Ref '{Index}' is Skel Ref '{SkeletonIndex}'";
}
