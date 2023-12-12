using System.Collections.Generic;
using Unity.Assertions;
using Unity.Deformations;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Unity.Rendering
{
    [TemporaryBakingType]
    struct SkinnedMeshRendererBakingData : IComponentData
    {
        public UnityObjectRef<SkinnedMeshRenderer> SkinnedMeshRenderer;
    }
}
