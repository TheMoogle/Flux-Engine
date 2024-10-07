﻿using Flux.Core;
using Flux.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux
{
    public class TestScene : FScene
    {
        #region tmpMesh
        float[] vertices = {
     0.5f,  0.5f, 0.0f,  // top right
     0.5f, -0.5f, 0.0f,  // bottom right
     0.0f, -0.5f, 0.0f,  // bottom left
     0.0f,  0.5f, 0.0f   // top left
};
        uint[] indices = {  // note that we start from 0!
    0, 1, 3,   // first triangle
    1, 2, 3    // second triangle
};
        #endregion

        #region tmpMesh2
        float[] vertices2 = {
     0.0f,  0.5f, 0.0f,  // top right
     0.0f, -0.5f, 0.0f,  // bottom right
    -0.5f, -0.5f, 0.0f,  // bottom left
    -0.5f,  0.5f, 0.0f   // top left
};
        uint[] indices2 = {  // note that we start from 0!
    0, 1, 3,   // first triangle
    1, 2, 3    // second triangle
};
        #endregion
        StaticMeshAsset mymesh;
        StaticMeshAsset mymesh2;
        Actor RenderTesterActor;
        Actor RenderTesterActor2;
        public override void OnLoad()
        {
            base.OnLoad();
            mymesh = new StaticMeshAsset(vertices, indices);
            mymesh2 = new StaticMeshAsset(vertices2, indices2);
            RenderTesterActor = new QuadActor();
            RenderTesterActor.AddComponent(new StaticMeshComponent(mymesh,false));
            RenderTesterActor2 = new QuadActor();
            RenderTesterActor2.AddComponent(new StaticMeshComponent(mymesh2,true));
        }
    }
}
