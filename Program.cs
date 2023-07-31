﻿using SDL2;

namespace L20230725
{
    class Program
    {
        public static void Main(string[] args)
        {
            SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING);

            SDL.SDL_CreateWindow("Game", 100, 100, 640, 480, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            while(true)
            {

            }

            SDL.SDL_Quit();
        }
    }


    //class Program
    //{
    //    static int[,] map = {
    //            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    //            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    //            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    //            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
    //        };
    //    static void Main(string[] args)
    //    {
    //        Engine myEngine = Engine.GetInstance();

    //        for (int y = 0; y < 10; ++y)
    //        {
    //            for (int x = 0; x < 10; ++x)
    //            {
    //                if (map[y, x] == 1)
    //                {
    //                    GameObject floor = new GameObject();
    //                    floor.name = "floor";
    //                    floor.transform.x = x;
    //                    floor.transform.y = y;
    //                    floor.AddComponent(new MeshFilter(' '));
    //                    floor.AddComponent(new MeshRenderer());
    //                    myEngine.Instanciate(floor);

    //                    GameObject wall = new GameObject();
    //                    wall.name = "wall";
    //                    wall.transform.x = x;
    //                    wall.transform.y = y;
    //                    wall.AddComponent(new MeshFilter('*'));
    //                    wall.AddComponent(new MeshRenderer());
    //                    wall.AddComponent(new Collider());
    //                    myEngine.Instanciate(wall);
    //                }
    //                else if (map[y, x] == 0)
    //                {
    //                    GameObject floor = new GameObject();
    //                    floor.name = "floor";
    //                    floor.transform.x = x;
    //                    floor.transform.y = y;
    //                    floor.AddComponent(new MeshFilter(' '));
    //                    floor.AddComponent(new MeshRenderer());
    //                    myEngine.Instanciate(floor);
    //                }
    //            }

    //        }

    //        GameObject goal = new GameObject();
    //        goal.name = "goal";
    //        goal.transform.x = 8;
    //        goal.transform.y = 8;
    //        goal.AddComponent(new MeshFilter('G'));
    //        goal.AddComponent(new MeshRenderer());
    //        goal.AddComponent(new GoalIn());
    //        myEngine.Instanciate(goal);

    //        GameObject monster = new GameObject();
    //        monster.name = "monster";
    //        monster.transform.x = 7;
    //        monster.transform.y = 7;
    //        monster.AddComponent(new MeshFilter('M'));
    //        monster.AddComponent(new MeshRenderer());
    //        monster.AddComponent(new AIController());
    //        myEngine.Instanciate(monster);

    //        GameObject player = new GameObject();
    //        player.name = "player";
    //        player.transform.x = 1;
    //        player.transform.y = 1;
    //        player.AddComponent(new MeshFilter('P'));
    //        player.AddComponent(new MeshRenderer());
    //        player.AddComponent(new PlayerController());
    //        myEngine.Instanciate(player);

    //        myEngine.Run();
    //    }
    //}
}
