﻿using UniGLTF;

namespace UniVRM10
{
    public static class Vrm10MaterialExporterUtility
    {
        public static IMaterialExporter GetValidVrm10MaterialExporter()
        {
            return RenderPipelineUtility.GetRenderPipelineType() switch
            {
                RenderPipelineTypes.UniversalRenderPipeline => throw new System.NotImplementedException(),
                RenderPipelineTypes.BuiltinRenderPipeline => new BuiltInVrm10MaterialExporter(),
                _ => new BuiltInVrm10MaterialExporter(),
            };
        }
    }
}