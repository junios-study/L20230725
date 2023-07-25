using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine();

            //Init
            //Load
            for (int i = 0; i < 10; ++i)
            {
                GameObject wall = new GameObject();
                wall.name = "wall";
                wall.transform.x = i;
                wall.transform.y = 0;
                wall.AddComponent(new MeshFilter('*'));
                wall.AddComponent(new MeshRenderer());
                myEngine.Instanciate(wall);
            }


            GameObject player = new GameObject();
            player.name = "player";
            player.transform.x = 1;
            player.transform.y = 1;
            player.AddComponent(new MeshFilter('P'));
            player.AddComponent(new MeshRenderer());
            myEngine.Instanciate(player);

            myEngine.Run();
        }
    }
}
