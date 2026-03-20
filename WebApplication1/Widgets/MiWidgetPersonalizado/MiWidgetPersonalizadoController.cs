using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Services;
using WebApplication1.Widgets.MiWidgetPersonalizado.Models;

namespace WebApplication1.Widgets
{
    [ControllerToolboxItem(
        Name = "MiWidgetPersonalizado",
        Title = "Mi Widget Personalizado",
        SectionName = "Custom Widgets",
        Description = "Widget que muestra datos de ejemplo")]

    public class MiWidgetPersonalizadoController : Controller
    {
        public ActionResult Index()
        {
            var items = new List<ItemWidget>
            {
                new ItemWidget { Id = 1, Nombre = "Item 1", Valor = "Valor 1" },
                new ItemWidget { Id = 2, Nombre = "Item 2", Valor = "Valor 2" },
                new ItemWidget { Id = 3, Nombre = "Item 3", Valor = "Valor 3" }
            };

            var model = new WidgetDataModel
            {
                Titulo = "Datos del Widget",
                Descripcion = "Widget personalizado simple",
                Items = items,
                FechaCreacion = DateTime.Now,
                FechaRender = DateTime.Now
            };

            return View(model);
        }
    }
}

 