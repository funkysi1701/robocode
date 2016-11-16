using Robocode;
using Robocode.Util;
using System;
using System.Drawing;

namespace SimonRobot
{
    public class SimonBot : Robot
    {
        
        public override void Run()
        {
            BodyColor = (Color.Red);
            GunColor = (Color.Green);
            RadarColor = (Color.Yellow);
            ScanColor = (Color.Blue);
            BulletColor = (Color.White);

            for (;;)
            {
                Ahead(10);
                Random r = new Random();
                int coin = r.Next(1, 360);
                TurnRadarRight(coin);
                Scan();
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            double absoluteBearing = Heading + e.Bearing;
            double bearingFromGun = Utils.NormalRelativeAngleDegrees(absoluteBearing - GunHeading);

            // If it's close enough, fire!
            if (Math.Abs(bearingFromGun) <= 3)
            {
                TurnGunRight(bearingFromGun);
                // We check gun heat here, because calling Fire()
                // uses a turn, which could cause us to lose track
                // of the other robot.
                if (GunHeat == 0)
                {
                    Fire(Math.Min(3 - Math.Abs(bearingFromGun), Energy - .1));
                }
            }
            else
            {
                TurnRight(bearingFromGun);
            }
            //TurnRight(90);
            //Fire(1);
            ////TurnGunRight(10);
        }

        public override void OnHitWall(HitWallEvent evnt)
        {
            Random r = new Random();
            int coin = r.Next(1, 360);
            TurnRight(coin);
            Ahead(20);
            base.OnHitWall(evnt);
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            Random r = new Random();
            int coin = r.Next(1, 3);
            if (coin == 1)
            {
                TurnRight(90);
                BodyColor = (Color.YellowGreen);
            }
            else
            {
                TurnLeft(90);
                BodyColor = (Color.Purple);
            }
            
            Back(100);
            base.OnHitByBullet(evnt);
        }

    }
}