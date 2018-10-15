using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Plant : GardenObject
    {
        /// <summary>
        /// The plant desc
        /// </summary>
        private string _plantDesc;

        /// <summary>
        /// The plant family
        /// </summary>
        private string _plantFamily;

        /// <summary>
        /// The price
        /// </summary>
        private int _price;

        /// <summary>
        /// The water frequency
        /// </summary>
        private int _waterFrequency;

        /// <summary>
        /// The maximum temperature
        /// </summary>
        private float _maxTemperature;

        /// <summary>
        /// The minimum temperature
        /// </summary>
        private float _minTemperature;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public Plant(int id, string name) : base(id, name)
        {
        }

        //private enum Season
        //{
        //    Summer, Autumn, Winter, Spring
        //}

        //private enum SunTolerance
        //{
        //    FullSun, PartShade, FullShade
        //}

        /// <summary>
        /// Gets or sets the maximum temperature.
        /// </summary>
        /// <value>
        /// The maximum temperature.
        /// </value>
        public float MaxTemperature { get => _maxTemperature; set => _maxTemperature = value; }

        /// <summary>
        /// Gets or sets the minimum temperature.
        /// </summary>
        /// <value>
        /// The minimum temperature.
        /// </value>
        public float MinTemperature { get => _minTemperature; set => _minTemperature = value; }

        /// <summary>
        /// Gets or sets the plant desc.
        /// </summary>
        /// <value>
        /// The plant desc.
        /// </value>
        public string PlantDesc { get => _plantDesc; set => _plantDesc = value; }

        /// <summary>
        /// Gets or sets the plant family.
        /// </summary>
        /// <value>
        /// The plant family.
        /// </value>
        public string PlantFamily { get => _plantFamily; set => _plantFamily = value; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price { get => _price; set => _price = value; }

        /// <summary>
        /// Gets or sets the water frequency.
        /// </summary>
        /// <value>
        /// The water frequency.
        /// </value>
        public int WaterFrequency { get => _waterFrequency; set => _waterFrequency = value; }
    }
}