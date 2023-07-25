using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class Engine
    {
        public Engine()
        {
            gameObjects = new List<GameObject>();
        }

        ~Engine()
        {

        }

        public void Instanciate(GameObject newGameObject)
        {
            gameObjects.Add(newGameObject);
        }

        List<GameObject> gameObjects;

        public void Run()
        {
            GameLoop();
        }

        protected void GameLoop()
        {
            AllGameObjectinComponents_Start();
            while (true)
            {
                Input();
                AllGameObjectinComponents_Update();
                AllGameObjectinMeshRenderer_Render();
            }
        }

        protected void Input()
        {
        }
        protected void AllGameObjectinComponents_Start()
        {
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.components)
                {
                    component.Start();
                }
            }
        }

        protected void AllGameObjectinComponents_Update()
        {
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.components)
                {
                    component.Update();
                }
            }
        }

        protected void AllGameObjectinMeshRenderer_Render()
        {
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.components)
                {
                    bool result = component is MeshRenderer;
                    if (result)
                    {
                        MeshRenderer temp = component as MeshRenderer;
                        temp.Render();
                    }
                }
            }
        }
    }
}
