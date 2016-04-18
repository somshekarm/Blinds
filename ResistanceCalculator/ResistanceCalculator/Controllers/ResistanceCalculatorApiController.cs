using CalculatorLibrary;
using ResistanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ResistanceCalculator.Controllers
{
    public class ResistanceCalculatorApiController : ApiController
    {
        public JsonResult<ColorBandCollection> Get()
        {
            var bandAColor = new List<ColorBand>()
            {
                ColorBand.Info(Color.None),
                ColorBand.Info(Color.Brown),
                ColorBand.Info(Color.Red),
                ColorBand.Info(Color.Orange),
                ColorBand.Info(Color.Yellow),
                ColorBand.Info(Color.Green),
                ColorBand.Info(Color.Blue),
                ColorBand.Info(Color.Violet),
                ColorBand.Info(Color.Grey),
                ColorBand.Info(Color.White)
            };

            var bandBColor = new List<ColorBand>()
            {
                ColorBand.Info(Color.None),
                ColorBand.Info(Color.Black),
                ColorBand.Info(Color.Brown),
                ColorBand.Info(Color.Red),
                ColorBand.Info(Color.Orange),
                ColorBand.Info(Color.Yellow),
                ColorBand.Info(Color.Green),
                ColorBand.Info(Color.Blue),
                ColorBand.Info(Color.Violet),
                ColorBand.Info(Color.Grey),
                ColorBand.Info(Color.White)
            };
            var bandCColor = new List<ColorBand>()
            {
                ColorBand.Info(Color.None),
                ColorBand.Info(Color.Black),
                ColorBand.Info(Color.Brown),
                ColorBand.Info(Color.Red),
                ColorBand.Info(Color.Orange),
                ColorBand.Info(Color.Yellow),
                ColorBand.Info(Color.Green),
                ColorBand.Info(Color.Blue),
                ColorBand.Info(Color.Gold),
                ColorBand.Info(Color.Silver)
            };
            var bandDColor = new List<ColorBand>()
            {
                ColorBand.Info(Color.None),
                ColorBand.Info(Color.Brown),
                ColorBand.Info(Color.Red),  
                ColorBand.Info(Color.Gold),
                ColorBand.Info(Color.Silver)
            };
            return Json(new ColorBandCollection(new BandGroup("A", bandAColor), new BandGroup("B", bandBColor), new BandGroup("C", bandCColor), new BandGroup("D", bandDColor)));
        }

        public string Post(List<BandGroup> colorBands)
        {
            var ohmCalculator = new OhmValueCalculator();
            var bandAColor = colorBands.Where(x => x.Name == "A").First().ColorBands.First();
            var bandBColor = colorBands.Where(x => x.Name == "B").First().ColorBands.First();
            var bandCColor = colorBands.Where(x => x.Name == "C").First().ColorBands.First();
            var bandDColor = colorBands.Where(x => x.Name == "D").First().ColorBands.First();
            var ohmValue = ohmCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
           
            return ohmValue;
        }
    }
}