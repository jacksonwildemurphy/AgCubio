using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// This class serves as the game world, storing all our cube objects and the width and height of the world.
    /// </summary>
    public class World

    {
        /// <summary>
        /// This member variable stores the value for the width of the game world. 
        /// </summary>
        private readonly double Width;

        /// <summary>
        /// This member variable stores the value for the height of the game world. 
        /// </summary>
        private readonly double Height;

        /// <summary>
        /// This member variable stores all the Cubes in the game world, food and player alike.
        /// </summary>
        public HashSet<Cube> Cubes { get; private set; }

        /// <summary>
        /// This serves as the constructor for the World. It takes in the desired width and height of the world and creates a new HashSet of cubes in order to store all the cube
        /// objects in.
        /// </summary>
        /// <param name="Width">A double value containing the desired width of the world.</param>
        /// <param name="Height">A double value containing the desired height of the world.</param>
        public World(double Width, double Height)
        {
            // Create the HashSet to store all the cubes in the world.
            Cubes = new HashSet<Cube>();

            // Set the world width and height. 
            this.Width = Width;
            this.Height = Height;
        }

        /// <summary>
        /// This method allows you to add new cubes, update a cube or completely remove a cube from the world.
        /// </summary>
        /// <param name="cube">The cube obj you wihsh to add or update in the world.</param>
        public void AddOrUpdateCube(Cube cube)
        {
            // If the cube is in the HashSet
            if (Cubes.Contains(cube))
            {
                // If the mass of the cube is 0, remove it.
                if(cube.Mass == 0)
                {
                    Cubes.Remove(cube);
                }
                // Else, remove the old version of it and add the updated version.
                else
                {                   
                    Cubes.Remove(cube);

                    Cubes.Add(cube);
                }
            }
            // If the cube doesn't exist in the HashSet add it. 
            else
            {        
                Cubes.Add(cube);
            }
            
        }

    }
}
