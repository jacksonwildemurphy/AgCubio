// Written by Robert Weischedel and Jackson Murphy for CS 3500. Last updated November 17, 2015.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace AgCubioUnitTests
{
    /// <summary>
    /// A class for testing the Cube and World classes in the AgCubio Model
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Make sure constructor works and the Width property gets set properly
        /// </summary>
        [TestMethod]
        public void TestCubeConstructor1()
        {

            Cube cube = new Cube(813.0, 878.0, -2987746, 5318, 0, false, "Myname", 1029.1106844616961);

            Assert.IsTrue((int)cube.loc_x == 813);

            Assert.IsTrue((int)cube.loc_y == 878);

            Assert.IsTrue(cube.argb_color == -2987746);

            Assert.IsTrue(cube.uid == 5318);

            Assert.IsTrue(cube.team_id == 0);

            Assert.IsTrue(cube.food == false);

            Assert.IsTrue(cube.Name == "Myname");


            int cubeWidth = cube.Width;

        }

        /// <summary>
        /// Makes sure our Equals(Cube cube) method works properly.
        /// </summary>
        [TestMethod]
        public void TestCubeEquals()
        {

            Cube cube1 = new Cube(813.0, 878.0, -2987746, 5318, 0, false, "Myname", 1029.1106844616961);

            // UID is the same as cube2 even though other properties are different.
            Cube cube2 = new Cube(0.0, 0.0, 0, 5318, 0, false, "Myname", 0.0);

            Cube cube3 = null;

            // UID is different than cube1
            Cube cube4 = new Cube(813.0, 878.0, -2987746, 1, 0, false, "Myname", 1029.1106844616961);

            Assert.IsTrue(cube1.Equals(cube2));
            Assert.IsFalse(cube1.Equals(cube3));
            Assert.IsFalse(cube1.Equals(cube4));

        }



        /// <summary>
        /// Makes sure our Equals(Object cube) method works properly.
        /// </summary>
        [TestMethod]
        public void TestCubeObjectEquals()
        {

            Cube cube1 = new Cube(813.0, 878.0, -2987746, 5318, 0, false, "Myname", 1029.1106844616961);

            // UID is the same as cube2 even though other properties are different.
            Cube cube2 = new Cube(0.0, 0.0, 0, 5318, 0, false, "Myname", 0.0);

            Cube cube3 = null;

            // UID is different than cube1
            Cube cube4 = new Cube(813.0, 878.0, -2987746, 1, 0, false, "Myname", 1029.1106844616961);

            Assert.IsTrue(cube1.Equals((object)cube2));
            Assert.IsFalse(cube1.Equals((object)cube3));
            Assert.IsFalse(cube1.Equals((object)cube4));
            Assert.IsFalse(cube1.Equals("A string is not equal to a cube"));

        }


        /// <summary>
        /// Two cubes having the same UID should be treated as duplicates by the 
        /// AddOrUpdate method and therefore the second cube shouldn't be added to
        /// the world.
        /// </summary>
        [TestMethod]
        public void TestAddOrUpdateCubeForSameUID()
        {

            World world = new World(1000, 1000);

            Cube cube = new Cube(813.0, 878.0, -2987746, 5318, 0, false, "Myname", 1029.1106844616961);

            world.AddOrUpdateCube(cube);

            Cube cube2 = new Cube(500.0, 300.0, -2987746, 5318, 0, false, "Myname", 1029.1106844616961);

            world.AddOrUpdateCube(cube2);

            Assert.IsTrue(world.Cubes.Count == 1);

            
        }

        /// <summary>
        /// Adding a cube with mass 0 when it already exists in the world should
        /// remove the cube from the world.
        /// </summary>
        [TestMethod]
        public void TestAddOrUpdateCubeForAddingCubeWith0Mass()
        {

            World world = new World(1000, 1000);

            // Create cube with mass of 10
            Cube cube = new Cube(0, 0, -2987746, 1, 0, false, "Myname", 10.0);
            world.AddOrUpdateCube(cube);

            // Create another cube with same uid as first but whose mass is 0
            Cube cube2 = new Cube(0.0, 0.0, -2987746, 1, 0, false, "Myname", 0.0);

            world.AddOrUpdateCube(cube2);

            Assert.IsTrue(world.Cubes.Count == 0);


        }
    }
}
