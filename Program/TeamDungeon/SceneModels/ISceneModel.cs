using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Dungeon.SceneModels
{
    public abstract class ISceneModel
    {

        public Node2D Scene { get; set; }

        public abstract void Ready();
        public abstract void Process(double delta);
    }
}
