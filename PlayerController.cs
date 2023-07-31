using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class PlayerController : Component
    {
        public PlayerController() { }
        ~PlayerController() { }

        public override void Update() 
        {
            if (Input.GetKeyDown(ConsoleKey.W) )
            {
                if (PredictMove(transform.x, transform.y - 1))
                {
                    transform.Translate(0, -1);
                }
            }
            if (Input.GetKeyDown(ConsoleKey.S))
            {
                if (PredictMove(transform.x, transform.y + 1))
                {
                    transform.Translate(0, 1);
                }
            }
            if (Input.GetKeyDown(ConsoleKey.A))
            {
                if (PredictMove(transform.x-1, transform.y))
                {
                    transform.Translate(-1, 0);
                }
            }
            if (Input.GetKeyDown(ConsoleKey.D))
            {
                if (PredictMove(transform.x + 1, transform.y))
                {
                    transform.Translate(1, 0);
                }
            }
        }

        protected bool PredictMove(int newX, int newY)
        {
            foreach (var gameObject in Engine.GetInstance().GetAllGameObjects()) 
            {
                //다음 갈곳 오브젝트 구하기
                if (gameObject.transform.x == newX &&
                    gameObject.transform.y == newY )
                {
                    //모든 컴포넌트 가져오기
                    foreach(var component in gameObject.components)
                    {
                        if (component is Collider)
                        {
                            Collider checkCopmponent = component as Collider;
                            if ( checkCopmponent.isCollide)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
