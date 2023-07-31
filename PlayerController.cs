using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class PlayerController : Controller
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


    }
}
