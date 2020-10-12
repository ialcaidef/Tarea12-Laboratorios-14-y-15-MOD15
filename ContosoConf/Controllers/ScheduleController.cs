using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class ScheduleController : Controller
    {
        public class ScheduleItem
        {
            public string id { get; set; }
            public string title { get; set; }
            public string subTitle { get; set; }
            public string speakerName { get; set; }
            public string start { get; set; }
            public string end { get; set; }
            public int[] tracks { get; set; }
            public string room { get; set; }
            public int starCount { get; set; }
        }

        static readonly Random random = new Random();
        static readonly IEnumerable<ScheduleItem> schedule;

        static int RandomStarCount()
        {
            return random.Next(5, 99);
        }

        static ScheduleController()
        {
            schedule = new[]
            {
                new ScheduleItem
                {
                    id = "session-1",
                    title = "Registration",
                    subTitle = "Consigue tu placa y tu bolsa de regalos.",
                    speakerName = null,
                    start = "08:30",
                    end = "08:55",
                    tracks = new[] {1, 2},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-2",
                    title = "Avanzar en la Web con HTML5",
                    subTitle = "",
                    speakerName = "Melissa Kerr",
                    start = "09:00",
                    end = "09:55",
                    tracks = new[] {1, 2},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-3",
                    title = "Sumergiéndose en las profundidades con Canvas",
                    subTitle = "",
                    speakerName = "David Alexander",
                    start = "10:00",
                    end = "10:55",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-4",
                    title = "Nuevas tecnologías en la empresa",
                    subTitle = "",
                    speakerName = "April Meyer",
                    start = "10:00",
                    end = "11:55",
                    tracks = new[] {2},
                    room = "B",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-5",
                    title = "WebSockets y tú",
                    subTitle = "",
                    speakerName = "Mark Hanson",
                    start = "11:00",
                    end = "11:55",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-6",
                    title = "Descanso para café y pasteles",
                    subTitle = "Consigue toda la cafeína y el azúcar que puedas, ¡vas a necesitarlo!",
                    speakerName = null,
                    start = "12:00",
                    end = "12:25",
                    tracks = new[] {1, 2},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-7",
                    title = "Creación de UI con capacidad de respuesta",
                    subTitle = "",
                    speakerName = "Dylan Miller",
                    start = "12:30",
                    end = "12:55",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-8",
                    title = "Diversión con las formas (¡no, de verdad!)",
                    subTitle = "",
                    speakerName = "Anne Wallace",
                    start = "12:30",
                    end = "12:55",
                    tracks = new[] {2},
                    room = "B",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-9",
                    title = "Una nueva mirada a los diseños",
                    subTitle = "",
                    speakerName = "William Flash",
                    start = "13:00",
                    end = "13:55",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-10",
                    title = "Aplicaciones en el mundo real de las API de HTML5",
                    subTitle = "",
                    speakerName = "Ken Ewert",
                    start = "13:00",
                    end = "13:55",
                    tracks = new[] {2},
                    room = "B",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-11",
                    title = "Lunch",
                    subTitle = "Patrocinado por Medior Inc.",
                    speakerName = null,
                    start = "14:00",
                    end = "15:25",
                    tracks = new[] {1, 2},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-12",
                    title = "Cómo manejar el Javascript",
                    subTitle = "",
                    speakerName = "Dominik Paiha",
                    start = "15:30",
                    end = "16:25",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-13",
                    title = "Transformaciones y animaciones",
                    subTitle = "",
                    speakerName = "John Clarkson",
                    start = "15:30",
                    end = "16:25",
                    tracks = new[] {2},
                    room = "B",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-14",
                    title = "Aventuras de diseño web con CSS3",
                    subTitle = "",
                    speakerName = "Christine Koch",
                    start = "16:30",
                    end = "17:25",
                    tracks = new[] {1},
                    room = "A",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-15",
                    title = "Introducción del acceso a los datos y el almacenamiento en memoria caché",
                    subTitle = "",
                    speakerName = "Nelson Siu",
                    start = "16:30",
                    end = "17:25",
                    tracks = new[] {2},
                    room = "B",
                    starCount = RandomStarCount()
                },
                new ScheduleItem
                {
                    id = "session-16",
                    title = "Agradecimientos y premios de cierre",
                    subTitle = "",
                    speakerName = null,
                    start = "17:30",
                    end = "17:55",
                    tracks = new[] {1, 2},
                    room = "A",
                    starCount = RandomStarCount()
                }
            };
        }

        public ActionResult List()
        {
            if (Request.Url.Query != "?fail")
            {
                return Json(new { schedule }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = 503;
                return Json(new { message = "El servicio no está disponible actualmente." }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Star(string id, bool starred)
        {
            var item = schedule.First(s => s.id == id);
            item.starCount += starred ? 1 : -1;
            return Json(new { item.starCount });
        }
    }
}