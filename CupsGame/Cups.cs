using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupsGame
{
    class Cups
    {
        private String name;
        private Ball ball;
      
        public Cups(String name)
        {
            this.name = name;
            ball = null;
        }

        public Ball hasBall()
        {
            return ball;
        }

        public Ball getBall()
        {
            return ball;
        }

        public void setBall(Ball ball)
        {
            this.ball = ball;
        }
    }
}
