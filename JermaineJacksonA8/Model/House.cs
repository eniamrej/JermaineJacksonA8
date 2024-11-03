
using System.Text.Json.Serialization;

namespace JermaineJacksonA8.Model
{
    internal class House
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [JsonPropertyName("address")]
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonPropertyName("city")]
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonPropertyName("state")]
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [JsonPropertyName("price")]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the time on market.
        /// </summary>
        /// <value>
        /// The time on market.
        /// </value>
        [JsonPropertyName("time_on_market")]
        public int TimeOnMarket { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="House"/> class.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="price">The price.</param>
        /// <param name="timeOnMarket">The time on market.</param>
        public House(string address, string city, string state, string zipCode, double price, int timeOnMarket)
        {
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Price = price;
            TimeOnMarket = timeOnMarket;
        }

        public override string ToString()
        {
            return $"House: {Address} - Listed at: ${Price:N0} - On Market: {TimeOnMarket} months";
        }
    }
}
