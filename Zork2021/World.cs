using System;
using System.Collections.Generic;
using System.Text;

namespace Zork2021
{
    class World
    {
        //we need to hold all the areas
        List<Area> allAreas;

        //current area the player is in
        public Area currentArea;

        //when we make it we should: make areas, and make connections
        public World(){
            //todo: build the map and set the current area
            Area a1 = new Area("Living room", "The living room pulsates with unholy life");
            Area a2 = new Area("Toilet", "It hasn't been cleaned in a while...");
            Area a3 = new Area("Hallway", "It's very loooooong");
            Area a4 = new Area("Candy shop", "it sells lollipops for 50 cents");
            Area a5 = new Area("Dragon's lair", "you can find nerds and magic in here");
            Area a6 = new Area("Pizza Hut", "here you can replennish your hp");

            a1.AddConnection(Directions.East, a3, true);
            a2.AddConnection(Directions.West, a3, true);
            a3.AddConnection(Directions.South, a4, true);
            a4.AddConnection(Directions.South, a5, true);
            a5.AddConnection(Directions.West, a6);
            a6.AddConnection(Directions.North, a2);

            currentArea = a1;
        }

        /// <summary>
        /// Prints in the console the description of the current area
        /// </summary>
        internal void PrintCurrentAreaDescription()
        {
            
        }

        /// <summary>
        /// Tries to move the player ot a different area by moving in the specified direction
        /// </summary>
        /// <param name="direction"></param>
        /// <returns>true if successful, false if the move was not possible</returns>
        internal bool Go(Directions direction)
        {
            throw new NotImplementedException();
        }
    }
}
