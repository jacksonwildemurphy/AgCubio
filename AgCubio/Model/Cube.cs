// Written by Robert Weischedel and Jackson Murphy for CS 3500. Last updated November 16, 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    /// <summary>
    /// Represents a two-dimensional square (contrary to its name "Cube"). A Cube has a position, color, unique id, and other properties.
    /// </summary>
    public class Cube
    {

        /// <summary>
        /// The location of the Cube on the X-axis
        /// </summary>
        [JsonProperty]
        public double loc_x { get; private set; }

        /// <summary>
        /// The location of the Cube on the Y-axis
        /// </summary>
        [JsonProperty]
        public double loc_y { get; private set; }

        /// <summary>
        /// The color of the cube on the ARGB color scale
        /// </summary>
        [JsonProperty]
        public int argb_color { get; private set; }


        /// <summary>
        /// A unique identification number for this cube
        /// </summary>
        [JsonProperty]
        public int uid { get; private set; }

        /// <summary>
        /// A Team ID for this cube. Cubes on the same team have the same Team ID
        /// </summary>
        [JsonProperty]
        public int team_id { get; private set; }

        /// <summary>
        /// Food is true if this cube is a food cube. Food is false otherwise.
        /// </summary>
        [JsonProperty]
        public bool food { get; private set; }

        /// <summary>
        /// The name of this cube. The name need not be unique.
        /// </summary>
        [JsonProperty]
        public String Name { get; private set; }

        /// <summary>
        /// The mass of this cube
        /// </summary>
        [JsonProperty]
        public double Mass { get; private set; }

        /// <summary>
        /// The width of this cube. Because a cube is actually a square, the cube's height is identical to its width.
        /// </summary>
        public int Width
        {
            get
            {
                return (int)Math.Pow(Mass, 0.65);
            }
        }

        
        /// <summary>
        /// This is the constructor for the Cube class, it brings in all values that a cube is made of and creates the cube object. 
        /// </summary>
        [JsonConstructor]
        public Cube(double loc_x, double loc_y, int argb_color, int uid, int team_id, bool food, String Name, double Mass)
        {
            // Store all the cube information into the member variables in the class. 
            this.loc_x = loc_x;

            this.loc_y = loc_y;

            this.argb_color = argb_color;

            this.uid = uid;

            this.team_id = team_id;

            this.food = food;

            this.Name = Name;

            this.Mass = Mass;
        }


        /// <summary>
        /// This method serves as a override for the GetHashCode method so that we could use a HashSet to store all our cubes. The HashCode for each cube is its uid, which is unique for 
        /// each cube making it an effective Hash Value.
        /// </summary>
        /// <returns>The int uid value of this cube obj.</returns>
        public override int GetHashCode()
        {
            // Return the uid of this cube as the Hash Value.
            return this.uid;
        }

        /// <summary>
        /// Override the Equals method so that we can effectively compare cubes that have been stored in our HashSet.
        /// </summary>
        /// <param name="obj">The obj you wish to see if it is equal to the cube obj this method is invoked on.</param>
        /// <returns>A bool stating of the two objs are equal to each other.</returns>
        public override bool Equals(object obj)
        {
            // If the obj is null return false.
            if (obj == null)
                return false;

            // If the obj is not of type cube return false.
            if (! (obj is Cube))
                return false;
            
            // Cast the obj as a cube obj
            Cube c = (Cube)obj;

            // If the uid dont match return false
            if (c.uid != this.uid)
                return false;

            return true;

        }

        /// <summary>
        /// Equals compares two cubes are the same, if an only if the uid of both cubes are same they are equal.
        /// </summary>
        /// <param name="cube">The cube obj you wish to compare.</param>
        /// <returns>A bool stating of the two cubes are equal to each other.</returns>
        public bool Equals(Cube cube)
        {
            // If the cube is null, return false.
            if (cube == null)
            {
                return false;
            }

            // If both uids are the same return true, if not false.
            return (cube.uid == this.uid ? true : false);
        }
    }
}
