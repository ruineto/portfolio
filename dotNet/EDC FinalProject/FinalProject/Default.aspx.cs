using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


namespace FinalProject
{
    public partial class _Default : Page
    {
        weatherService.WeatherDescription[] weatherlist;

        protected void Page_Load(object sender, EventArgs e)
        {

            weatherService.Weather we = new weatherService.Weather();
            weatherService.WeatherReturn wr = new weatherService.WeatherReturn();

            wr = we.GetCityWeatherByZIP("97365");

            weatherTemperature.Text = ((int.Parse(wr.Temperature) - 32) * (5 / (float)9)).ToString("0") +"º";
            weatherlist = we.GetWeatherInformation();
            switch (wr.Description) 
            {
                case "Sunny": weatherDescription.Text = "Céu Limpo"; weatherIcon.ImageUrl = @"~/WeatherIcons/sunny.gif"; break;

                case "Drizzle": weatherDescription.Text = "Aguaçeiros"; weatherIcon.ImageUrl = @"~/WeatherIcons/drizzle.gif"; break;

                case "Thunder Storms": weatherDescription.Text = "Trovoada"; weatherIcon.ImageUrl = @"~/WeatherIcons/thunderstorms.gif"; break;

                case "Mostly Cloudy": weatherDescription.Text = "Muito Nublado"; weatherIcon.ImageUrl = @"~/WeatherIcons/mostlycloudy.gif"; break;

                case "Rain": weatherDescription.Text = "Chuva"; weatherIcon.ImageUrl = @"~/WeatherIcons/rain.gif"; break;

                default: weatherDescription.Text = ""; weatherIcon.ImageUrl = @"~/WeatherIcons/na.gif"; break;
            }

            //using (var db = new Models.HouseContext())
            //{
            //    try
            //    {
            //        //var project = new R5ProjectManagement.Models.Project { ProjectName = "Hotel da Ria", Description = "bla bla bla" };
            //        //db.Projects.Add(project);
            //        //db.SaveChanges();

            //        // Display all Blogs from the database
            //        var query = from b in db.House
            //                    orderby b.HouseID
            //                    select b;
            //    }
            //    catch (DbEntityValidationException dbEx)
            //    {
            //        Console.WriteLine(dbEx);
            //    }
            //}
            // Execute webservice weather/*
            //ServiceWeather.GlobalWeatherSoapClient gw = new ServiceWeather.GlobalWeatherSoapClient("GlobalWeatherSoap");
            //string t = gw.GetWeather("Lisboa", "Portugal");
            //weather.Text = t;
        }

        
    }
}